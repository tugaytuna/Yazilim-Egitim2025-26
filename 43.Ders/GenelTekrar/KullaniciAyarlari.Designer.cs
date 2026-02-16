namespace GenelTekrar
{
    partial class KullaniciAyarlari
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcının Adı";
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOnay.Location = new System.Drawing.Point(123, 180);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(112, 72);
            this.btnOnay.TabIndex = 1;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Location = new System.Drawing.Point(241, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 72);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // KullaniciAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciAyarlari";
            this.Text = "KullaniciAyarlari";
            this.Load += new System.EventHandler(this.KullaniciAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
    }
}