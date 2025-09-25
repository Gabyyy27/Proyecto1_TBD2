using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_TBD2
{
    public partial class Form1 : Form
    {
        private string _connectionName;
        public Form1()
        {
            InitializeComponent();
            LoadSavedConnections();
        }

        private void LoadSavedConnections()
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = treeView1.Nodes.Add("Conexiones Guardadas");

            var savedConnections = ConnectionStorageService.LoadConnections();
            foreach (var conn in savedConnections)
            {
                TreeNode connNode = rootNode.Nodes.Add(conn.Name);
                connNode.Tag = conn;
            }
        }
        private void LoadDatabaseStructure()
        {
            try
            {

                TreeNode connectionNode = new TreeNode(_connectionName);
                treeView1.Nodes.Add(connectionNode);

                connectionNode.Nodes.Add("Tablas", "Tablas");
                connectionNode.Nodes.Add("Vistas", "Vistas");
                connectionNode.Nodes.Add("Procedimientos", "Procedimientos");
                connectionNode.Nodes.Add("Secuencias", "Secuencias");
                connectionNode.Nodes.Add("Triggers", "Triggers");
                connectionNode.Nodes.Add("Índices", "Índices");
                connectionNode.Nodes.Add("Dbspaces", "Dbspaces");
                connectionNode.Nodes.Add("Usuarios", "Usuarios");

                LoadTables(connectionNode.Nodes["Tablas"]);
                LoadView(connectionNode.Nodes["Vistas"]);
                LoadProcedimientos(connectionNode.Nodes["Procedimientos"]);
                LoadSecuencias(connectionNode.Nodes["Secuencias"]);
                LoadTriggers(connectionNode.Nodes["Triggers"]);
                LoadIndices(connectionNode.Nodes["Índices"]);
                LoadDbspaces(connectionNode.Nodes["Dbspaces"]);
               
                LoadUsuarios(connectionNode.Nodes["Usuarios"]);


                connectionNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estructura: {ex.Message}");
            }
        }
        private void LoadTables(TreeNode parentNode)
        {
            try
            {
                DataTable tables = DatabaseService.ExecuteQuery(
                 _connectionName, @"
                  SELECT table_name 
                FROM SYS.SYSTABLE
                WHERE creator = USER_ID(CURRENT USER)
                AND table_type = 'BASE'
                ORDER BY table_name;"
                );

                foreach (DataRow row in tables.Rows)
                {
                    parentNode.Nodes.Add(row["table_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tablas: {ex.Message}");
            }
        }
       
        private void LoadView(TreeNode parentNode)
        {
            try
            {
                DataTable views = DatabaseService.ExecuteQuery(
                 _connectionName, @"
                    SELECT viewname 
                    FROM SYS.SYSVIEWS 
                    WHERE vcreator = CURRENT USER
                    ORDER BY viewname;"
        
                );
                foreach (DataRow row in views.Rows)
                {
                    parentNode.Nodes.Add(row["viewname"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar vistas: {ex.Message}");
            }
        }
         private void LoadProcedimientos(TreeNode parentNode)
         {
             try
             {
                 DataTable procedures = DatabaseService.ExecuteQuery(
                  _connectionName, @"SELECT proc_name
                FROM SYS.SYSPROCEDURE
                WHERE creator = USER_ID(CURRENT USER)
                 ORDER BY proc_name;"
                 );
                 foreach (DataRow row in procedures.Rows)
                 {
                     parentNode.Nodes.Add(row["proc_name"].ToString());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar procedimientos: {ex.Message}");
             }
         }
        
         private void LoadSecuencias(TreeNode parentNode)
         {
             try
             {
                 DataTable sequences = DatabaseService.ExecuteQuery(
                  _connectionName, @"SELECT sequence_name 
                    FROM SYS.SYSSEQUENCE
                    ORDER BY sequence_name;"
                 );
                 foreach (DataRow row in sequences.Rows)
                 {
                     parentNode.Nodes.Add(row["sequence_name"].ToString());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar secuencias: {ex.Message}");
             }
         }
         private void LoadTriggers(TreeNode parentNode)
         {
             try
             {
                 DataTable triggers = DatabaseService.ExecuteQuery(
                  _connectionName, @"
                    SELECT trigger_name
                    FROM SYS.SYSTRIGGER
                    WHERE trigger_name IS NOT NULL
                    ORDER BY trigger_name;"
                 );
                 foreach (DataRow row in triggers.Rows)
                 {
                     parentNode.Nodes.Add(row["trigger_name"].ToString());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar triggers: {ex.Message}");
             }
         }
         private void LoadIndices(TreeNode parentNode)
         {
             try
             {
                 DataTable indices = DatabaseService.ExecuteQuery(
                  _connectionName, @"
                   SELECT index_name
                    FROM SYS.SYSINDEX
                    WHERE table_id IN (
                        SELECT table_id 
                        FROM SYS.SYSTABLE 
                        WHERE creator = USER_ID(CURRENT USER))
                    ORDER BY index_name;"
                 );
                 foreach (DataRow row in indices.Rows)
                 {
                     parentNode.Nodes.Add(row["index_name"].ToString());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar índices: {ex.Message}");
             }
         }
         private void LoadDbspaces(TreeNode parentNode)
         {
             try
             {
                 DataTable Dbspaces = DatabaseService.ExecuteQuery(
                  _connectionName, @"SELECT dbspace_name
                    FROM SYS.SYSDBSPACE
                    ORDER BY dbspace_name;"
                 );
                 foreach (DataRow row in Dbspaces.Rows)
                 {
                     parentNode.Nodes.Add(row["dbspace_name"].ToString());
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al cargar tablespaces: {ex.Message}");
             }
         }
        private void LoadUsuarios(TreeNode parentNode)
        {
            try
            {
                DataTable users = DatabaseService.ExecuteQuery(
                 _connectionName, @"
                   SELECT u.user_name 
                   FROM SYS.SYSUSER u
                    WHERE u.user_name = (SELECT CURRENT USER)
                         ORDER BY u.user_name"
                );
                foreach (DataRow row in users.Rows)
                {
                    parentNode.Nodes.Add(row["user_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }
        private void AbrirFormPanelControl(object Formhijo)
        {
            if (this.PanelControl.Controls.Count > 0)
                this.PanelControl.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelControl.Controls.Add(fh);
            this.PanelControl.Tag = fh;
            fh.Show();
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            ConnectLogin connectLogin = new ConnectLogin();
            connectLogin.Show();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            ConnectLogin loginForm = new ConnectLogin();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string connectionName = loginForm.ConnectionName;
                QueryToolForm queryTool = new QueryToolForm(connectionName);
                queryTool.Show();
            }
            else
            {
                MessageBox.Show("Debe conectarse para usar el Query Tool.");
            }
        }

        private void treeView1_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Parent == null || e.Node.Parent.Parent == null)
                    return;
                string objectType = e.Node.Parent.Text;
                string objectName = e.Node.Text;

                    if (objectType == "Dbspaces" && objectName == "system")
                {
                    string connectionName = e.Node.Parent.Parent.Text;
                    
                    DbspaceForm systemForm = new DbspaceForm(connectionName);
                    AbrirFormPanelControl(systemForm);
                }
                

                if (objectType == "Procedimientos" || objectType == "Triggers"|| objectType == "Secuencias")
                {

                    string connectionName = e.Node.Parent.Parent.Text;

                    DDLSPTForm ddlForm = new DDLSPTForm(connectionName, objectType, objectName);
                    AbrirFormPanelControl(ddlForm);
                }

                if (e.Node.Parent != null && e.Node.Parent.Text == "Tablas")
                {
                    string tableName = e.Node.Text;
                    string connectionName = e.Node.Parent.Parent.Text;

                    TablasP formTabla = new TablasP(connectionName, tableName);
                    AbrirFormPanelControl(formTabla);
                }
                else if (e.Node.Parent.Text == "Vistas")
                {
                    string viewName = e.Node.Text;
                    ViewP vistaForm = new ViewP(_connectionName, viewName);
                    AbrirFormPanelControl(vistaForm);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir: {ex.Message}");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadDatabaseStructure();
            LoadSavedConnections();
        }

        private void btn_AbrirCrearTabla_Click(object sender, EventArgs e)
        {
            CreateTableForm createTableForm = new CreateTableForm(_connectionName);
            createTableForm.ShowDialog();
        }

        private void btn_AbrirView_Click(object sender, EventArgs e)
        {
            CrearView crearViewForm = new CrearView(_connectionName);
            crearViewForm.ShowDialog();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 1 && e.Node.Parent?.Text == "Conexiones Guardadas")
            { 
                if (e.Node.Tag is ConexionesGuardadas conn)
                {
                
                    try
                    {
                        if (_connectionName == conn.Name)
                        {
                            MessageBox.Show($"Ya estás conectado a: {conn.Name}", "Conexión Activa",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; 
                        }

                        DatabaseService.AddConnection(conn.Name, conn.Server, conn.Database, conn.User, conn.Password);

                        _connectionName = conn.Name;
                        LoadDatabaseStructure();

                        MessageBox.Show($"Conectado a: {conn.Name}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al conectar: {ex.Message}");
                    }
                }
            }
        }

        private void pb_ERD_Click(object sender, EventArgs e)
        {
            ERDiagram erDiagramForm = new ERDiagram(_connectionName);
            erDiagramForm.Show();
        }

        private void btn_SincronizarPg_Click(object sender, EventArgs e)
        {
            using (var pgForm = new ReplicationForm())
            {
                if (pgForm.ShowDialog() == DialogResult.OK)
                {
                    var sincronizador = new PgSincronizacion(_connectionName);
                    MessageBox.Show($"Sincronizando {_connectionName} con PostgreSQL...");
                    bool exito = sincronizador.Sincronizar(
                        pgForm.PgHost,
                        pgForm.PgDatabase,
                        pgForm.PgUser,
                        pgForm.PgPassword
                    );

                    if (exito)
                    {
                        MessageBox.Show("Sincronización completada exitosamente");
                    }
                }
            }
        }
    }
}
