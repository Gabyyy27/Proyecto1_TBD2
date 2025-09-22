using Microsoft.Msagl.Drawing;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public partial class ERDiagram : Form
    {
        private string _connectionName;
        private ToolTip toolTip;
        public ERDiagram(string connectionName)
        {
            InitializeComponent();
            _connectionName = connectionName;
           
            SetupForm();
            LoadERDiagram();
        }
        private void SetupForm()
        {
            this.Text = $"Diagrama ER - {_connectionName}";
            this.BackColor = System.Drawing.Color.White; 

            toolTip = new ToolTip();
            toolTip.AutoPopDelay = 15000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            this.Controls.Add(gv_ERD);
        }

        private void LoadERDiagram()
        {
            try
            {
                Graph graph = new Graph("ER Diagram");
                graph.Attr.LayerDirection = LayerDirection.LR;
                graph.Attr.BackgroundColor = Microsoft.Msagl.Drawing.Color.White;

                gv_ERD.Graph = graph;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar diagrama ER: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
