using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public partial class DDLSPTForm : Form
    {
        private string _connectionName;
        private string _objectType;
        private string _objectName;
        public DDLSPTForm(string connectionName, string objectType, string objectName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            _objectType = objectType;
            _objectName = objectName;
            this.Text = $"DDL de {objectType}: {objectName}";
            LoadDDL();
        }
        private void LoadDDL()
        {
            try
            {
                string ddl = GetObjectDDLSPT();
                rtbDDLSPT.Text = ddl;
                rtbDDLSPT.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar DDL: {ex.Message}");
            }
        }

        public string GetObjectDDLSPT()
        {
            string query = "";

            if (_objectType.ToLower() == "procedimientos")
            {
                query = $@"
                    SELECT proc_defn 
                    FROM SYS.SYSPROCEDURE 
                    WHERE proc_name = '{_objectName}' 
                    AND creator = USER_ID()";
            }
            else if (_objectType.ToLower() == "triggers")
            {
                query = $@"
                    SELECT trigger_defn
                    FROM SYS.SYSTRIGGER 
                    WHERE trigger_name = '{_objectName}'";
            }
            else if (_objectType.ToLower() == "secuencias")
            {
                query = $@"
                    SELECT sequence_name 
                    FROM SYS.SYSSEQUENCE 
                    WHERE sequence_name  = '{_objectName}'";
            }
            else
            {
                return $"Tipo de objeto no soportado: {_objectType}";
            }

            DataTable dt = DatabaseService.ExecuteQuery(_connectionName, query);

            if (dt.Rows.Count == 0)
                return $"No se encontró el {_objectType.ToLower()}: {_objectName}";

            return dt.Rows[0][0].ToString();
        }

        private void btn_ExportarSql_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbDDLSPT.Text.Trim()))
                {
                    MessageBox.Show("No hay contenido para exportar.");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos SQL (*.sql)|*.sql|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Exportar consulta SQL";
                saveFileDialog.DefaultExt = "sql";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder contenido = new StringBuilder();
                    contenido.AppendLine($"-- Archivo SQL exportado");
                    contenido.AppendLine($"-- Fecha: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    contenido.AppendLine();
                    contenido.AppendLine(rtbDDLSPT.Text);

                    File.WriteAllText(saveFileDialog.FileName, contenido.ToString());
                    MessageBox.Show("Archivo exportado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar archivo: {ex.Message}");
            }
        }
    }
}
