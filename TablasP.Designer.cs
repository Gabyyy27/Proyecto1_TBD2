namespace Proyecto1_TBD2
{
    partial class TablasP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablasP));
            this.TabControlTablas = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ExportarSql = new System.Windows.Forms.Button();
            this.rtbDDL = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabControlTablas.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlTablas
            // 
            this.TabControlTablas.Controls.Add(this.tabPage3);
            this.TabControlTablas.Controls.Add(this.tabPage2);
            this.TabControlTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlTablas.Location = new System.Drawing.Point(0, 0);
            this.TabControlTablas.Name = "TabControlTablas";
            this.TabControlTablas.SelectedIndex = 0;
            this.TabControlTablas.Size = new System.Drawing.Size(839, 671);
            this.TabControlTablas.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_ExportarSql);
            this.tabPage3.Controls.Add(this.rtbDDL);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(831, 642);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ExportarSql
            // 
            this.btn_ExportarSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportarSql.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ExportarSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarSql.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ExportarSql.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportarSql.Image")));
            this.btn_ExportarSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportarSql.Location = new System.Drawing.Point(662, 581);
            this.btn_ExportarSql.Name = "btn_ExportarSql";
            this.btn_ExportarSql.Size = new System.Drawing.Size(145, 40);
            this.btn_ExportarSql.TabIndex = 1;
            this.btn_ExportarSql.Text = "       Exportar";
            this.btn_ExportarSql.UseVisualStyleBackColor = false;
            this.btn_ExportarSql.Click += new System.EventHandler(this.btn_ExportarSql_Click);
            // 
            // rtbDDL
            // 
            this.rtbDDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDDL.Location = new System.Drawing.Point(3, 3);
            this.rtbDDL.Name = "rtbDDL";
            this.rtbDDL.ReadOnly = true;
            this.rtbDDL.Size = new System.Drawing.Size(825, 636);
            this.rtbDDL.TabIndex = 0;
            this.rtbDDL.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 642);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView2.Size = new System.Drawing.Size(825, 636);
            this.dataGridView2.TabIndex = 0;
            // 
            // TablasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 671);
            this.Controls.Add(this.TabControlTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TablasP";
            this.TabControlTablas.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlTablas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbDDL;
        private System.Windows.Forms.Button btn_ExportarSql;
    }
}