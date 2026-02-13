namespace SubatOnbir
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
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuncelleKitapAd = new System.Windows.Forms.TextBox();
            this.txtGuncelleYazarAd = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(34, 123);
            this.txtKitapAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(332, 31);
            this.txtKitapAd.TabIndex = 0;
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(34, 212);
            this.txtYazarAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(332, 31);
            this.txtYazarAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtGuncelleYazarAd);
            this.groupBox1.Controls.Add(this.txtGuncelleKitapAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYazarAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKitapAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(960, 675);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(39, 386);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(394, 44);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "KitapIsim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(564, 121);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 304);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Basım Tarihi:";
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "KitapIsim";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1042, 77);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 229);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(1037, 327);
            this.lblBilgi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(70, 25);
            this.lblBilgi.TabIndex = 6;
            this.lblBilgi.Text = "label4";
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.lblBilgi2.Location = new System.Drawing.Point(1037, 369);
            this.lblBilgi2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(70, 25);
            this.lblBilgi2.TabIndex = 7;
            this.lblBilgi2.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(648, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Güncelle";
            // 
            // txtGuncelleKitapAd
            // 
            this.txtGuncelleKitapAd.Location = new System.Drawing.Point(564, 181);
            this.txtGuncelleKitapAd.Name = "txtGuncelleKitapAd";
            this.txtGuncelleKitapAd.Size = new System.Drawing.Size(314, 31);
            this.txtGuncelleKitapAd.TabIndex = 9;
            // 
            // txtGuncelleYazarAd
            // 
            this.txtGuncelleYazarAd.Location = new System.Drawing.Point(564, 237);
            this.txtGuncelleYazarAd.Name = "txtGuncelleYazarAd";
            this.txtGuncelleYazarAd.Size = new System.Drawing.Size(314, 31);
            this.txtGuncelleYazarAd.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(564, 285);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(314, 39);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lblBilgi2);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtGuncelleYazarAd;
        private System.Windows.Forms.TextBox txtGuncelleKitapAd;
        private System.Windows.Forms.Label label4;
    }
}

