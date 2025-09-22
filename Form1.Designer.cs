namespace Proyecto1_TBD2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tablas", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Vistas");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Procedimientos Almacenados");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Funciones");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Secuencias");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tiggers");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Indices");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tablespace");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Usuarios");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Producción", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tablas", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Vistas");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Procedimientos Almacenados");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Funciones");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Secuencias");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Tiggers");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Indices");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tablespace");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Usuarios");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Banco", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Conexiones", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode22});
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SincronizarPg = new System.Windows.Forms.PictureBox();
            this.pb_ERD = new System.Windows.Forms.PictureBox();
            this.btn_AbrirView = new System.Windows.Forms.PictureBox();
            this.btn_AbrirCrearTabla = new System.Windows.Forms.PictureBox();
            this.btn_reload = new System.Windows.Forms.PictureBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SincronizarPg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ERD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AbrirView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AbrirCrearTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btn_SincronizarPg);
            this.panel1.Controls.Add(this.pb_ERD);
            this.panel1.Controls.Add(this.btn_AbrirView);
            this.panel1.Controls.Add(this.btn_AbrirCrearTabla);
            this.panel1.Controls.Add(this.btn_reload);
            this.panel1.Controls.Add(this.btn_Query);
            this.panel1.Controls.Add(this.btn_Conectar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 69);
            this.panel1.TabIndex = 0;
            // 
            // btn_SincronizarPg
            // 
            this.btn_SincronizarPg.Image = ((System.Drawing.Image)(resources.GetObject("btn_SincronizarPg.Image")));
            this.btn_SincronizarPg.Location = new System.Drawing.Point(641, 6);
            this.btn_SincronizarPg.Name = "btn_SincronizarPg";
            this.btn_SincronizarPg.Size = new System.Drawing.Size(48, 48);
            this.btn_SincronizarPg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_SincronizarPg.TabIndex = 6;
            this.btn_SincronizarPg.TabStop = false;
            this.btn_SincronizarPg.Click += new System.EventHandler(this.btn_SincronizarPg_Click);
            // 
            // pb_ERD
            // 
            this.pb_ERD.Image = ((System.Drawing.Image)(resources.GetObject("pb_ERD.Image")));
            this.pb_ERD.Location = new System.Drawing.Point(579, 7);
            this.pb_ERD.Name = "pb_ERD";
            this.pb_ERD.Size = new System.Drawing.Size(45, 45);
            this.pb_ERD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ERD.TabIndex = 5;
            this.pb_ERD.TabStop = false;
            this.pb_ERD.Click += new System.EventHandler(this.pb_ERD_Click);
            // 
            // btn_AbrirView
            // 
            this.btn_AbrirView.Image = ((System.Drawing.Image)(resources.GetObject("btn_AbrirView.Image")));
            this.btn_AbrirView.Location = new System.Drawing.Point(515, 8);
            this.btn_AbrirView.Name = "btn_AbrirView";
            this.btn_AbrirView.Size = new System.Drawing.Size(40, 40);
            this.btn_AbrirView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_AbrirView.TabIndex = 4;
            this.btn_AbrirView.TabStop = false;
            this.btn_AbrirView.Click += new System.EventHandler(this.btn_AbrirView_Click);
            // 
            // btn_AbrirCrearTabla
            // 
            this.btn_AbrirCrearTabla.Image = ((System.Drawing.Image)(resources.GetObject("btn_AbrirCrearTabla.Image")));
            this.btn_AbrirCrearTabla.Location = new System.Drawing.Point(451, 3);
            this.btn_AbrirCrearTabla.Name = "btn_AbrirCrearTabla";
            this.btn_AbrirCrearTabla.Size = new System.Drawing.Size(48, 48);
            this.btn_AbrirCrearTabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_AbrirCrearTabla.TabIndex = 3;
            this.btn_AbrirCrearTabla.TabStop = false;
            this.btn_AbrirCrearTabla.Click += new System.EventHandler(this.btn_AbrirCrearTabla_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.Location = new System.Drawing.Point(384, 4);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(48, 48);
            this.btn_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_reload.TabIndex = 2;
            this.btn_reload.TabStop = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Query.Image = ((System.Drawing.Image)(resources.GetObject("btn_Query.Image")));
            this.btn_Query.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Query.Location = new System.Drawing.Point(201, 12);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(158, 40);
            this.btn_Query.TabIndex = 1;
            this.btn_Query.Text = "           Query Tool";
            this.btn_Query.UseVisualStyleBackColor = false;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.Green;
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Conectar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Conectar.Image")));
            this.btn_Conectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Conectar.Location = new System.Drawing.Point(23, 12);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(145, 40);
            this.btn_Conectar.TabIndex = 0;
            this.btn_Conectar.Text = "           Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelControl);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 671);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Indent = 19;
            this.treeView1.ItemHeight = 35;
            this.treeView1.LineColor = System.Drawing.Color.Red;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo9";
            treeNode1.Text = "Productos";
            treeNode2.Name = "tables";
            treeNode2.Text = "Tablas";
            treeNode3.Name = "view";
            treeNode3.Text = "Vistas";
            treeNode4.Name = "StoreProcedure";
            treeNode4.Text = "Procedimientos Almacenados";
            treeNode5.Name = "Nodo6";
            treeNode5.Text = "Funciones";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "Secuencias";
            treeNode7.Name = "Nodo8";
            treeNode7.Text = "Tiggers";
            treeNode8.Name = "Nodo9";
            treeNode8.Text = "Indices";
            treeNode9.Name = "Nodo12";
            treeNode9.Text = "Tablespace";
            treeNode10.Name = "Nodo13";
            treeNode10.Text = "Usuarios";
            treeNode11.ImageIndex = -2;
            treeNode11.Name = "ejemplo";
            treeNode11.Text = "Producción";
            treeNode12.Name = "Nodo10";
            treeNode12.Text = "Clientes";
            treeNode13.Name = "Nodo0";
            treeNode13.Text = "Tablas";
            treeNode14.Name = "Nodo1";
            treeNode14.Text = "Vistas";
            treeNode15.Name = "Nodo2";
            treeNode15.Text = "Procedimientos Almacenados";
            treeNode16.Name = "Nodo3";
            treeNode16.Text = "Funciones";
            treeNode17.Name = "Nodo4";
            treeNode17.Text = "Secuencias";
            treeNode18.Name = "Nodo5";
            treeNode18.Text = "Tiggers";
            treeNode19.Name = "Nodo6";
            treeNode19.Text = "Indices";
            treeNode20.Name = "Nodo7";
            treeNode20.Text = "Tablespace";
            treeNode21.Name = "Nodo8";
            treeNode21.Text = "Usuarios";
            treeNode22.Name = "Nodo14";
            treeNode22.Text = "Banco";
            treeNode23.Name = "Conexiones";
            treeNode23.NodeFont = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode23.Text = "Conexiones";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.treeView1.Size = new System.Drawing.Size(421, 671);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick_1);
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.SystemColors.Window;
            this.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl.Location = new System.Drawing.Point(0, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(839, 671);
            this.PanelControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 740);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manager Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SincronizarPg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ERD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AbrirView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AbrirCrearTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reload)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.PictureBox btn_reload;
        private System.Windows.Forms.PictureBox btn_AbrirCrearTabla;
        private System.Windows.Forms.PictureBox btn_AbrirView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pb_ERD;
        private System.Windows.Forms.PictureBox btn_SincronizarPg;
    }
}

