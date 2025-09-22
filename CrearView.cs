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
    public partial class CrearView : Form
    {
        private string _connectionName;
        public CrearView(string connectionName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            this.Text = $"Crear View en - {_connectionName}";
        }

        private void btn_GuardarView_Click(object sender, EventArgs e)
        {
            try
            {
                string viewName = txt_NombreView.Text.Trim();
                string selectQuery = rtb_SqlView.Text.Trim();

                if (string.IsNullOrEmpty(viewName))
                {
                    MessageBox.Show("Ingrese el nombre de la vista.");
                    return;
                }
                if (string.IsNullOrEmpty(selectQuery))
                {
                    MessageBox.Show("Ingrese la consulta SELECT para la vista.");
                    return;

                }
                if (!selectQuery.ToUpper().Contains("SELECT"))
            {
                MessageBox.Show("La consulta debe contener una declaración SELECT.");
                return;
            }
            string createViewSQL = $"CREATE VIEW {viewName} AS \n" +
                    $"{selectQuery}";
            DatabaseService.ExecuteNonQuery(_connectionName, createViewSQL);
            MessageBox.Show($"Vista creada exitosamente en: {_connectionName}");
            this.DialogResult = DialogResult.OK;
            this.Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear vista: {ex.Message}");
            }
            
        }
        
    }
    
}
