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
    public partial class Personel_Giriş_Sayfası : Form
    {
        public Personel_Giriş_Sayfası()
        {
            InitializeComponent();
        }

        public SqlConnection bag = new SqlConnection("server=.; Initial Catalog=Otopark_Otomasyonu;Integrated Security=SSPI");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();
        public static string musteritc = null;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Personel_Giriş where [TC No]='" + textBox1.Text + "' and Sifre ='" + textBox2.Text + "'", bag);
            //access komutumuzu yazdık komutta veritabanındaki admin tablosunda kullanıcı adı textbox1.text olan şifresi textbox2.text olan veriyi
            // çekmesini istedik
            bag.Open();//bağlantıyı açdık

            SqlDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik

            if (oku.Read())//if eğer veriyi okumuşsa yani böyle bir kullanıcı veritabanında kayıtlıysa
            {

                MessageBox.Show("Giriş Başarılı !");//giriş başarılı diye uyari verir
                bag.Close();//bağlantıyı kapar
                Personel_Ana_Sayfası anamenu = new Personel_Ana_Sayfası();//yeni bir menü sayfası oluşturur
                anamenu.Show();//menü sayfasını açar
                this.Hide();////mevcut sayfayı gizler

            }
            else
            {
                bag.Close();//bağlantıyı kapar
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");//hayır veri okuyamadıysa uyarı verir
                textBox1.Text = "";
                textBox2.Text = "";
                //verileri temizler
            }


        }
           
    }
}

