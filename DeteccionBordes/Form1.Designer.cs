namespace DeteccionBordes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.cannyParametersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applyLaplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applySobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelParametersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edgesToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            // 
            // abrirToolStripMenuItem
            // 
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // edgesToolStripMenuItem
            // 
            resources.ApplyResources(this.edgesToolStripMenuItem, "edgesToolStripMenuItem");
            this.edgesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyParametersToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.sobelParametersToolStripMenuItem,
            this.caniToolStripMenuItem,
            this.menuCannyToolStripMenuItem,
            this.laplacianToolStripMenuItem1,
            this.sobelToolStripMenuItem1});
            this.edgesToolStripMenuItem.Name = "edgesToolStripMenuItem";
            // 
            // cannyParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.cannyParametersToolStripMenuItem, "cannyParametersToolStripMenuItem");
            this.cannyParametersToolStripMenuItem.Name = "cannyParametersToolStripMenuItem";
            this.cannyParametersToolStripMenuItem.Click += new System.EventHandler(this.cannyParametersToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            resources.ApplyResources(this.sobelToolStripMenuItem, "sobelToolStripMenuItem");
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            resources.ApplyResources(this.laplacianToolStripMenuItem, "laplacianToolStripMenuItem");
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // sobelParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.sobelParametersToolStripMenuItem, "sobelParametersToolStripMenuItem");
            this.sobelParametersToolStripMenuItem.Name = "sobelParametersToolStripMenuItem";
            // 
            // caniToolStripMenuItem
            // 
            resources.ApplyResources(this.caniToolStripMenuItem, "caniToolStripMenuItem");
            this.caniToolStripMenuItem.Name = "caniToolStripMenuItem";
            this.caniToolStripMenuItem.Click += new System.EventHandler(this.caniToolStripMenuItem_Click);
            // 
            // menuCannyToolStripMenuItem
            // 
            resources.ApplyResources(this.menuCannyToolStripMenuItem, "menuCannyToolStripMenuItem");
            this.menuCannyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casdfToolStripMenuItem,
            this.cannyParametersToolStripMenuItem1});
            this.menuCannyToolStripMenuItem.Name = "menuCannyToolStripMenuItem";
            // 
            // casdfToolStripMenuItem
            // 
            resources.ApplyResources(this.casdfToolStripMenuItem, "casdfToolStripMenuItem");
            this.casdfToolStripMenuItem.Name = "casdfToolStripMenuItem";
            // 
            // imageBox1
            // 
            resources.ApplyResources(this.imageBox1, "imageBox1");
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.TabStop = false;
            // 
            // cannyParametersToolStripMenuItem1
            // 
            resources.ApplyResources(this.cannyParametersToolStripMenuItem1, "cannyParametersToolStripMenuItem1");
            this.cannyParametersToolStripMenuItem1.Name = "cannyParametersToolStripMenuItem1";
            // 
            // laplacianToolStripMenuItem1
            // 
            resources.ApplyResources(this.laplacianToolStripMenuItem1, "laplacianToolStripMenuItem1");
            this.laplacianToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyLaplacianToolStripMenuItem,
            this.laplacianParametersToolStripMenuItem});
            this.laplacianToolStripMenuItem1.Name = "laplacianToolStripMenuItem1";
            // 
            // applyLaplacianToolStripMenuItem
            // 
            resources.ApplyResources(this.applyLaplacianToolStripMenuItem, "applyLaplacianToolStripMenuItem");
            this.applyLaplacianToolStripMenuItem.Name = "applyLaplacianToolStripMenuItem";
            // 
            // laplacianParametersToolStripMenuItem
            // 
            resources.ApplyResources(this.laplacianParametersToolStripMenuItem, "laplacianParametersToolStripMenuItem");
            this.laplacianParametersToolStripMenuItem.Name = "laplacianParametersToolStripMenuItem";
            // 
            // sobelToolStripMenuItem1
            // 
            resources.ApplyResources(this.sobelToolStripMenuItem1, "sobelToolStripMenuItem1");
            this.sobelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applySobelToolStripMenuItem,
            this.sobelParametersToolStripMenuItem1});
            this.sobelToolStripMenuItem1.Name = "sobelToolStripMenuItem1";
            // 
            // applySobelToolStripMenuItem
            // 
            resources.ApplyResources(this.applySobelToolStripMenuItem, "applySobelToolStripMenuItem");
            this.applySobelToolStripMenuItem.Name = "applySobelToolStripMenuItem";
            // 
            // sobelParametersToolStripMenuItem1
            // 
            resources.ApplyResources(this.sobelParametersToolStripMenuItem1, "sobelParametersToolStripMenuItem1");
            this.sobelParametersToolStripMenuItem1.Name = "sobelParametersToolStripMenuItem1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.ToolStripMenuItem cannyParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyParametersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applyLaplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applySobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelParametersToolStripMenuItem1;
    }
}

