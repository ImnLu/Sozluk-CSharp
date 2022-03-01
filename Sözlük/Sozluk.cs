using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Globalization;

namespace Sözlük
{
    public partial class Sozluk : Form
    {
        public Sozluk()
        {
            InitializeComponent();
        }

        private void buttonKelimeBul_Click_1(object sender, EventArgs e)
        {
            // Kelimeyi aramadan önce internet bağlantısını kontrol ediyor.
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                // sozluk.gov.tr apisini kullanarak girilen kelimenin anlamını buluyor.
                string adres = "https://sozluk.gov.tr/gts?ara=" + textGirilenKelime.Text.ToLower();
                WebRequest istek = HttpWebRequest.Create(adres);
                WebResponse cevap;
                cevap = istek.GetResponse();
                StreamReader donenbilgiler = new StreamReader(cevap.GetResponseStream());
                string gelen = donenbilgiler.ReadToEnd();
                int kelimeanlam = gelen.IndexOf("\"anlam\"") + 9;
                int kelimeanlambitis = gelen.Substring(kelimeanlam).IndexOf("\"");
                string anlam = gelen.Substring(kelimeanlam, kelimeanlambitis);

                string girilenkelimekucuk = textGirilenKelime.Text.ToLower();

                // Girilen kelime boş ise arama yapmıyor.
                if (!string.IsNullOrEmpty(textGirilenKelime.Text))
                {
                    // Eğer kelime bulunmadıysa kelimenin bulunamadığını söylüyor.
                    if (anlam == ":")
                    {
                        richTextBox1.Text = "Kelime bulunamadı (" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(girilenkelimekucuk) + ")";
                        textGirilenKelime.Text = "";
                        textGirilenKelime.Focus();
                    }
                    else
                    {
                        richTextBox1.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(girilenkelimekucuk) + ": " + anlam;

                        //Girilen kelimeyi renkli yapıyor.
                        int kelimeuzunluk = textGirilenKelime.Text.Length;
                        richTextBox1.SelectionStart = 0;
                        richTextBox1.SelectionLength = kelimeuzunluk + 1;
                        richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.SelectionStart = this.richTextBox1.TextLength;
                        textGirilenKelime.Text = "";
                        textGirilenKelime.Focus();
                    }
                }
            }
            else
                MessageBox.Show("İnternet bağlantınızı kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textGirilenKelime_KeyDown(object sender, KeyEventArgs e)
        {
            // Girilen kelimeyi 'enter' tuşuna basıldığında aramasını sağlıyor.
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonKelimeBul.PerformClick();
            }
        }
    }
}
