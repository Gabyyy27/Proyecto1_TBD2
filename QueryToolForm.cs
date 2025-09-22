using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto1_TBD2
{
    public partial class QueryToolForm : Form
    {
        private string _connectionName;
        public QueryToolForm(string connectionName)
        {
            InitializeComponent();
            _connectionName = connectionName;
            this.Text = $"Query Tool - Conectado a: {connectionName}";
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            EjecutarQuery();
        }
        private void EjecutarQuery()
        {
            string query = rtbQuery.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Por favor ingrese una consulta SQL.");
                return;
            }
           
        try
        {
            // Verificar si es una consulta SELECT (que devuelve resultados)
            if (query.ToUpper().StartsWith("SELECT"))
            {
                // Ejecutar SELECT y mostrar resultados en DataGridView
                DataTable results = DatabaseService.ExecuteQuery(_connectionName, query);
                dgvDataOutput.DataSource = results;

                // Mostrar información en la barra de estado o título
                this.Text = $"Query Tool - Conectado a: {_connectionName} | Filas: {results.Rows.Count}";
    }
            else
            {
                // Ejecutar otros comandos (CREATE, INSERT, UPDATE, DELETE, etc.)
                int affectedRows = DatabaseService.ExecuteNonQuery(_connectionName, query);

              dgvDataOutput.DataSource = null;
                
                MessageBox.Show($"Comando ejecutado exitosamente.\n Filas afectadas: {affectedRows}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al ejecutar la consulta:\n{ex.Message}");
        }
    }
    }
}
