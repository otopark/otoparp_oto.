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
    public partial class Araç_Giriş_Çıkış : Form
    {
        public Araç_Giriş_Çıkış()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel_Ana_Sayfası anamenu = new Personel_Ana_Sayfası();//yeni bir menü sayfası oluşturur
            anamenu.Show();//menü sayfasını açar
            this.Hide();////mevcut sayfayı gizler
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
