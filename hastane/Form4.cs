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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = System.IO.File.ReadAllLines("bilgi{kimlikno}.txt");
            Random r = new Random();
            int x = r.Next(data.Length);
            label1.Text = data[x];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] data = System.IO.File.ReadAllLines("randevu.txt");
            Random r = new Random();
            int x = r.Next(data.Length);
            label2.Text = data[x];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
