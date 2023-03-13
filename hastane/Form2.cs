using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane
{
    public partial class Form2 : Form
    {
        string ad;
        string soyad;
        string kimlikno;
        string yas;
        string kilo;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txad_TextChanged(object sender, EventArgs e)
        {
            ad = txad.Text;
        }

        private void txsoyad_TextChanged(object sender, EventArgs e)
        {
            soyad = txsoyad.Text;
        }

        private void txkimlikno_TextChanged(object sender, EventArgs e)
        {
            kimlikno = txkimlikno.Text;
        }

        private void txyas_TextChanged(object sender, EventArgs e)
        {
            yas = txyas.Text;
        }

        private void txkilo_TextChanged(object sender, EventArgs e)
        {
            kilo = txkilo.Text;
        }

        private void btgiris_Click(object sender, EventArgs e)
        {
            string result = ad + " " + soyad + " " + kimlikno + " " + yas + " " + kilo ;
            using ( StreamWriter SW = File.AppendText("bilgi{kimlikno}.txt"))
            {
                SW.WriteLine(result);
            }
            if (txkimlikno.Text.Length != 11)
            {
                MessageBox.Show("Kimlik numaranız eksik veya hatalıdır. Lütfen kontrol edin...");
            }
        }

        private void btkapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
