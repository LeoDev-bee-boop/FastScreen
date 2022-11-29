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
        Bitmap bm;
        int index;
        int x, y, sX, sY, cX, cY;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Graphics g;

        public frmPrincipal()
        {
            InitializeComponent();

            bm = new Bitmap(pdCapture.Width, pdCapture.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pdCapture.Image = bm;
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

        private void frmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void pdCapture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;
        }

        private void pdCapture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pdCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                   
                }

            }
            pdCapture.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void SetClipboard()
        {
            Clipboard.SetImage(pdCapture.Image);
        }

        private void desenharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
