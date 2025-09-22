namespace Proyecto1_TBD2
{
    partial class CrearView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearView));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GuardarView = new System.Windows.Forms.Button();
            this.txt_NombreView = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_SqlView = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "CREAR VIEW";
            // 
            // btn_GuardarView
            // 
            this.btn_GuardarView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GuardarView.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_GuardarView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarView.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_GuardarView.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarView.Image")));
            this.btn_GuardarView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarView.Location = new System.Drawing.Point(652, 483);
            this.btn_GuardarView.Name = "btn_GuardarView";
            this.btn_GuardarView.Size = new System.Drawing.Size(129, 40);
            this.btn_GuardarView.TabIndex = 10;
            this.btn_GuardarView.Text = "      Guardar";
            this.btn_GuardarView.UseVisualStyleBackColor = false;
            this.btn_GuardarView.Click += new System.EventHandler(this.btn_GuardarView_Click);
            // 
            // txt_NombreView
            // 
            this.txt_NombreView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_NombreView.Location = new System.Drawing.Point(112, 64);
            this.txt_NombreView.Name = "txt_NombreView";
            this.txt_NombreView.Size = new System.Drawing.Size(269, 22);
            this.txt_NombreView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre: ";
            // 
            // rtb_SqlView
            // 
            this.rtb_SqlView.Location = new System.Drawing.Point(27, 136);
            this.rtb_SqlView.Name = "rtb_SqlView";
            this.rtb_SqlView.Size = new System.Drawing.Size(743, 320);
            this.rtb_SqlView.TabIndex = 12;
            this.rtb_SqlView.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Especificar una funcion SELECT:";
            // 
            // CrearView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_SqlView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_GuardarView);
            this.Controls.Add(this.txt_NombreView);
            this.Controls.Add(this.label1);
            this.Name = "CrearView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GuardarView;
        private System.Windows.Forms.TextBox txt_NombreView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_SqlView;
        private System.Windows.Forms.Label label3;
    }
}