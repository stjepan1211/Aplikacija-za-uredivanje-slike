using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using System.Threading;

namespace Aplikacija_za_uredivanje_slike
{
    public partial class Form1 : Form
    {
        ModulProcessImage modulProcessImage = new ModulProcessImage();
       
        public Form1()
        {
            InitializeComponent();
            SakrijKomponenete();
            
        }
        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulInputOutput.UcitajSliku();

            //ako stisne cancel pri odabiru datoteke, Image ce biti null
            try
            {
                if (imageBox1.Image != null)
                {
                    modulProcessImage.PovijestStanja.EmptyList();
                    DodajSlikuUListu(imageBox1.Image.Bitmap);
                    modulProcessImage.PrvaSlika = imageBox1.Image.Bitmap;
                    PokaziKomponente();
                }

                else
                {
                    modulProcessImage.PovijestStanja.EmptyList();
                    imageBox1.Image = new Image<Bgr, byte>(modulProcessImage.PrvaSlika);
                    DodajSlikuUListu(imageBox1.Image.Bitmap);
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Odaberite sliku i format. Zatim stisnite Open/Otvori.");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            ModulInputOutput.SpremiSliku(new Bitmap(imageBox1.Image.Bitmap));
            DialogResult result = MessageBox.Show("Želite li napustiti program?","Izlaz", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> slika = new Image<Bgr, byte>(imageBox1.Image.Bitmap);
            int visina = slika.Size.Height;
            int sirina = slika.Size.Width;
            imageBox1.SetZoomScale(2, new Point(sirina, visina));
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> slika = new Image<Bgr, byte>(imageBox1.Image.Bitmap);
            int visina = slika.Size.Height;
            int sirina = slika.Size.Width;
            imageBox1.SetZoomScale(0.9d, new Point(sirina, visina));

        }
        private void btnGrayScale_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulProcessImage.GrayScale(imageBox1.Image.Bitmap);
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void btnNegativ_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulProcessImage.Negative(imageBox1.Image.Bitmap);
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void btnRotirajLijevo_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulProcessImage.RotirajBgr(imageBox1.Image.Bitmap, "lijevo");
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void btnRotirajDesno_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulProcessImage.RotirajBgr(imageBox1.Image.Bitmap, "desno");
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void tbSvjetlina_ValueChanged(object sender, EventArgs e)
        {
            //value kroz 5 i +0,1 da ne bude 0 jer ce biti potpuno mracna
            //vrijednost 0 - 10 a za svjetlinu ce trebati 0 - 2
            try
            {
                imageBox1.Image = ModulProcessImage.Svjetlina(new Image<Bgr, byte>(modulProcessImage.Slika), (double)tbSvjetlina.Value / 5 + 0.1);
            }
            catch(AccessViolationException exception)
            {
                MessageBox.Show("Nije moguce tako brzo mijenjati svjetlinu.");
            }
        }
        private void tbKontrast_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                imageBox1.Image = ModulProcessImage.Kontrast(new Image<Bgr, byte>(modulProcessImage.Slika), (double)tbKontrast.Value / 4);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Nije moguce tako brzo mijenjati kontrast.");
            }
        }
        private void tbSvjetlina_Leave(object sender, EventArgs e)
        {
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void tbKontrast_Leave(object sender, EventArgs e)
        {
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void btnPromijeniVelicinu_Click(object sender, EventArgs e)
        {
            int promjeniVisinu;
            int promjeniSirinu;
            bool visinaParsirana = Int32.TryParse(tbPromjeniVisinu.Text, out promjeniVisinu);
            bool sirinaParsirana = Int32.TryParse(tbPromjeniSirinu.Text, out promjeniSirinu);
            Image<Bgr, byte> image = new Image<Bgr, byte>(imageBox1.Image.Bitmap);
            Image<Bgr, byte> resizedImage;
            int visina = image.Size.Height;
            int sirina = image.Size.Width;

            if (visinaParsirana && sirinaParsirana && promjeniVisinu <= 1000 && promjeniVisinu >= 100 && promjeniSirinu <= 1000
                && promjeniSirinu >= 100)
            {
                resizedImage = image.Resize(promjeniSirinu, promjeniVisinu, Inter.Linear);
                imageBox1.Image = resizedImage;
                DodajSlikuUListu(imageBox1.Image.Bitmap);            }
            else if(sirinaParsirana && tbPromjeniVisinu.Text == "" && promjeniSirinu >= 100 && promjeniSirinu <= 1000)
            {
                resizedImage = image.Resize(promjeniSirinu, visina, Inter.Linear);
                imageBox1.Image = resizedImage;
                DodajSlikuUListu(imageBox1.Image.Bitmap);
                
            }
            else
            {
                MessageBox.Show("Potrebno je unjeti cijeli broj između 100 i 1000 za promjenu veličine.");
            }

        }
        private void btnVrati_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox1.Image = new Image<Bgr, byte>(modulProcessImage.PovijestStanja.Pop());
                modulProcessImage.Slika = imageBox1.Image.Bitmap;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Nemoguce se vratiti unazad. (Maksimalno 5 puta ili niste napravili dovoljno koraka.)");
            }
        }
        private void panel1_Leave(object sender, EventArgs e)
        {
            tbPromjeniVisinu.Text = "";
            tbPromjeniSirinu.Text = "";
        }
        private void SakrijKomponenete()
        {
            btnSpremi.Visible = false;
            btnNegativ.Visible = false;
            btnGrayScale.Visible = false;
            btnPromijeniVelicinu.Visible = false;
            btnRotirajDesno.Visible = false;
            btnRotirajLijevo.Visible = false;
            btnVrati.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            tbKontrast.Visible = false;
            tbPromjeniSirinu.Visible = false;
            tbPromjeniVisinu.Visible = false;
            tbSvjetlina.Visible = false;
            label10.Visible = false;
            tbPromjeniSirinu.Visible = false;
            tbPromjeniVisinu.Visible = false;
            btnPromijeniVelicinu.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            btnPromijeniVelicinu.Visible = false;
            btnZoom.Visible = false;
            btnZoomOut.Visible = false;
        }
        private void PokaziKomponente()
        {
            btnSpremi.Visible = true;
            btnNegativ.Visible = true;
            btnGrayScale.Visible = true;
            btnRotirajDesno.Visible = true;
            btnRotirajLijevo.Visible = true;
            btnVrati.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            tbKontrast.Visible = true;
            tbSvjetlina.Visible = true;
            label10.Visible = true;
            tbPromjeniSirinu.Visible = true;
            tbPromjeniVisinu.Visible = true;
            btnPromijeniVelicinu.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            btnPromijeniVelicinu.Visible = true;
            btnZoom.Visible = true;
            btnZoomOut.Visible = true;
        }
        private void DodajSlikuUListu(Bitmap slika)
        {
            modulProcessImage.PovijestStanja.Push(imageBox1.Image.Bitmap);
            modulProcessImage.Slika = imageBox1.Image.Bitmap;
        }
    }
}
