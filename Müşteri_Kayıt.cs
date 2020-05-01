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

namespace Ototpark_Otomasyonu
{
    public partial class Müşteri_Kayıt : Form
    {
        public Müşteri_Kayıt()
        {
            InitializeComponent();
        }
        public SqlConnection bag = new SqlConnection("server=.; Initial Catalog=Otopark_Otomasyonu;Integrated Security=SSPI");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void button2_Click(object sender, EventArgs e)
        {
            Personel_Ana_Sayfası anamenu = new Personel_Ana_Sayfası();//yeni bir menü sayfası oluşturur
            anamenu.Show();//menü sayfasını açar
            this.Hide();////mevcut sayfayı gizler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == textBox7.Text)
            {
                SqlCommand komut = new SqlCommand("insert into Musteri_Listesi(Ad,Soyad,Tc_No,Plaka,Kullanıcı_Adı,Cep_Telefonu,[E-Posta],Sifre,Sifre_Tekrar) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + maskedTextBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", bag);
                //
                // 
                if (bag.State == ConnectionState.Closed)
                {
                    bag.Open();
                }

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Olma İşleminiz Başarılı");
                bag.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox1.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();               
            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
        }
    }
 }

