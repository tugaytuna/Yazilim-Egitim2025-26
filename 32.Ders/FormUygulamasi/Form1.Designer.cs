namespace FormUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            txtKullaniciAdi = new TextBox();
            btnAdminEkle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(0, 0, 192);
            btnGirisYap.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(178, 186);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(160, 65);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(178, 157);
            txtKullaniciAdi.MaxLength = 16;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(160, 23);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdminEkle
            // 
            btnAdminEkle.Location = new Point(344, 157);
            btnAdminEkle.Name = "btnAdminEkle";
            btnAdminEkle.Size = new Size(75, 23);
            btnAdminEkle.TabIndex = 2;
            btnAdminEkle.Text = "Admin Ekle";
            btnAdminEkle.UseVisualStyleBackColor = true;
            btnAdminEkle.Click += btnAdminEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 139);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 417);
            Controls.Add(label1);
            Controls.Add(btnAdminEkle);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdminEkle;
        private Label label1;
        private TextBox txtKullaniciAdi;
        public Button btnGirisYap;
    }
}
