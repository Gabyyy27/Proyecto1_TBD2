using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

                LoadTables(graph);
                LoadRelationships(graph);
                gv_ERD.Graph = graph;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar diagrama ER: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTables(Graph graph)
        {
            DataTable tables = DatabaseService.ExecuteQuery(_connectionName,
                $@"SELECT table_name
                FROM SYS.SYSTABLE 
                WHERE table_type = 'BASE' AND creator = USER_ID() 
                ORDER BY table_name");

            foreach (DataRow row in tables.Rows)
            {
                string tableName = row["table_name"].ToString();
                AddTableToGraph(graph, tableName);
            }
        }

        private void AddTableToGraph(Graph graph, string tableName)
        {
            Node node = graph.AddNode(tableName);

            node.Attr.Shape = Shape.Box;
            node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.LightGray;
            node.Attr.LineWidth = 1;
            node.Attr.Color = Microsoft.Msagl.Drawing.Color.DarkGray;

            string columnsInfo = GetColumnsInfo(tableName);
            node.LabelText = $"{tableName}\n{columnsInfo}";
            node.Label.FontSize = 12;

            node.UserData = $"Tabla: {tableName}\n\n Columnas:\n{GetColumnsForTooltip(tableName)}";
        }

        private string GetColumnsInfo(string tableName)
        {
            DataTable columns = DatabaseService.ExecuteQuery(_connectionName,
                $@"SELECT c.column_name,d.domain_name AS data_type, c.width
                     FROM SYS.SYSCOLUMN c
                     LEFT JOIN SYS.SYSDOMAIN d ON c.domain_id = d.domain_id
                     WHERE c.table_id = (SELECT table_id FROM SYS.SYSTABLE 
                     WHERE table_name = '{tableName}')
                     ORDER BY c.column_id");

            string result = " ";
            int count = 0;
            foreach (DataRow colRow in columns.Rows)
            {
                if (count < 80) 
                {
                    result += $"{colRow["column_name"]} - ({colRow["data_type"]})\n";
                }
                count++;
            }

            return result;
        }

        private string GetColumnsForTooltip(string tableName)
        {
            DataTable columns = DatabaseService.ExecuteQuery(_connectionName,
                $@"SELECT c.column_name,d.domain_name AS data_type, c.width, c.scale,
                    CASE WHEN c.nulls = 'N' THEN 'NOT NULL' ELSE 'NULL' 
                    END AS nullable
                    FROM SYS.SYSCOLUMN c
                    LEFT JOIN SYS.SYSDOMAIN d ON c.domain_id = d.domain_id
                    WHERE c.table_id = (SELECT table_id FROM SYS.SYSTABLE 
                    WHERE table_name = '{tableName}')
                    ORDER BY c.column_id");

            string result = "";
            foreach (DataRow colRow in columns.Rows)
            {
                result += $"{colRow["column_name"]} ({colRow["data_type"]}";
                if (!string.IsNullOrEmpty(colRow["width"].ToString()))
                    result += $" [{colRow["width"]}]";
                result += "\n";
            }
            return result;
        }

        private void LoadRelationships(Graph graph)
        {
            DataTable relationships = DatabaseService.ExecuteQuery(_connectionName,
                @"SELECT ft.table_name + '_' + pt.table_name AS fk_name,
                    pt.table_name AS primary_table,
                    ft.table_name AS foreign_table
                    FROM SYS.SYSFOREIGNKEY fk
                    JOIN SYS.SYSTABLE pt ON fk.primary_table_id = pt.table_id
                    JOIN SYS.SYSTABLE ft ON fk.foreign_table_id = ft.table_id
                    WHERE pt.creator = USER_ID() 
                    AND ft.creator = USER_ID()
                    ORDER BY fk_name;");

            foreach (DataRow row in relationships.Rows)
            {
                string fkName = row["fk_name"].ToString();
                string primaryTable = row["primary_table"].ToString();
                string foreignTable = row["foreign_table"].ToString();

                AddRelationship(graph, primaryTable, foreignTable, fkName);
            }
        }

        private void AddRelationship(Graph graph, string primaryTable, string foreignTable, string fkName)
        {
            Edge edge = graph.AddEdge(foreignTable, primaryTable);

            edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            edge.Attr.LineWidth = 2;
            edge.Attr.ArrowheadAtTarget = ArrowStyle.Normal;
            edge.LabelText = fkName;
            edge.Label.FontSize = 8;
        }

        private void gv_ERD_ObjectUnderMouseCursorChanged(object sender, ObjectUnderMouseCursorChangedEventArgs e)
        {
            if (e.NewObject is Microsoft.Msagl.Drawing.Node node && node.UserData != null)
            {
                toolTip.SetToolTip(gv_ERD, node.UserData.ToString());
            }
            else
            {
                toolTip.Hide(gv_ERD);
            }
        }


    }

}
