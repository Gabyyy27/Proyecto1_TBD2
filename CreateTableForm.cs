using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public partial class CreateTableForm : Form
    {
        private string _connectionName;
        public CreateTableForm(string connectionName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            this.Text = $"Crear Tabla en - {_connectionName}";
        }

        private void btn_GuardarTable_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = txt_NombreTabla.Text.Trim();

                if (string.IsNullOrEmpty(tableName))
                {
                    MessageBox.Show("Ingrese el nombre de la tabla.");
                    return;
                }

                string createTableSQL = $"CREATE TABLE {tableName} (ID INT NOT NULL);";

                DatabaseService.ExecuteNonQuery(_connectionName, createTableSQL);
                MessageBox.Show($"Tabla creada exitosamente en: {_connectionName}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}




