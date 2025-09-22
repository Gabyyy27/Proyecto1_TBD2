namespace Proyecto1_TBD2
{
    partial class ERDiagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERDiagram));
            this.gv_ERD = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.SuspendLayout();
            // 
            // gv_ERD
            // 
            this.gv_ERD.ArrowheadLength = 10D;
            this.gv_ERD.AsyncLayout = false;
            this.gv_ERD.AutoScroll = true;
            this.gv_ERD.BackwardEnabled = false;
            this.gv_ERD.BuildHitTree = true;
            this.gv_ERD.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.MDS;
            this.gv_ERD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_ERD.EdgeInsertButtonVisible = true;
            this.gv_ERD.FileName = "";
            this.gv_ERD.ForwardEnabled = false;
            this.gv_ERD.Graph = null;
            this.gv_ERD.IncrementalDraggingModeAlways = false;
            this.gv_ERD.InsertingEdge = false;
            this.gv_ERD.LayoutAlgorithmSettingsButtonVisible = true;
            this.gv_ERD.LayoutEditingEnabled = true;
            this.gv_ERD.Location = new System.Drawing.Point(0, 0);
            this.gv_ERD.LooseOffsetForRouting = 0.25D;
            this.gv_ERD.MouseHitDistance = 0.05D;
            this.gv_ERD.Name = "gv_ERD";
            this.gv_ERD.NavigationVisible = true;
            this.gv_ERD.NeedToCalculateLayout = true;
            this.gv_ERD.OffsetForRelaxingInRouting = 0.6D;
            this.gv_ERD.PaddingForEdgeRouting = 8D;
            this.gv_ERD.PanButtonPressed = false;
            this.gv_ERD.SaveAsImageEnabled = true;
            this.gv_ERD.SaveAsMsaglEnabled = true;
            this.gv_ERD.SaveButtonVisible = true;
            this.gv_ERD.SaveGraphButtonVisible = true;
            this.gv_ERD.SaveInVectorFormatEnabled = true;
            this.gv_ERD.Size = new System.Drawing.Size(821, 624);
            this.gv_ERD.TabIndex = 0;
            this.gv_ERD.TightOffsetForRouting = 0.125D;
            this.gv_ERD.ToolBarIsVisible = true;
            this.gv_ERD.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gv_ERD.Transform")));
            this.gv_ERD.UndoRedoButtonsVisible = true;
            this.gv_ERD.WindowZoomButtonPressed = false;
            this.gv_ERD.ZoomF = 1D;
            this.gv_ERD.ZoomWindowThreshold = 0.05D;
            this.gv_ERD.ObjectUnderMouseCursorChanged += new System.EventHandler<Microsoft.Msagl.Drawing.ObjectUnderMouseCursorChangedEventArgs>(this.gv_ERD_ObjectUnderMouseCursorChanged);
            // 
            // ERDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 624);
            this.Controls.Add(this.gv_ERD);
            this.Name = "ERDiagram";
            this.Text = "ERDiagram";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer gv_ERD;
    }
}