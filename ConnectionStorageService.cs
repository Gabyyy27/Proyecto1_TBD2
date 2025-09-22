using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Proyecto1_TBD2
{
    public static class ConnectionStorageService
    {
        private static string _filePath = "connections.json";

        public static void SaveConnection(ConexionesGuardadas connection)
        {
            // Carga conexiones existentes
            var connections = LoadConnections();

            // Elimina si ya existe
            connections.RemoveAll(c => c.Name == connection.Name);

            // Agrega nueva
            connections.Add(connection);

            // Guarda
            File.WriteAllText(_filePath, JsonSerializer.Serialize(connections));
        }

        public static List<ConexionesGuardadas> LoadConnections()
        {
            if (!File.Exists(_filePath))
                return new List<ConexionesGuardadas>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<ConexionesGuardadas>>(json) ?? new List<ConexionesGuardadas>();
        }
    }

}
