using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class AdminForm : Form
    {
        private string connectionString = @"Server=localhost\SQLEXPRESS;Database=TinyHouseProject;Trusted_Connection=True;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;
            KullaniciListele();
        }

        private void KullaniciListele()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT KullaniciID, Ad, Soyad, Eposta, Sifre, Rol, HesapAktif FROM Kullanicilar WHERE HesapAktif = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                   
                    dataGridView1.Columns["KullaniciID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    

      private void btnKullanicilariYukle_Click(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int kullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["KullaniciID"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE Kullanicilar SET HesapAktif = 0 WHERE KullaniciID = @ID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@ID", kullaniciID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı pasif hale getirildi.");
                        KullaniciListele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
            }
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            if (ekleForm.ShowDialog() == DialogResult.OK)
            {
                KullaniciListele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı satırı seçin.");
                return;
            }

            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                int kullaniciID = Convert.ToInt32(row.Cells["KullaniciID"].Value);
                string ad = row.Cells["Ad"].Value.ToString();
                string soyad = row.Cells["Soyad"].Value.ToString();
                string eposta = row.Cells["Eposta"].Value.ToString();
                string rol = row.Cells["Rol"].Value.ToString();
                string sifre = row.Cells["Sifre"].Value.ToString();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"UPDATE Kullanicilar 
                 SET Ad = @Ad, Soyad = @Soyad, Eposta = @Eposta, Sifre = @Sifre, Rol = @Rol 
                 WHERE KullaniciID = @ID";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Eposta", eposta);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@ID", kullaniciID);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                        KullaniciListele();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız. ID bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
