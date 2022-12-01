
namespace FastScreen.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retânguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdCapture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Image = global::FastScreen.Properties.Resources.menu_aberto;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.oCRToolStripMenuItem,
            this.desenharToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.elipseToolStripMenuItem,
            this.retânguloToolStripMenuItem,
            this.linhaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ferramentasToolStripMenuItem.Image = global::FastScreen.Properties.Resources.toolbox;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.printToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printToolStripMenuItem.Image = global::FastScreen.Properties.Resources.camera;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // oCRToolStripMenuItem
            // 
            this.oCRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.oCRToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.oCRToolStripMenuItem.Image = global::FastScreen.Properties.Resources.ocr;
            this.oCRToolStripMenuItem.Name = "oCRToolStripMenuItem";
            this.oCRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oCRToolStripMenuItem.Text = "OCR";
            this.oCRToolStripMenuItem.Click += new System.EventHandler(this.oCRToolStripMenuItem_Click);
            // 
            // desenharToolStripMenuItem
            // 
            this.desenharToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.desenharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.desenharToolStripMenuItem.Image = global::FastScreen.Properties.Resources.pen_2;
            this.desenharToolStripMenuItem.Name = "desenharToolStripMenuItem";
            this.desenharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desenharToolStripMenuItem.Text = "Desenhar";
            this.desenharToolStripMenuItem.Click += new System.EventHandler(this.desenharToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.apagarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.apagarToolStripMenuItem.Image = global::FastScreen.Properties.Resources.eraser;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.elipseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.elipseToolStripMenuItem.Image = global::FastScreen.Properties.Resources.oval;
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // retânguloToolStripMenuItem
            // 
            this.retânguloToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.retânguloToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.retânguloToolStripMenuItem.Image = global::FastScreen.Properties.Resources.rectangle;
            this.retânguloToolStripMenuItem.Name = "retânguloToolStripMenuItem";
            this.retânguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retânguloToolStripMenuItem.Text = "Retângulo";
            this.retânguloToolStripMenuItem.Click += new System.EventHandler(this.retânguloToolStripMenuItem_Click);
            // 
            // linhaToolStripMenuItem
            // 
            this.linhaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.linhaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.linhaToolStripMenuItem.Image = global::FastScreen.Properties.Resources.diagonal_line;
            this.linhaToolStripMenuItem.Name = "linhaToolStripMenuItem";
            this.linhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linhaToolStripMenuItem.Text = "Linha";
            this.linhaToolStripMenuItem.Click += new System.EventHandler(this.linhaToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.salvarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salvarToolStripMenuItem.Image = global::FastScreen.Properties.Resources.diskette2;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // pdCapture
            // 
            this.pdCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdCapture.Location = new System.Drawing.Point(0, 27);
            this.pdCapture.Name = "pdCapture";
            this.pdCapture.Size = new System.Drawing.Size(776, 332);
            this.pdCapture.TabIndex = 0;
            this.pdCapture.TabStop = false;
            this.pdCapture.Paint += new System.Windows.Forms.PaintEventHandler(this.pdCapture_Paint);
            this.pdCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pdCapture_MouseDown);
            this.pdCapture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pdCapture_MouseMove);
            this.pdCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pdCapture_MouseUp);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.pdCapture);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pdCapture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retânguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhaToolStripMenuItem;
    }
}