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

namespace Aplikacija_za_uredivanje_slike
{
    public partial class Form1 : Form
    {
        ModulProcessImage modulProcessImage = new ModulProcessImage();
        public Form1()
        {
            InitializeComponent();
            //SakrijKomponenete();
        }
        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            imageBox1.Image = ModulInputOutput.UcitajSliku();
            PokaziKomponente();
            //ako stisne cancel pri odabiru datoteke, Image ce biti null
            try
            {
                DodajSlikuUListu(imageBox1.Image.Bitmap);
            }
            catch (NullReferenceException exception)
            {

            }
            if(imageBox1.Image == null)
            {
                SakrijKomponenete();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            ModulInputOutput.SpremiSliku(new Bitmap(imageBox1.Image.Bitmap));
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
            //value/5
            //vrijednost 0 - 10 a za svjetlinu ce trebati 0 - 2
            imageBox1.Image = ModulProcessImage.Svjetlina(modulProcessImage.PovijestStanja.Last(), (double) tbSvjetlina.Value/5);
            DodajSlikuUListu(imageBox1.Image.Bitmap);
        }
        private void btnPromijeniVelicinu_Click(object sender, EventArgs e)
        {

        }
        private void btnVrati_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox1.Image = new Image<Bgr, byte>(modulProcessImage.PovijestStanja.Pop());
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Nemoguce se vratiti korak unazad.(max 5 puta)");
            }

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
            btnIzrezi.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            tbKontrast.Visible = false;
            lblVelicinaSlike.Visible = false;
            tbPovecajSirinu.Visible = false;
            tbPovecajVisinu.Visible = false;
            tbSmanjiSirinu.Visible = false;
            tbSmanjiVisinu.Visible = false;
            tbSvjetlina.Visible = false;
        }
        private void PokaziKomponente()
        {
            btnSpremi.Visible = true;
            btnNegativ.Visible = true;
            btnGrayScale.Visible = true;
            btnPromijeniVelicinu.Visible = true;
            btnRotirajDesno.Visible = true;
            btnRotirajLijevo.Visible = true;
            btnVrati.Visible = true;
            btnIzrezi.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            tbKontrast.Visible = true;
            lblVelicinaSlike.Visible = true;
            tbPovecajSirinu.Visible = true;
            tbPovecajVisinu.Visible = true;
            tbSmanjiSirinu.Visible = true;
            tbSmanjiVisinu.Visible = true;
            tbSvjetlina.Visible = true;
        }
        private void DodajSlikuUListu(Bitmap slika)
        {
            modulProcessImage.PovijestStanja.Push(imageBox1.Image.Bitmap);
        }
    }
}
