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
    }
}
