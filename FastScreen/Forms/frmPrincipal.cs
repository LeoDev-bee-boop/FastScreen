using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastScreen.Forms
{
    public partial class frmPrincipal : Form
    {
        Bitmap bmp;

        public frmPrincipal(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();

            Rectangle rect = new Rectangle(x, y, w, h);
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            pdCapture.Image = bmp;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Sava_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.FileName = "Capture";
            sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pdCapture.Image.Save(sfd.FileName);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectArea area = new frmSelectArea();
            area.Show();
        }
    }
}
