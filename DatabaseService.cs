using iAnywhere.Data.SQLAnywhere;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public static class DatabaseService
    {
        private static Dictionary<string, OdbcConnection> _activeConnections = new Dictionary<string, OdbcConnection>();
        public static OdbcConnection GetConnection(string server, string database, string user, string password)
        {
            string connectionString = $"Driver={{SQL Anywhere 17}};Server={server};Database={database};Uid={user};Pwd={password};";

            try
            {
                var connection = new OdbcConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar: {ex.Message}");
            }
        }

        // Ejecutar consultas INSERT/UPDATE/DELETE
        public static int ExecuteNonQuery(string connectionName, string sql, params OdbcParameter[] parameters)
        {
            if (!_activeConnections.ContainsKey(connectionName))
                throw new Exception("Conexión no encontrada.");

            using (var cmd = new OdbcCommand(sql, _activeConnections[connectionName]))
            {
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // Ejecutar consultas SELECT
        public static DataTable ExecuteQuery(string connectionName, string sql)
        {
            if (!_activeConnections.ContainsKey(connectionName))
                throw new Exception("Conexión no encontrada.");

            DataTable dt = new DataTable();
            using (var cmd = new OdbcCommand(sql, _activeConnections[connectionName]))
            using (var adapter = new OdbcDataAdapter(cmd))
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        // Añadir conexión al diccionario para reutilizar
        public static void AddConnection(string name, string server, string database, string user, string password)
        {
            if (!_activeConnections.ContainsKey(name))
            {
                var conn = GetConnection(server, database, user, password);
                _activeConnections.Add(name, conn);
            }
        }
    }
}
