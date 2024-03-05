using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rehber
{
	public partial class Rehber : Form
	{
		public Rehber()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True;Encrypt=False");

		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Kisiler", baglanti);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		void temizle()
		{
			TxtAd.Text = "";
			TxtId.Text = "";
			TxtMail.Text = "";
			TxtSoyad.Text = "";
			MskTel.Text = "";
			TxtAd.Focus();	
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void BtnEkle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into Kisiler (AD, SOYAD, TELEFON, MAIL) values (@P1,@P2,@P3,@P4)", baglanti);
			komut.Parameters.AddWithValue("@P1", TxtAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@P3", MskTel.Text);
			komut.Parameters.AddWithValue("@P4", TxtMail.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kişi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information );
			listele();
			temizle();
		}

		private void BtnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			
			TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Delete From Kisiler where ID=" + TxtId.Text, baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Kişi Rehberden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			listele();
			temizle();
			
		}

		private void BtnGüncelle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update Kisiler set AD=@P1, SOYAD=@P2,TELEFON=@P3,MAIL=@P4 where ID=@P5", baglanti);
			komut.Parameters.AddWithValue("@P1", TxtAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@P3", MskTel.Text);
			komut.Parameters.AddWithValue("@P4", TxtMail.Text);
			komut.Parameters.AddWithValue("@P5", TxtId.Text);
			komut.ExecuteNonQuery();
			baglanti.Close() ;
			MessageBox.Show("Kişi Bilgisi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			listele();
			temizle();
		}
	}
}
