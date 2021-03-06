﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Aplikacija_za_uredivanje_slike
{
    class ModulProcessImage
    {
        public Bitmap Slika { get; set; }
        public Bitmap PrvaSlika { get; set; }
        public PovijestStanja<Bitmap> PovijestStanja { get; set; }
        public ModulProcessImage()
        {
            this.PovijestStanja = new PovijestStanja<Bitmap>();
        }
        public static Image<Gray,byte> GrayScale(Bitmap slika)
        {
            Image<Bgr, byte> imageBgr = new Image<Bgr, byte>(slika);
            Image<Gray, Byte> imageGray = imageBgr.Convert<Gray, Byte>();
            return imageGray;
        }
        public static Image<Bgr,byte> Negative(Bitmap slika)
        {
            Image<Bgr, byte> imageBgr = new Image<Bgr, byte>(slika);
            Image<Bgr, byte> imageNegative = imageBgr.Not();
            return imageNegative;
        }
        public static Image<Bgr,byte> RotirajBgr(Bitmap slika, string orijentacija)
        {
            Image<Bgr, byte> imageBgr = new Image<Bgr, byte>(slika);
            switch (orijentacija)
            {
                case "lijevo":
                    imageBgr = imageBgr.Rotate(-90, new Bgr(0, 0, 0), false);
                    return imageBgr;
                case "desno":
                    imageBgr = imageBgr.Rotate(90, new Bgr(0, 0, 0), false);
                    return imageBgr;
                default:
                    return imageBgr;
            }  
        }
        public static Image<Bgr, byte> Svjetlina(Image<Bgr, byte> image, double intezitet)
        {
            return image.Mul(intezitet);
        }
        public static Image<Bgr,byte> Kontrast(Image<Bgr, byte> image, double intezitet)
        {
            image._EqualizeHist();
            image._GammaCorrect(intezitet);
            return image;
        }
    }
}
