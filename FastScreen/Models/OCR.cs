using FastScreen.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace FastScreen.Models
{
    public class OCR
    {
        public void AnalisaImagem(byte[] image)
        {
            try
            {
                using (var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromMemory(image))
                    {
                        using (var page = engine.Process(img))
                        {
                            var texto = page.GetText();
                            var precisao = page.GetMeanConfidence();

                            frmMessageBox frmMessage = new frmMessageBox(texto, precisao);
                            frmMessage.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
