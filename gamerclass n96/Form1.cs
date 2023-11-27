using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamerclass_n96
{
    public partial class Form1 : Form
    {
        stardew_walley oyuncu1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            oyuncu1 = new stardew_walley();
            oyuncu1.Id = rnd.Next(1000, 100000).ToString();
            oyuncu1.NickName = txtNick.Text;
            oyuncu1.Gmail = txtGmail.Text;
            oyuncu1.puan = 100;
            oyuncu1.KTarih = DateTime.Now;
            oyuncu1.Aktif = true;

            lblKaydet.Text = "BİLGİLERİNİZ KAYDEDİLDİ";
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Id: " + oyuncu1.Id
                            + "\n Nick Name: " + oyuncu1.NickName
                            + "\n Gmail: " + oyuncu1.Gmail
                            + "\n Kayıt: " + oyuncu1.KTarih); 
                            
        }
    }
}
