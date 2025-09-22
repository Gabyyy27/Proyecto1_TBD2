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
    public partial class ViewP : Form
    {
        private string _connectionName;
        private string _viewName;
        public ViewP(string connectionName, string viewName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            _viewName = viewName;
            this.Text = $"Vista: {viewName}";
            LoadViewData();
            LoadViewDDL();
        }
        private void LoadViewData()
        {
            try
            {
                // Consulta para obtener datos de la tabla
                string query = $"SELECT * FROM {_viewName}";

                DataTable data = DatabaseService.ExecuteQuery(_connectionName, query);

                // Configurar DataGridView
                dgvDataView.DataSource = data;
                dgvDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDataView.AllowUserToResizeColumns = true;
                dgvDataView.AllowUserToResizeRows = true;
                dgvDataView.ReadOnly = true;
                dgvDataView.MultiSelect = false;

                // Configurar encabezados
                dgvDataView.ColumnHeadersHeight = 30;
                dgvDataView.RowHeadersWidth = 25;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }
        public string GenerateViewDDL(string connectionName, string viewName)
        {
            try
            {
                StringBuilder ddl = new StringBuilder();

                // Consulta más simple y directa
                string viewInfoQuery = $@"
                 SELECT viewname, viewtext, vcreator
                 FROM SYS.SYSVIEWS 
                 WHERE viewname = '{viewName}'";

                DataTable viewInfo = DatabaseService.ExecuteQuery(connectionName, viewInfoQuery);

                if (viewInfo.Rows.Count == 0)
                    return "Vista no encontrada";

                string owner = viewInfo.Rows[0]["vcreator"].ToString();
                string viewText = viewInfo.Rows[0]["viewtext"].ToString();

                ddl.AppendLine($"-- View: {viewName}");
                ddl.AppendLine($"-- Creador: {owner}");
                ddl.AppendLine();

                ddl.AppendLine(viewText.Trim().ToUpper());

                ddl.AppendLine("\n");

                return ddl.ToString();
            }
            catch (Exception ex)
            {
                return $"Error al generar DDL de la vista: {ex.Message}";
            }
        }

        private void LoadViewDDL()
        {
            try
            {
                string ddl = GenerateViewDDL(_connectionName, _viewName);
                rtbDDLView.Text = ddl;
            }
            catch (Exception ex)
            {
                rtbDDLView.Text = $"Error al generar DDL: {ex.Message}";
            }
        }
    }
}
