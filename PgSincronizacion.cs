using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto1_TBD2
{
    public class PgSincronizacion
    {
        private string _connectionName;

        public PgSincronizacion(string connectionName)
        {
            _connectionName = connectionName;
        }
        public bool Sincronizar(string pgHost, string pgDatabase, string pgUser, string pgPassword)
        {
            try
            {
                DataTable tablas = ObtenerTablas();

                DataTable vistas = ObtenerVistas();

                string pgConnectionString = $"Host={pgHost};Database={pgDatabase};Username={pgUser};Password={pgPassword}";

                using (var pgConn = new NpgsqlConnection(pgConnectionString))
                {
                    pgConn.Open();
                    foreach (DataRow tabla in tablas.Rows)
                    {
                        string nombreTabla = tabla["table_name"].ToString();
                        SincronizarTabla(pgConn, nombreTabla);

                    }
                    foreach (DataRow vista in vistas.Rows)
                    {
                        string nombreVista = vista["viewname"].ToString();
                        SincronizarVista(pgConn, nombreVista);

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la sincronización: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private DataTable ObtenerTablas()
        {
            return DatabaseService.ExecuteQuery(_connectionName, @"SELECT table_name 
        FROM SYS.SYSTABLE
        WHERE creator = USER_ID(CURRENT USER)
        AND table_type = 'BASE'
        ORDER BY table_name");
        }
        private DataTable ObtenerVistas()
        {
            return DatabaseService.ExecuteQuery(_connectionName, @"
        SELECT viewname 
        FROM SYS.SYSVIEWS 
        WHERE vcreator = CURRENT USER
        ORDER BY viewname");

        }
        private void SincronizarTabla(NpgsqlConnection pgConn, string tablaNombre)
        {
            DataTable datos = DatabaseService.ExecuteQuery(_connectionName,
                $"SELECT * FROM {tablaNombre}");

            CrearTablaPostgreSQL(pgConn, tablaNombre, datos);

            InsertarDatosPostgreSQL(pgConn, tablaNombre, datos);
        }
        private void CrearTablaPostgreSQL(NpgsqlConnection pgConn, string tablaNombre, DataTable esquema)
        {
            var columnas = new List<string>();

            foreach (DataColumn columna in esquema.Columns)
            {
                string tipoPostgres = MapearTipoDato(columna.DataType);
                columnas.Add($"{columna.ColumnName} {tipoPostgres}");
            }

            string sql = $"CREATE TABLE IF NOT EXISTS {tablaNombre} ({string.Join(", ", columnas)})";

            using (var cmd = new NpgsqlCommand(sql, pgConn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertarDatosPostgreSQL(NpgsqlConnection pgConn, string tablaNombre, DataTable datos)
        {
            string deleteSql = $"DELETE FROM {tablaNombre}";
            using (var deleteCmd = new NpgsqlCommand(deleteSql, pgConn))
            {
                deleteCmd.ExecuteNonQuery();
            }
            foreach (DataRow fila in datos.Rows)
            {
                var nombresColumnas = string.Join(", ", datos.Columns.Cast<DataColumn>().Select(c => c.ColumnName));
                var valoresParametros = string.Join(", ", datos.Columns.Cast<DataColumn>().Select(c => $"@{c.ColumnName}"));

                string insertSql = $"INSERT INTO {tablaNombre} ({nombresColumnas}) VALUES ({valoresParametros})";

                using (var cmd = new NpgsqlCommand(insertSql, pgConn))
                {
                    foreach (DataColumn columna in datos.Columns)
                    {
                        cmd.Parameters.AddWithValue($"@{columna.ColumnName}", fila[columna]);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void SincronizarVista(NpgsqlConnection pgConn, string vistaNombre)
        {
            try
            {
                DataTable definicion = DatabaseService.ExecuteQuery(_connectionName, $"Select viewtext from SYS.SYSVIEWS where viewname = '{vistaNombre}'");
                if (definicion.Rows.Count > 0)
                  {
                    string vistaSQL = definicion.Rows[0]["viewtext"].ToString();

                    vistaSQL = ExtraerSelectDeVista(vistaSQL);

                    vistaSQL = TransformarSyntaxVistaCompleta(vistaSQL);

                    string vistaEscapada = $"\"{vistaNombre}\"";

                    string dropSql = $"DROP VIEW IF EXISTS {vistaEscapada} CASCADE";
                    using (var dropCmd = new NpgsqlCommand(dropSql, pgConn))
                    {
                        dropCmd.ExecuteNonQuery();
                    }

                    string createSql = $"CREATE OR REPLACE VIEW {vistaEscapada} AS {vistaSQL}";


                    using (var createCmd = new NpgsqlCommand(createSql, pgConn))
                    {
                        createCmd.ExecuteNonQuery();
                        Console.WriteLine($"Vista {vistaNombre} creada exitosamente");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en vista {vistaNombre}: {ex.Message}");
            }
        }
        private string ExtraerSelectDeVista(string vistaSQL)
        {
            int selectIndex = vistaSQL.IndexOf("SELECT", StringComparison.OrdinalIgnoreCase);

            if (selectIndex >= 0)
            {
                return vistaSQL.Substring(selectIndex);
            }

            return vistaSQL;
        }

        private string TransformarSyntaxVistaCompleta(string vistaSQL)
        {
            string sqlUpper = vistaSQL.ToUpper();
            vistaSQL = vistaSQL.Replace("\"Gaby_28\".", "\"public\".");
            vistaSQL = Regex.Replace(vistaSQL, @"\"".*?\""", m => m.Value.ToLower());
            vistaSQL = Regex.Replace(vistaSQL, @"\bDATETIME\b", "TIMESTAMP", RegexOptions.IgnoreCase);
            vistaSQL = Regex.Replace(vistaSQL, @"\bINT\s+IDENTITY\b", "SERIAL", RegexOptions.IgnoreCase);
            vistaSQL = vistaSQL.Replace("'", "''");

            return vistaSQL;
        }
        private string MapearTipoDato(Type tipo)
        {
            if (tipo == typeof(string)) return "TEXT";
            if (tipo == typeof(int)) return "INTEGER";
            if (tipo == typeof(long)) return "BIGINT";
            if (tipo == typeof(decimal)) return "NUMERIC";
            if (tipo == typeof(DateTime)) return "TIMESTAMP";
            if (tipo == typeof(bool)) return "BOOLEAN";

            return "TEXT";
        }

    }
}

  