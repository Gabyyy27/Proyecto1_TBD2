namespace Proyecto1_TBD2
{
    partial class DDLSPTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDLSPTForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ExportarSql = new System.Windows.Forms.Button();
            this.rtbDDLSPT = new System.Windows.Forms.RichTextBox();
            this.TabControlTablas = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.TabControlTablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_ExportarSql);
            this.tabPage3.Controls.Add(this.rtbDDLSPT);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(813, 595);
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
            this.btn_ExportarSql.Location = new System.Drawing.Point(644, 534);
            this.btn_ExportarSql.Name = "btn_ExportarSql";
            this.btn_ExportarSql.Size = new System.Drawing.Size(145, 40);
            this.btn_ExportarSql.TabIndex = 1;
            this.btn_ExportarSql.Text = "       Exportar";
            this.btn_ExportarSql.UseVisualStyleBackColor = false;
            this.btn_ExportarSql.Click += new System.EventHandler(this.btn_ExportarSql_Click);
            // 
            // rtbDDLSPT
            // 
            this.rtbDDLSPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDDLSPT.Location = new System.Drawing.Point(3, 3);
            this.rtbDDLSPT.Name = "rtbDDLSPT";
            this.rtbDDLSPT.ReadOnly = true;
            this.rtbDDLSPT.Size = new System.Drawing.Size(807, 589);
            this.rtbDDLSPT.TabIndex = 0;
            this.rtbDDLSPT.Text = "";
            // 
            // TabControlTablas
            // 
            this.TabControlTablas.Controls.Add(this.tabPage3);
            this.TabControlTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlTablas.Location = new System.Drawing.Point(0, 0);
            this.TabControlTablas.Name = "TabControlTablas";
            this.TabControlTablas.SelectedIndex = 0;
            this.TabControlTablas.Size = new System.Drawing.Size(821, 624);
            this.TabControlTablas.TabIndex = 1;
            // 
            // DDLSPTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 624);
            this.ControlBox = false;
            this.Controls.Add(this.TabControlTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DDLSPTForm";
            this.Text = "StoreProcedureForm";
            this.tabPage3.ResumeLayout(false);
            this.TabControlTablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_ExportarSql;
        private System.Windows.Forms.RichTextBox rtbDDLSPT;
        private System.Windows.Forms.TabControl TabControlTablas;
    }
}