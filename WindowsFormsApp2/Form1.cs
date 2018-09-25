using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nilai1.Text);
            var b = Convert.ToInt32(nilai2.Text);
            Double hasil;
            switch (operasi.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 1:
                    hasil = a - b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 2:
                    hasil = a * b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
                case 3:
                    hasil = a / b;
                    lstHasil.Text = Convert.ToString(hasil);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nilai1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nilai2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
