using FastScreen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastScreen.Forms
{
    public partial class frmPrincipal : Form
    {
        Bitmap bmp;

        public frmPrincipal()
        {
            InitializeComponent();

            
        }

        private void Sava_Load(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaRecortada area = new AreaRecortada();

            using (frmSelectArea frmSelectArea = new frmSelectArea())
                if (frmSelectArea.ShowDialog() == DialogResult.OK)
                    area = frmSelectArea.retornaAreaSelecionada();

            Rectangle rect = new Rectangle(area.x, area.y, area.w, area.h);
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, area.s, CopyPixelOperation.SourceCopy);
            pdCapture.Image = bmp;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void oCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instânciando classe
            OCR ocr = new OCR();

            //Instânciando propriedade
            byte[] imgByte;

            //Convertendo Image para byte
            imgByte = ImageToByteArray(pdCapture.Image);

            ocr.AnalisaImagem(imgByte);
        }

        public byte[] ImageToByteArray(Image imagem)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                imagem.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                return mStream.ToArray();
            }
        }
    }
}
