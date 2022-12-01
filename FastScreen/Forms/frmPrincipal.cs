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

        #region ..:: Propriedades ::..
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        ColorDialog cd = new ColorDialog();

        Bitmap bmp;
        Graphics g;
        
        Point px, py;

        int index;
        int x, y, sX, sY, cX, cY;
        bool paint = false;
        #endregion ..:: Propriedades ::..

        #region ..:: Construtor ::..
        public frmPrincipal()
        {
            InitializeComponent();
            //bm = new Bitmap(pdCapture.Width, pdCapture.Height);
            //g = Graphics.FromImage(bm);
            //g.Clear(Color.White);
            //pdCapture.Image = bm;
        }
        #endregion ..:: Construtor ::..

        #region ..:: Eventos ::..
        //------------------------------------------------------------->
        private void desenharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        //------------------------------------------------------------->
        private void oCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturaOCR();
        }
        //------------------------------------------------------------->
        private void pdCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    //Desenhado linha
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    //Desenhado Borracha
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pdCapture.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        //------------------------------------------------------------->
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetClipboard();
        }
        //------------------------------------------------------------->
        private void linhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        //------------------------------------------------------------->
        private void retânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        //------------------------------------------------------------->
        private void pdCapture_Paint(object sender, PaintEventArgs e)
        {
            Graphics a = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    a.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    a.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    a.DrawLine(p, cX, cY, x, y);
                }
            }
        }
        //------------------------------------------------------------->
        private void pdCapture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }
        //------------------------------------------------------------->
        private void pdCapture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }
        //------------------------------------------------------------->
        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        //------------------------------------------------------------->
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void coresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlteraCor();
        }
        //------------------------------------------------------------->
        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpaPictureBox();
        }
        //------------------------------------------------------------->
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
        //------------------------------------------------------------->
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapturaPrint();
        }
        //------------------------------------------------------------->
        #endregion ..:: Eventos ::..

        #region ..:: Métodos Auxiliares ::..
        //------------------------------------------------------------->
        private void CapturaPrint()
        {
            //Escondendo Form
            this.Hide();

            //Classe responsável as cordenadas da área de print
            AreaRecortada area = new AreaRecortada();

            //Chamando form que passara as coordenadas dos pixel da tela de print
            using (frmSelectArea frmSelectArea = new frmSelectArea())
                if (frmSelectArea.ShowDialog() == DialogResult.OK)
                    area = frmSelectArea.retornaAreaSelecionada();

            //Passando extremidades da área da print para um retângulo            
            Rectangle rect = new Rectangle(area.x, area.y, area.w, area.h);
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.Left, rect.Top, 0, 0, area.s, CopyPixelOperation.SourceCopy);
            pdCapture.Image = bmp;

            //Instância da classe gráfica recebendo imagem do picture box
            g = Graphics.FromImage(pdCapture.Image);

            //Exibindo form
            this.Show();
        }
        //------------------------------------------------------------->
        private void CapturaOCR()
        {
            //Instânciando classe
            OCR ocr = new OCR();

            //Instânciando propriedade
            byte[] imgByte;

            //Convertendo Image para byte
            imgByte = ImageToByteArray(pdCapture.Image);

            //Método de análise de imagem
            ocr.AnalisaImagem(imgByte);
        }
        //------------------------------------------------------------->
        private void SetClipboard()
        {
            Clipboard.SetImage(pdCapture.Image);
        }
        //------------------------------------------------------------->
        public byte[] ImageToByteArray(Image imagem)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                imagem.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                return mStream.ToArray();
            }
        }
        //------------------------------------------------------------->
        private void AlteraCor()
        {
            cd.ShowDialog();
            p.Color = cd.Color;
            coresToolStripMenuItem.ForeColor = cd.Color;
        }
        //------------------------------------------------------------->
        private void LimpaPictureBox()
        {
            pdCapture.Image = null;

        }
        #endregion ..:: Métodos Auxiliares ::..


    }
}
