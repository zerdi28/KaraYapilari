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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";
            if (username == txtDeger.Text)
            {
                if (password == txtDeger1.Text)
                {
                    result = "Tebrikler";
                }
                else
                {
                    result = "Şifreniz yanlış";
                }
            }

            else
            {
                result = "Kullanıcı adınız yanlış";
            }
            MessageBox.Show(result);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123";

            string result = "";
            if (txtDeger.Text == username && txtDeger1.Text == password)
            {
                result = "Tebrikler";
            }
            else
            {
                result = "Kullanıcı adınız veya şifreniz yanlış";
            }
            MessageBox.Show(result);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int not = Convert.ToInt32(txtDeger.Text);

            if (not >= 0 && not <= 30)
            {
                MessageBox.Show("FF");
            }
            else if (not > 30 || not <= 50)
            {
                MessageBox.Show("DD");
            }
            else if (not > 50 || not <= 70)
            {
                MessageBox.Show("BB");
            }
            else if (not > 70 || not <= 100)
            {
                MessageBox.Show("AA");
            }
            else
            {
                MessageBox.Show("0 ile 100 arasında bir değer girin!");
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            string urunadi = txtDeger.Text.ToLower(); //hepsını kucuk harfe cevırır
            string mesaj = "Aradığınız ürün";
            if (urunadi =="domates" || urunadi =="patlıcan"|| urunadi =="biber")
            {
                mesaj += "Sebze Reyonundadır!";
            }
            else if (urunadi == "Diş Macunu" || urunadi == "Parfüm" || urunadi == "şampuan")
            {
                mesaj += "Kozmetik Reyonundadır!";
            }
            else if (urunadi == "Cep Telefonu" || urunadi == "Bilgisayar" || urunadi == "Ses Sistemi")
            {
                mesaj += "Teknoloji Reyonundadır!";
            }
            else
            {
                mesaj += "Bu ürün bize bulunmamaktadır!";
            }
            MessageBox.Show(mesaj);
        }
    }
}
