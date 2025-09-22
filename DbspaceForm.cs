using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1_TBD2
{
    
    public partial class DbspaceForm : Form
    {
        private string _connectionName;
        public DbspaceForm(string connectionName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            this.Text = $"Tablas en Dbspace System - {connectionName}";
            LoadSystemTables();
        }
        private void LoadSystemTables()
        {
            try
            {
                string query = @"
            SELECT  t.table_name AS ""Tabla"", t.creator AS ""Propietario""
                FROM sys.sysdbspace ds
                FROM SYS.SYSTABLE t
            WHERE t.dbspace_name = 'system'
            AND t.table_type = 'BASE'
            ORDER BY t.table_name;";

                DataTable dt = DatabaseService.ExecuteQuery(_connectionName, query);
                dgv_Dbspace.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tablas: {ex.Message}");
            }
        }
    }
}
