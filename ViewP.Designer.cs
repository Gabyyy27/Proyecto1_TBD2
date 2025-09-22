namespace Proyecto1_TBD2
{
    partial class ViewP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewP));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ExportarSql = new System.Windows.Forms.Button();
            this.rtbDDLView = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ExportarSql);
            this.tabPage1.Controls.Add(this.rtbDDLView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ExportarSql
            // 
            this.btn_ExportarSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportarSql.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ExportarSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarSql.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ExportarSql.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportarSql.Image")));
            this.btn_ExportarSql.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportarSql.Location = new System.Drawing.Point(651, 502);
            this.btn_ExportarSql.Name = "btn_ExportarSql";
            this.btn_ExportarSql.Size = new System.Drawing.Size(145, 40);
            this.btn_ExportarSql.TabIndex = 2;
            this.btn_ExportarSql.Text = "       Exportar";
            this.btn_ExportarSql.UseVisualStyleBackColor = false;
            // 
            // rtbDDLView
            // 
            this.rtbDDLView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDDLView.Location = new System.Drawing.Point(3, 3);
            this.rtbDDLView.Name = "rtbDDLView";
            this.rtbDDLView.ReadOnly = true;
            this.rtbDDLView.Size = new System.Drawing.Size(798, 544);
            this.rtbDDLView.TabIndex = 0;
            this.rtbDDLView.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDataView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDataView
            // 
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataView.Location = new System.Drawing.Point(3, 3);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.RowHeadersWidth = 51;
            this.dgvDataView.RowTemplate.Height = 24;
            this.dgvDataView.Size = new System.Drawing.Size(798, 544);
            this.dgvDataView.TabIndex = 0;
            // 
            // ViewP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewP";
            this.Text = "ViewP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.RichTextBox rtbDDLView;
        private System.Windows.Forms.Button btn_ExportarSql;
    }
}