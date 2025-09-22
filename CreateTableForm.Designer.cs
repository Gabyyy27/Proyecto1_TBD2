namespace Proyecto1_TBD2
{
    partial class CreateTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTableForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombreTabla = new System.Windows.Forms.TextBox();
            this.btn_GuardarTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txt_NombreTabla
            // 
            this.txt_NombreTabla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_NombreTabla.Location = new System.Drawing.Point(158, 129);
            this.txt_NombreTabla.Name = "txt_NombreTabla";
            this.txt_NombreTabla.Size = new System.Drawing.Size(269, 22);
            this.txt_NombreTabla.TabIndex = 1;
            // 
            // btn_GuardarTable
            // 
            this.btn_GuardarTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarTable.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_GuardarTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_GuardarTable.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTable.Image")));
            this.btn_GuardarTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarTable.Location = new System.Drawing.Point(375, 216);
            this.btn_GuardarTable.Name = "btn_GuardarTable";
            this.btn_GuardarTable.Size = new System.Drawing.Size(129, 40);
            this.btn_GuardarTable.TabIndex = 6;
            this.btn_GuardarTable.Text = "      Guardar";
            this.btn_GuardarTable.UseVisualStyleBackColor = false;
            this.btn_GuardarTable.Click += new System.EventHandler(this.btn_GuardarTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "CREAR TABLA";
            // 
            // CreateTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(525, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GuardarTable);
            this.Controls.Add(this.txt_NombreTabla);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CreateTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tabla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreTabla;
        private System.Windows.Forms.Button btn_GuardarTable;
        private System.Windows.Forms.Label label2;
    }
}