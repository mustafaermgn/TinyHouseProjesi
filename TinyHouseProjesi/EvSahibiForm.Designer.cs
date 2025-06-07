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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIlanlar
            // 
            this.dataGridViewIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlanlar.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewIlanlar.Name = "dataGridViewIlanlar";
            this.dataGridViewIlanlar.RowHeadersWidth = 51;
            this.dataGridViewIlanlar.RowTemplate.Height = 24;
            this.dataGridViewIlanlar.Size = new System.Drawing.Size(536, 363);
            this.dataGridViewIlanlar.TabIndex = 0;
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.Location = new System.Drawing.Point(527, 444);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIlanEkle.TabIndex = 1;
            this.btnIlanEkle.Text = "ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = true;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.Location = new System.Drawing.Point(527, 485);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(75, 23);
            this.btnIlanSil.TabIndex = 2;
            this.btnIlanSil.Text = "sil";
            this.btnIlanSil.UseVisualStyleBackColor = true;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // btnRezervasyonlar
            // 
            this.btnRezervasyonlar.Location = new System.Drawing.Point(414, 527);
            this.btnRezervasyonlar.Name = "btnRezervasyonlar";
            this.btnRezervasyonlar.Size = new System.Drawing.Size(75, 23);
            this.btnRezervasyonlar.TabIndex = 3;
            this.btnRezervasyonlar.Text = "rez";
            this.btnRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnRezervasyonlar.Click += new System.EventHandler(this.btnRezervasyonlar_Click);
            // 
            // btnRezervasyonOnayla
            // 
            this.btnRezervasyonOnayla.Location = new System.Drawing.Point(120, 566);
            this.btnRezervasyonOnayla.Name = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.Size = new System.Drawing.Size(289, 23);
            this.btnRezervasyonOnayla.TabIndex = 4;
            this.btnRezervasyonOnayla.Text = "btnRezervasyonOnayla";
            this.btnRezervasyonOnayla.UseVisualStyleBackColor = true;
            this.btnRezervasyonOnayla.Click += new System.EventHandler(this.btnRezervasyonOnayla_Click);
            // 
            // btnRezervasyonReddet
            // 
            this.btnRezervasyonReddet.Location = new System.Drawing.Point(470, 566);
            this.btnRezervasyonReddet.Name = "btnRezervasyonReddet";
            this.btnRezervasyonReddet.Size = new System.Drawing.Size(75, 23);
            this.btnRezervasyonReddet.TabIndex = 5;
            this.btnRezervasyonReddet.Text = "btnRezervasyonReddet";
            this.btnRezervasyonReddet.UseVisualStyleBackColor = true;
            this.btnRezervasyonReddet.Click += new System.EventHandler(this.btnRezervasyonReddet_Click);
            // 
            // EvSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 619);
            this.Controls.Add(this.btnRezervasyonReddet);
            this.Controls.Add(this.btnRezervasyonOnayla);
            this.Controls.Add(this.btnRezervasyonlar);
            this.Controls.Add(this.btnIlanSil);
            this.Controls.Add(this.btnIlanEkle);
            this.Controls.Add(this.dataGridViewIlanlar);
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
    }
}