using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text == "admin")
            {
                MessageBox.Show("Tebrikler giriş yaptınız"); //true
            }
            else
            {
                MessageBox.Show("Ne kadar zor olabilir ?"); //false
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
          
            // int not = Convert.ToInt32(txtDeger.Text);
            int not = int.Parse(txtDeger.Text);

            if (not < 0 )
            {
                MessageBox.Show("0'dan küçük not girişi yapamazsınız!");
            }
            else if (not > 100)
            {
                MessageBox.Show("100'den büyük not girişi yapamazsınız!");
            }
            else
            {
                MessageBox.Show("Notunuz : " + not);
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
           
            int not = Convert.ToInt32(txtDeger.Text);
            if (not % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else 
            {
                MessageBox.Show("Sayı Tektir");
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

            int kelime = Convert.ToInt32(txtDeger.Text.Length);
           
            if (kelime >= 8)
            {
                MessageBox.Show("Kayıt onaylandı");
            }
            else
            {
                MessageBox.Show("Daha uzun bir şifre giriniz");
            }
        }
    }
}
