namespace Proyecto1_TBD2
{
    partial class QueryToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryToolForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SCQuery = new System.Windows.Forms.SplitContainer();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDataOutput = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ejecutar = new System.Windows.Forms.ToolStripButton();
            this.TC_btnQuery = new System.Windows.Forms.TabControl();
            this.PPQuery = new System.Windows.Forms.Panel();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SCQuery)).BeginInit();
            this.SCQuery.Panel1.SuspendLayout();
            this.SCQuery.Panel2.SuspendLayout();
            this.SCQuery.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOutput)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.TC_btnQuery.SuspendLayout();
            this.PPQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(989, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SCQuery);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 630);
            this.panel1.TabIndex = 0;
            // 
            // SCQuery
            // 
            this.SCQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SCQuery.Location = new System.Drawing.Point(0, 31);
            this.SCQuery.Name = "SCQuery";
            this.SCQuery.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCQuery.Panel1
            // 
            this.SCQuery.Panel1.Controls.Add(this.rtbQuery);
            this.SCQuery.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // SCQuery.Panel2
            // 
            this.SCQuery.Panel2.Controls.Add(this.tabControl2);
            this.SCQuery.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SCQuery.Size = new System.Drawing.Size(983, 599);
            this.SCQuery.SplitterDistance = 341;
            this.SCQuery.TabIndex = 4;
            // 
            // rtbQuery
            // 
            this.rtbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQuery.Location = new System.Drawing.Point(0, 0);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbQuery.Size = new System.Drawing.Size(983, 341);
            this.rtbQuery.TabIndex = 2;
            this.rtbQuery.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(983, 254);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDataOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 216);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Data Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDataOutput
            // 
            this.dgvDataOutput.AllowUserToAddRows = false;
            this.dgvDataOutput.AllowUserToDeleteRows = false;
            this.dgvDataOutput.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataOutput.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDataOutput.Location = new System.Drawing.Point(3, 3);
            this.dgvDataOutput.MultiSelect = false;
            this.dgvDataOutput.Name = "dgvDataOutput";
            this.dgvDataOutput.ReadOnly = true;
            this.dgvDataOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDataOutput.RowHeadersWidth = 51;
            this.dgvDataOutput.RowTemplate.Height = 24;
            this.dgvDataOutput.Size = new System.Drawing.Size(969, 210);
            this.dgvDataOutput.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ejecutar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(983, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Barra Herramientas";
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ejecutar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ejecutar.Image")));
            this.btn_ejecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(29, 28);
            this.btn_ejecutar.Text = "Ejecutar";
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click);
            // 
            // TC_btnQuery
            // 
            this.TC_btnQuery.Controls.Add(this.tabPage1);
            this.TC_btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_btnQuery.Location = new System.Drawing.Point(0, 0);
            this.TC_btnQuery.Name = "TC_btnQuery";
            this.TC_btnQuery.SelectedIndex = 0;
            this.TC_btnQuery.Size = new System.Drawing.Size(997, 665);
            this.TC_btnQuery.TabIndex = 0;
            // 
            // PPQuery
            // 
            this.PPQuery.BackColor = System.Drawing.SystemColors.Window;
            this.PPQuery.Controls.Add(this.TC_btnQuery);
            this.PPQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PPQuery.Location = new System.Drawing.Point(0, 0);
            this.PPQuery.Name = "PPQuery";
            this.PPQuery.Size = new System.Drawing.Size(997, 665);
            this.PPQuery.TabIndex = 1;
            // 
            // QueryToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 665);
            this.Controls.Add(this.PPQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QueryToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Tool";
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SCQuery.Panel1.ResumeLayout(false);
            this.SCQuery.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCQuery)).EndInit();
            this.SCQuery.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOutput)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TC_btnQuery.ResumeLayout(false);
            this.PPQuery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TC_btnQuery;
        private System.Windows.Forms.Panel PPQuery;
        private System.Windows.Forms.DataGridView dgvDataOutput;
        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ejecutar;
        private System.Windows.Forms.SplitContainer SCQuery;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}