using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_zadacha
{
    public partial class Form2 : Form
    {
        public bool IsReady = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsReady = true;
            this.Close();
        }
        public string GetName()
        {
            return textBox1.Text;
        }
        public string GetAdress()
        {
            return textBox2.Text;
        }
        public string GetTelephoneNumber()
        {
            return textBox3.Text;
        }
        public string GetEmail()
        {
            return textBox4.Text;
        }
    }
}
