using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastScreen.Forms
{
    public partial class frmMessageBox : Form
    {
        public string message;
        public float  precisao;

        public frmMessageBox(string message, float precisao)
        {
            InitializeComponent();

            this.message = message;
            this.precisao = precisao;
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            txtTexto.Text = message;
            txtPrecisao.Text = Convert.ToString(precisao);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
