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
    public partial class TablasP : Form
    {
        private string _connectionName;
        private string _tableName;
        public TablasP(string connectionName, string tableName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            _tableName = tableName;
            this.Text = $"Tabla: {tableName}";
            LoadTableData();
            LoadTableDDL();
        }

        private void LoadTableData()
        {
            try
            {
                // Consulta para obtener datos de la tabla
                string query = $"SELECT * FROM {_tableName}";

                DataTable data = DatabaseService.ExecuteQuery(_connectionName, query);

                // Configurar DataGridView
                dataGridView2.DataSource = data;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AllowUserToResizeColumns = true;
                dataGridView2.AllowUserToResizeRows = true;
                dataGridView2.ReadOnly = true;
                dataGridView2.MultiSelect = false;
                dataGridView2.ColumnHeadersHeight = 30;
                dataGridView2.RowHeadersWidth = 25;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }
        public string GenerateTableDDL(string connectionName, string tableName)
        {
         try
             {
              StringBuilder ddl = new StringBuilder();

        // Obtener información básica de la tabla
        string tableInfoQuery = $@"
        SELECT t.table_name, t.remarks, u.user_name as owner
        FROM SYS.SYSTABLE t
        JOIN SYS.SYSUSER u ON t.creator = u.user_id
        WHERE t.table_name = '{tableName}'
        AND t.creator = USER_ID(CURRENT USER)";

        DataTable tableInfo = DatabaseService.ExecuteQuery(connectionName, tableInfoQuery);
        if (tableInfo.Rows.Count == 0)
            return "Tabla no encontrada";

        string owner = tableInfo.Rows[0]["owner"].ToString();
        string remarks = tableInfo.Rows[0]["remarks"].ToString();

        ddl.AppendLine($"-- Tabla: {tableName}");
        ddl.AppendLine($"-- Creador: {owner}");
        if (!string.IsNullOrEmpty(remarks))
            ddl.AppendLine($"-- Description: {remarks}");
        ddl.AppendLine();

        string columnsQuery = $@"
        SELECT c.column_name, d.domain_name, c.width, c.scale, c.nulls
        FROM SYS.SYSCOLUMN c
        JOIN SYS.SYSDOMAIN d ON c.domain_id = d.domain_id
        WHERE c.table_id = (SELECT table_id FROM SYS.SYSTABLE WHERE table_name = '{tableName}')
        ORDER BY c.column_id";

        DataTable columns = DatabaseService.ExecuteQuery(connectionName, columnsQuery);
        ddl.AppendLine($"CREATE TABLE {tableName} (");

        for (int i = 0; i < columns.Rows.Count; i++)
        {
            DataRow col = columns.Rows[i];
            string columnName = col["column_name"].ToString();
            string dataType = col["domain_name"].ToString(); 
            string width = col["width"].ToString();
            string scale = col["scale"].ToString();
            string nullable = col["nulls"].ToString() == "Y" ? "NULL" : "NOT NULL";

            // Construir tipo de dato
            string fullDataType = dataType;
            if (dataType == "char" || dataType == "varchar")
                fullDataType += $"({width})";
            else if (dataType == "numeric" || dataType == "decimal")
                fullDataType += $"({width},{scale})";

            ddl.Append($"    {columnName} {fullDataType} {nullable}");

            if (i < columns.Rows.Count - 1)
                ddl.AppendLine(",");
            else
                ddl.AppendLine();
        }

        ddl.AppendLine(");");

        return ddl.ToString();
    }
    catch (Exception ex)
    {
        return $"Error al generar DDL: {ex.Message}";
    }
}
        private void LoadTableDDL()
        {
            try
            {
                string ddl = GenerateTableDDL(_connectionName, _tableName);
                rtbDDL.Text = ddl;
            }
            catch (Exception ex)
            {
                rtbDDL.Text = $"Error al generar DDL: {ex.Message}";
            }
        }

        private void btn_ExportarSql_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbDDL.Text.Trim()))
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
                    contenido.AppendLine(rtbDDL.Text);

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
