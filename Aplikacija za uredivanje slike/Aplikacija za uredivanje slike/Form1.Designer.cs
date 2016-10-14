namespace Aplikacija_za_uredivanje_slike
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnGrayScale = new System.Windows.Forms.Button();
            this.btnNegativ = new System.Windows.Forms.Button();
            this.btnRotirajLijevo = new System.Windows.Forms.Button();
            this.btnRotirajDesno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSvjetlina = new System.Windows.Forms.TrackBar();
            this.tbKontrast = new System.Windows.Forms.TrackBar();
            this.lblVelicinaSlike = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPovecajVisinu = new System.Windows.Forms.TextBox();
            this.tbSmanjiVisinu = new System.Windows.Forms.TextBox();
            this.tbPovecajSirinu = new System.Windows.Forms.TextBox();
            this.tbSmanjiSirinu = new System.Windows.Forms.TextBox();
            this.btnPromijeniVelicinu = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnIzrezi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSvjetlina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKontrast)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.BackColor = System.Drawing.SystemColors.Control;
            this.btnUcitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitaj.Location = new System.Drawing.Point(15, 21);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(105, 30);
            this.btnUcitaj.TabIndex = 3;
            this.btnUcitaj.Text = "Učitaj sliku";
            this.btnUcitaj.UseVisualStyleBackColor = false;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imageBox1.Location = new System.Drawing.Point(185, 21);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(600, 600);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(12, 480);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(120, 40);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi sliku";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnGrayScale
            // 
            this.btnGrayScale.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrayScale.Location = new System.Drawing.Point(14, 83);
            this.btnGrayScale.Name = "btnGrayScale";
            this.btnGrayScale.Size = new System.Drawing.Size(120, 25);
            this.btnGrayScale.TabIndex = 6;
            this.btnGrayScale.Text = "GrayScale";
            this.btnGrayScale.UseVisualStyleBackColor = false;
            this.btnGrayScale.Click += new System.EventHandler(this.btnGrayScale_Click);
            // 
            // btnNegativ
            // 
            this.btnNegativ.BackColor = System.Drawing.SystemColors.Control;
            this.btnNegativ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativ.Location = new System.Drawing.Point(12, 114);
            this.btnNegativ.Name = "btnNegativ";
            this.btnNegativ.Size = new System.Drawing.Size(120, 25);
            this.btnNegativ.TabIndex = 7;
            this.btnNegativ.Text = "Negativ";
            this.btnNegativ.UseVisualStyleBackColor = false;
            this.btnNegativ.Click += new System.EventHandler(this.btnNegativ_Click);
            // 
            // btnRotirajLijevo
            // 
            this.btnRotirajLijevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnRotirajLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotirajLijevo.Location = new System.Drawing.Point(12, 162);
            this.btnRotirajLijevo.Name = "btnRotirajLijevo";
            this.btnRotirajLijevo.Size = new System.Drawing.Size(59, 30);
            this.btnRotirajLijevo.TabIndex = 8;
            this.btnRotirajLijevo.Text = "Lijevo";
            this.btnRotirajLijevo.UseVisualStyleBackColor = false;
            this.btnRotirajLijevo.Click += new System.EventHandler(this.btnRotirajLijevo_Click);
            // 
            // btnRotirajDesno
            // 
            this.btnRotirajDesno.BackColor = System.Drawing.SystemColors.Control;
            this.btnRotirajDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotirajDesno.Location = new System.Drawing.Point(69, 162);
            this.btnRotirajDesno.Name = "btnRotirajDesno";
            this.btnRotirajDesno.Size = new System.Drawing.Size(61, 30);
            this.btnRotirajDesno.TabIndex = 9;
            this.btnRotirajDesno.Text = "Desno";
            this.btnRotirajDesno.UseVisualStyleBackColor = false;
            this.btnRotirajDesno.Click += new System.EventHandler(this.btnRotirajDesno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rotiraj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Svjetlina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kontrast:";
            // 
            // tbSvjetlina
            // 
            this.tbSvjetlina.BackColor = System.Drawing.SystemColors.Control;
            this.tbSvjetlina.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.tbSvjetlina.Location = new System.Drawing.Point(9, 24);
            this.tbSvjetlina.Name = "tbSvjetlina";
            this.tbSvjetlina.Size = new System.Drawing.Size(145, 45);
            this.tbSvjetlina.TabIndex = 14;
            this.tbSvjetlina.Value = 5;
            this.tbSvjetlina.ValueChanged += new System.EventHandler(this.tbSvjetlina_ValueChanged);
            // 
            // tbKontrast
            // 
            this.tbKontrast.BackColor = System.Drawing.SystemColors.Control;
            this.tbKontrast.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.tbKontrast.Location = new System.Drawing.Point(9, 92);
            this.tbKontrast.Name = "tbKontrast";
            this.tbKontrast.Size = new System.Drawing.Size(145, 45);
            this.tbKontrast.TabIndex = 15;
            this.tbKontrast.Value = 5;
            // 
            // lblVelicinaSlike
            // 
            this.lblVelicinaSlike.AutoSize = true;
            this.lblVelicinaSlike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelicinaSlike.Location = new System.Drawing.Point(9, 340);
            this.lblVelicinaSlike.Name = "lblVelicinaSlike";
            this.lblVelicinaSlike.Size = new System.Drawing.Size(163, 16);
            this.lblVelicinaSlike.TabIndex = 16;
            this.lblVelicinaSlike.Text = "Promijeni veličinu slike(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Visina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Širina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "-";
            // 
            // tbPovecajVisinu
            // 
            this.tbPovecajVisinu.Location = new System.Drawing.Point(66, 171);
            this.tbPovecajVisinu.Name = "tbPovecajVisinu";
            this.tbPovecajVisinu.Size = new System.Drawing.Size(34, 20);
            this.tbPovecajVisinu.TabIndex = 23;
            // 
            // tbSmanjiVisinu
            // 
            this.tbSmanjiVisinu.Location = new System.Drawing.Point(120, 171);
            this.tbSmanjiVisinu.Name = "tbSmanjiVisinu";
            this.tbSmanjiVisinu.Size = new System.Drawing.Size(34, 20);
            this.tbSmanjiVisinu.TabIndex = 24;
            // 
            // tbPovecajSirinu
            // 
            this.tbPovecajSirinu.Location = new System.Drawing.Point(66, 193);
            this.tbPovecajSirinu.Name = "tbPovecajSirinu";
            this.tbPovecajSirinu.Size = new System.Drawing.Size(34, 20);
            this.tbPovecajSirinu.TabIndex = 25;
            // 
            // tbSmanjiSirinu
            // 
            this.tbSmanjiSirinu.Location = new System.Drawing.Point(120, 193);
            this.tbSmanjiSirinu.Name = "tbSmanjiSirinu";
            this.tbSmanjiSirinu.Size = new System.Drawing.Size(34, 20);
            this.tbSmanjiSirinu.TabIndex = 26;
            // 
            // btnPromijeniVelicinu
            // 
            this.btnPromijeniVelicinu.BackColor = System.Drawing.SystemColors.Control;
            this.btnPromijeniVelicinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniVelicinu.Location = new System.Drawing.Point(66, 219);
            this.btnPromijeniVelicinu.Name = "btnPromijeniVelicinu";
            this.btnPromijeniVelicinu.Size = new System.Drawing.Size(88, 33);
            this.btnPromijeniVelicinu.TabIndex = 27;
            this.btnPromijeniVelicinu.Text = "Promijeni";
            this.btnPromijeniVelicinu.UseVisualStyleBackColor = false;
            this.btnPromijeniVelicinu.Click += new System.EventHandler(this.btnPromijeniVelicinu_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.BackColor = System.Drawing.SystemColors.Control;
            this.btnVrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVrati.Image = ((System.Drawing.Image)(resources.GetObject("btnVrati.Image")));
            this.btnVrati.Location = new System.Drawing.Point(14, 54);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(64, 23);
            this.btnVrati.TabIndex = 28;
            this.btnVrati.UseVisualStyleBackColor = false;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // btnIzrezi
            // 
            this.btnIzrezi.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzrezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzrezi.Image = ((System.Drawing.Image)(resources.GetObject("btnIzrezi.Image")));
            this.btnIzrezi.Location = new System.Drawing.Point(82, 54);
            this.btnIzrezi.Name = "btnIzrezi";
            this.btnIzrezi.Size = new System.Drawing.Size(64, 23);
            this.btnIzrezi.TabIndex = 29;
            this.btnIzrezi.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPromijeniVelicinu);
            this.panel1.Controls.Add(this.tbSmanjiSirinu);
            this.panel1.Controls.Add(this.tbPovecajSirinu);
            this.panel1.Controls.Add(this.tbSmanjiVisinu);
            this.panel1.Controls.Add(this.tbPovecajVisinu);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbKontrast);
            this.panel1.Controls.Add(this.tbSvjetlina);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 265);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 693);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIzrezi);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.lblVelicinaSlike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotirajDesno);
            this.Controls.Add(this.btnRotirajLijevo);
            this.Controls.Add(this.btnNegativ);
            this.Controls.Add(this.btnGrayScale);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnUcitaj);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacija za uredivanje slike";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSvjetlina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKontrast)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnGrayScale;
        private System.Windows.Forms.Button btnNegativ;
        private System.Windows.Forms.Button btnRotirajLijevo;
        private System.Windows.Forms.Button btnRotirajDesno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSvjetlina;
        private System.Windows.Forms.TrackBar tbKontrast;
        private System.Windows.Forms.Label lblVelicinaSlike;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPovecajVisinu;
        private System.Windows.Forms.TextBox tbSmanjiVisinu;
        private System.Windows.Forms.TextBox tbPovecajSirinu;
        private System.Windows.Forms.TextBox tbSmanjiSirinu;
        private System.Windows.Forms.Button btnPromijeniVelicinu;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button btnIzrezi;
        private System.Windows.Forms.Panel panel1;
    }
}

