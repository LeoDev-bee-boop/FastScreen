
namespace FastScreen.Forms
{
    partial class Save
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
            this.pdCapture = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pdCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pdCapture
            // 
            this.pdCapture.Location = new System.Drawing.Point(12, 69);
            this.pdCapture.Name = "pdCapture";
            this.pdCapture.Size = new System.Drawing.Size(776, 369);
            this.pdCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pdCapture.TabIndex = 0;
            this.pdCapture.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pdCapture);
            this.Name = "Save";
            this.Text = "Save";
            this.Load += new System.EventHandler(this.Sava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pdCapture;
        private System.Windows.Forms.Button btnSave;
    }
}