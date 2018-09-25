using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nilai1.Text);
            var b = Convert.ToInt32(nilai2.Text);

            lstHasil.Items.Clear();
            lstHasil.Items.Add("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b)));
            lstHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b)));
        }
    }
}
