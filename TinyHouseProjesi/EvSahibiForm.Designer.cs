namespace TinyHouseProjesi
{
    partial class EvSahibiForm
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
            this.dataGridViewIlanlar = new System.Windows.Forms.DataGridView();
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.btnRezervasyonlar = new System.Windows.Forms.Button();
            this.btnRezervasyonOnayla = new System.Windows.Forms.Button();
            this.btnRezervasyonReddet = new System.Windows.Forms.Button();
            this.yenileBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.grp_guncelle = new System.Windows.Forms.GroupBox();
            this.tb_baslik = new System.Windows.Forms.TextBox();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_il = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ilce = new System.Windows.Forms.TextBox();
            this.güncelleOnay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.cb_aktif = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_odaSayisi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).BeginInit();
            this.grp_guncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIlanlar
            // 
            this.dataGridViewIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlanlar.Location = new System.Drawing.Point(30, 13);
            this.dataGridViewIlanlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewIlanlar.Name = "dataGridViewIlanlar";
            this.dataGridViewIlanlar.RowHeadersWidth = 51;
            this.dataGridViewIlanlar.RowTemplate.Height = 24;
            this.dataGridViewIlanlar.Size = new System.Drawing.Size(900, 454);
            this.dataGridViewIlanlar.TabIndex = 0;
            this.dataGridViewIlanlar.SelectionChanged += new System.EventHandler(this.dataGridViewIlanlar_SelectionChanged_1);
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.Location = new System.Drawing.Point(950, 96);
            this.btnIlanEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(84, 29);
            this.btnIlanEkle.TabIndex = 1;
            this.btnIlanEkle.Text = "ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = true;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.Location = new System.Drawing.Point(950, 133);
            this.btnIlanSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(84, 29);
            this.btnIlanSil.TabIndex = 2;
            this.btnIlanSil.Text = "sil";
            this.btnIlanSil.UseVisualStyleBackColor = true;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.Location = new System.Drawing.Point(950, 272);
            this.btnRezervasyonlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(101, 29);
            this.btnRezervasyonlar.TabIndex = 3;
            this.btnRezervasyonlar.Text = "rez";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // btnRezervasyonOnayla
            // 
            this.btnRezervasyonOnayla.Location = new System.Drawing.Point(950, 349);
            this.btnRezervasyonOnayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonOnayla.Name = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.Size = new System.Drawing.Size(101, 29);
            this.btnRezervasyonOnayla.TabIndex = 4;
            this.btnRezervasyonOnayla.Text = "Rez-Onay";
            this.btnRezervasyonOnayla.UseVisualStyleBackColor = true;
            this.btnRezervasyonOnayla.Click += new System.EventHandler(this.btnRezervasyonOnayla_Click);
            // 
            // btnRezervasyonReddet
            // 
            this.btnRezervasyonReddet.Location = new System.Drawing.Point(950, 309);
            this.btnRezervasyonReddet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonReddet.Name = "btnRezervasyonReddet";
            this.btnRezervasyonReddet.Size = new System.Drawing.Size(101, 32);
            this.btnRezervasyonReddet.TabIndex = 5;
            this.btnRezervasyonReddet.Text = "Rez-Red";
            this.btnRezervasyonReddet.UseVisualStyleBackColor = true;
            this.btnRezervasyonReddet.Click += new System.EventHandler(this.btnRezervasyonReddet_Click);
            // 
            // yenileBtn
            // 
            this.yenileBtn.Location = new System.Drawing.Point(959, 26);
            this.yenileBtn.Name = "yenileBtn";
            this.yenileBtn.Size = new System.Drawing.Size(75, 34);
            this.yenileBtn.TabIndex = 6;
            this.yenileBtn.Text = "Yenile";
            this.yenileBtn.UseVisualStyleBackColor = true;
            this.yenileBtn.Click += new System.EventHandler(this.yenileBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(950, 169);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(84, 33);
            this.guncelleBtn.TabIndex = 7;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // grp_guncelle
            // 
            this.grp_guncelle.Controls.Add(this.tb_odaSayisi);
            this.grp_guncelle.Controls.Add(this.label7);
            this.grp_guncelle.Controls.Add(this.cb_aktif);
            this.grp_guncelle.Controls.Add(this.tb_adres);
            this.grp_guncelle.Controls.Add(this.label6);
            this.grp_guncelle.Controls.Add(this.güncelleOnay);
            this.grp_guncelle.Controls.Add(this.tb_ilce);
            this.grp_guncelle.Controls.Add(this.label5);
            this.grp_guncelle.Controls.Add(this.tb_il);
            this.grp_guncelle.Controls.Add(this.label4);
            this.grp_guncelle.Controls.Add(this.label3);
            this.grp_guncelle.Controls.Add(this.label2);
            this.grp_guncelle.Controls.Add(this.label1);
            this.grp_guncelle.Controls.Add(this.tb_fiyat);
            this.grp_guncelle.Controls.Add(this.tb_aciklama);
            this.grp_guncelle.Controls.Add(this.tb_baslik);
            this.grp_guncelle.Location = new System.Drawing.Point(82, 498);
            this.grp_guncelle.Name = "grp_guncelle";
            this.grp_guncelle.Size = new System.Drawing.Size(737, 237);
            this.grp_guncelle.TabIndex = 8;
            this.grp_guncelle.TabStop = false;
            this.grp_guncelle.Text = "Güncelleme işlemleri";
            this.grp_guncelle.Visible = false;
            // 
            // tb_baslik
            // 
            this.tb_baslik.Location = new System.Drawing.Point(67, 57);
            this.tb_baslik.Name = "tb_baslik";
            this.tb_baslik.Size = new System.Drawing.Size(190, 26);
            this.tb_baslik.TabIndex = 0;
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(66, 121);
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(191, 26);
            this.tb_aciklama.TabIndex = 1;
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(66, 195);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(100, 26);
            this.tb_fiyat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlan Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlan Açıklaması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "İlan Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "İl";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_il
            // 
            this.tb_il.Location = new System.Drawing.Point(357, 57);
            this.tb_il.Name = "tb_il";
            this.tb_il.Size = new System.Drawing.Size(111, 26);
            this.tb_il.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "İlçe";
            // 
            // tb_ilce
            // 
            this.tb_ilce.Location = new System.Drawing.Point(357, 131);
            this.tb_ilce.Name = "tb_ilce";
            this.tb_ilce.Size = new System.Drawing.Size(111, 26);
            this.tb_ilce.TabIndex = 9;
            // 
            // güncelleOnay
            // 
            this.güncelleOnay.Location = new System.Drawing.Point(581, 49);
            this.güncelleOnay.Name = "güncelleOnay";
            this.güncelleOnay.Size = new System.Drawing.Size(150, 34);
            this.güncelleOnay.TabIndex = 10;
            this.güncelleOnay.Text = "Güncelleme Onay";
            this.güncelleOnay.UseVisualStyleBackColor = true;
            this.güncelleOnay.Click += new System.EventHandler(this.güncelleOnay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres";
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(357, 195);
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(140, 26);
            this.tb_adres.TabIndex = 12;
            // 
            // cb_aktif
            // 
            this.cb_aktif.AutoSize = true;
            this.cb_aktif.Location = new System.Drawing.Point(581, 107);
            this.cb_aktif.Name = "cb_aktif";
            this.cb_aktif.Size = new System.Drawing.Size(85, 24);
            this.cb_aktif.TabIndex = 13;
            this.cb_aktif.Text = "EvAktif";
            this.cb_aktif.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Oda Sayısı";
            // 
            // tb_odaSayisi
            // 
            this.tb_odaSayisi.Location = new System.Drawing.Point(581, 195);
            this.tb_odaSayisi.Name = "tb_odaSayisi";
            this.tb_odaSayisi.Size = new System.Drawing.Size(100, 26);
            this.tb_odaSayisi.TabIndex = 15;
            // 
            // EvSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 774);
            this.Controls.Add(this.grp_guncelle);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.yenileBtn);
            this.Controls.Add(this.btnRezervasyonReddet);
            this.Controls.Add(this.btnRezervasyonOnayla);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnIlanSil);
            this.Controls.Add(this.btnIlanEkle);
            this.Controls.Add(this.dataGridViewIlanlar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EvSahibiForm";
            this.Text = "Ev Sahibi Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).EndInit();
            this.grp_guncelle.ResumeLayout(false);
            this.grp_guncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIlanlar;
        private System.Windows.Forms.Button btnIlanEkle;
        private System.Windows.Forms.Button btnIlanSil;
        private System.Windows.Forms.Button btnRezervasyonlar;
        private System.Windows.Forms.Button btnRezervasyonOnayla;
        private System.Windows.Forms.Button btnRezervasyonReddet;
        private System.Windows.Forms.Button yenileBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.GroupBox grp_guncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.TextBox tb_baslik;
        private System.Windows.Forms.Button güncelleOnay;
        private System.Windows.Forms.TextBox tb_ilce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_il;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_odaSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_aktif;
    }
}