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
    public partial class Form3 : Form
    {
        string il;
        string ilce;
        string hastane;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce = cbilce.Text; 
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            il = cbil.Text;
            if (cbil.SelectedIndex == 0)
            {
                cbilce.Items.Add("Bornova");
                cbilce.Items.Add("Gaziemir");
                cbilce.Items.Add("Karşıyaka");
                cbilce.Items.Add("Menemen");
                cbilce.Items.Add("Urla");
            }
            else if (cbil.SelectedIndex == 1)
            {
                cbilce.Items.Add("Altınyayla");
                cbilce.Items.Add("Divriği");
                cbilce.Items.Add("Gemerek");
                cbilce.Items.Add("Şarkışla");
                cbilce.Items.Add("Zara");
            }
        }

        private void cbhastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastane = cbhastane.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
        }

        private void randevu_Click(object sender, EventArgs e)
        {
            string result = il + "," + ilce + "," + hastane;
            using (StreamWriter sw= File.AppendText("randevu.txt"))
            {
                sw.WriteLine(result);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
