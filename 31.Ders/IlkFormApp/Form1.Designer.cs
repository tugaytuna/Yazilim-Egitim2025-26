namespace IlkFormApp
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
            btnGiris = new Button();
            txtKullaniciAdi = new TextBox();
            btnAdminEkle = new Button();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(71, 172);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(264, 64);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(71, 134);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(264, 23);
            txtKullaniciAdi.TabIndex = 1;
            txtKullaniciAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdminEkle
            // 
            btnAdminEkle.Location = new Point(341, 134);
            btnAdminEkle.Name = "btnAdminEkle";
            btnAdminEkle.Size = new Size(75, 23);
            btnAdminEkle.TabIndex = 2;
            btnAdminEkle.Text = "Admin Ekle";
            btnAdminEkle.UseVisualStyleBackColor = true;
            btnAdminEkle.Click += btnAdminEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 465);
            Controls.Add(btnAdminEkle);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGiris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private TextBox txtKullaniciAdi;
        private Button btnAdminEkle;
    }
}
