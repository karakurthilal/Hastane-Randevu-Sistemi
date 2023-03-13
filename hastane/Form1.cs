using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bthasta_Click(object sender, EventArgs e)
        {
            Form2 HastaBilgileri = new Form2();
            HastaBilgileri.Show();
        }

        private void btrandevu_Click(object sender, EventArgs e)
        {
            Form3 HastaneRandevusu = new Form3();
            HastaneRandevusu.Show();
        }

        private void btsonuc_Click(object sender, EventArgs e)
        {
            Form4 SonucGörüntüleme = new Form4();
            SonucGörüntüleme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
