using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ototpark_Otomasyonu
{
    public partial class Personel_Ana_Sayfası : Form
    {
        public Personel_Ana_Sayfası()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Müşteri_Kayıt müskay = new Müşteri_Kayıt();//yeni bir menü sayfası oluşturur
            müskay.Show();//menü sayfasını açar
            this.Hide();////mevcut sayfayı gizler
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Personel_Giriş_Sayfası pergir = new Personel_Giriş_Sayfası();//yeni bir menü sayfası oluşturur
            pergir.Show();//menü sayfasını açar
            this.Hide();////mevcut sayfayı gizler
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Araç_Giriş_Çıkış araç_gir_çık = new Araç_Giriş_Çıkış();//yeni bir menü sayfası oluşturur
            araç_gir_çık.Show();//menü sayfasını açar
            this.Hide();////mevcut sayfayı gizler
        }
    }
}
