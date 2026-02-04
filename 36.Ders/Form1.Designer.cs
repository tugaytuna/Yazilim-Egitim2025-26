using System.Windows.Forms;

namespace FormUygulamalari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtProfilePic = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblProfilePic = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chbKullaniciSozlesme = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(58, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(502, 654);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(30, 250);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(6);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(430, 58);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(36, 200);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(6);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(420, 31);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(30, 123);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtKullaniciAdi.MaxLength = 16;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(426, 31);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtProfilePic);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.lblProfilePic);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.chbKullaniciSozlesme);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnKayitOl);
            this.groupBox2.Controls.Add(this.txtYeniSifreTekrar);
            this.groupBox2.Controls.Add(this.txtYeniSifre);
            this.groupBox2.Controls.Add(this.txtYeniKullaniciAdi);
            this.groupBox2.Location = new System.Drawing.Point(616, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(584, 652);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Ol";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(44, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 56);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Profil Fotoğrafı Ekle:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(325, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 29);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Link";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(215, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 29);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dosya";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtProfilePic
            // 
            this.txtProfilePic.Location = new System.Drawing.Point(41, 456);
            this.txtProfilePic.Name = "txtProfilePic";
            this.txtProfilePic.Size = new System.Drawing.Size(460, 31);
            this.txtProfilePic.TabIndex = 11;
            this.txtProfilePic.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(168, 98);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 29);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Öğretmen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblProfilePic
            // 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.Location = new System.Drawing.Point(38, 428);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(184, 25);
            this.lblProfilePic.TabIndex = 10;
            this.lblProfilePic.Text = "Profil Resmi Linki:";
            this.lblProfilePic.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 98);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 29);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Öğrenci";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chbKullaniciSozlesme
            // 
            this.chbKullaniciSozlesme.AutoSize = true;
            this.chbKullaniciSozlesme.Location = new System.Drawing.Point(44, 510);
            this.chbKullaniciSozlesme.Margin = new System.Windows.Forms.Padding(6);
            this.chbKullaniciSozlesme.Name = "chbKullaniciSozlesme";
            this.chbKullaniciSozlesme.Size = new System.Drawing.Size(413, 29);
            this.chbKullaniciSozlesme.TabIndex = 7;
            this.chbKullaniciSozlesme.Text = "Kullanıcı sözleşmesini kabul ediyorum.";
            this.chbKullaniciSozlesme.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ŞifreTekrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(44, 551);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(6);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(464, 71);
            this.btnKayitOl.TabIndex = 3;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(44, 329);
            this.txtYeniSifreTekrar.Margin = new System.Windows.Forms.Padding(6);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '*';
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(460, 31);
            this.txtYeniSifreTekrar.TabIndex = 2;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(44, 248);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(6);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(460, 31);
            this.txtYeniSifre.TabIndex = 1;
            // 
            // txtYeniKullaniciAdi
            // 
            this.txtYeniKullaniciAdi.Location = new System.Drawing.Point(44, 171);
            this.txtYeniKullaniciAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtYeniKullaniciAdi.Name = "txtYeniKullaniciAdi";
            this.txtYeniKullaniciAdi.Size = new System.Drawing.Size(460, 31);
            this.txtYeniKullaniciAdi.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.AutoSize = true;
            this.btnCikis.Location = new System.Drawing.Point(1438, 94);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(104, 25);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.TabStop = true;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.Visible = false;
            this.btnCikis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCikis_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormUygulamalari.Properties.Resources.okul;
            this.pictureBox1.Location = new System.Drawing.Point(1276, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Görsel Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1768, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbKullaniciSozlesme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniKullaniciAdi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.LinkLabel btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtProfilePic;
        private System.Windows.Forms.Label lblProfilePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

