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

                string connectionString = $"Host={pgHost};Database={pgDatabase};Username={pgUser};Password={pgPassword}";

                using (var pgConnection = new NpgsqlConnection(pgConnectionString))
                {
                    pgConnection.Open();
                    foreach (DataRow tabla in tablas.Rows)
                    {
                        string nombreTabla = tabla["table_name"].ToString();
                        SincronizarTabla(pgConnection, nombreTabla);

                    }
                    foreach (DataRow vista in vistas.Rows)
                    {
                        string nombreVista = vista["viewname"].ToString();

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

        }
        private void CrearTablaPostgreSQL(NpgsqlConnection pgConn, string tablaNombre, DataTable esquema)
        {
            var columnas = new List<string>();

            foreach (DataColumn columna in esquema.Columns)
            {
            }

            string sql = $"CREATE TABLE IF NOT EXISTS {tablaNombre} ({string.Join(", ", columnas)})";

            using (var cmd = new NpgsqlCommand(sql, pgConn))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}