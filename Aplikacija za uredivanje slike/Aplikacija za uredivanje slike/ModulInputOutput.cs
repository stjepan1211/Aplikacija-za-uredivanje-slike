using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Drawing.Imaging;

namespace Aplikacija_za_uredivanje_slike
{
    class ModulInputOutput
    {        
        public Bitmap Slika { get; set; }
       
        public static Image<Bgr,byte> UcitajSliku()
        {
            //otvaranje dijaloskog okvira za odabiranje slike
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg, *.jpeg)|*.jpg; *.jpeg|BMP Files (*.bmp)|*.bmp";
            fileDialog.Title = "Odaberite sliku za unos. Podržani su .jpg, .png i .bmp formati.";
            //spremanje ucitane slike u objekt Image i vracanje objekta
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> ucitanaSlika = new Image<Bgr, byte>(fileDialog.FileName);
                //ucitanaSlika = ucitanaSlika.Resize(720, 480, Emgu.CV.CvEnum.Inter.Linear);
                return ucitanaSlika;
            }
            else
            return null;
        }
        public static void SpremiSliku(Bitmap slika)
        {
            //otvaranje dijaloskog okvira za spremanje slike
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Bmp|.bmp;";
            fileDialog.Title = "Spremite sliku u .bmp formatu.";
            fileDialog.InitialDirectory = "c:\\";
            //spremanje slike u .bmp formatu
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (slika != null)
                {
                    slika.Save(fileDialog.FileName, ImageFormat.Bmp);
                }
                else
                {
                    MessageBox.Show("Nemoguce spremiti sliku, morate ju prvo ucitati.");
                }
            }
        }
    }
}
