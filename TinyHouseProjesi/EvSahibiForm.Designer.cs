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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).BeginInit();
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
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.Location = new System.Drawing.Point(950, 82);
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
            this.btnRezervasyonlar.Location = new System.Drawing.Point(950, 184);
            this.btnRezervasyonlar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(84, 29);
            this.btnRezervasyonlar.TabIndex = 3;
            this.btnRezervasyonlar.Text = "rez";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // btnRezervasyonOnayla
            // 
            this.btnRezervasyonOnayla.Location = new System.Drawing.Point(659, 713);
            this.btnRezervasyonOnayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonOnayla.Name = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.Size = new System.Drawing.Size(325, 29);
            this.btnRezervasyonOnayla.TabIndex = 4;
            this.btnRezervasyonOnayla.Text = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.UseVisualStyleBackColor = true;
            this.btnRezervasyonOnayla.Click += new System.EventHandler(this.btnRezervasyonOnayla_Click);
            // 
            // btnRezervasyonReddet
            // 
            this.btnRezervasyonReddet.Location = new System.Drawing.Point(950, 237);
            this.btnRezervasyonReddet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervasyonReddet.Name = "btnRezervasyonReddet";
            this.btnRezervasyonReddet.Size = new System.Drawing.Size(84, 29);
            this.btnRezervasyonReddet.TabIndex = 5;
            this.btnRezervasyonReddet.Text = "btnRezervasyonReddet";
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
            // EvSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 774);
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
    }
}