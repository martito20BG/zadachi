using Kursova_zadacha.Models;
using System;

namespace Kursova_zadacha
{
    public partial class Form1 : Form
    {
        public static WarehouseDbContext db = new WarehouseDbContext();

        public Form1()
        {
            InitializeComponent();
            UpdateManufacturers();
            UpdateProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBox1.Text;
            product.Manufacturer = db.Manufacturers.First(x => x.Name == comboBox1.Text);
            product.Warranty = int.Parse(textBox5.Text);
            product.PriceForOne = double.Parse(textBox4.Text);
            product.Ammount = (int)numericUpDown1.Value;
            db.Products.Add(product);
            db.SaveChanges();
            UpdateProducts();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

            if (!form.IsReady)
                return;

            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Name = form.GetName();
            manufacturer.Adress = form.GetAdress();
            manufacturer.TelephoneNumber = form.GetTelephoneNumber();
            manufacturer.Email = form.GetEmail();
            db.Manufacturers.Add(manufacturer);
            db.SaveChanges();
            UpdateManufacturers();
        }

        void UpdateManufacturers()
        {
            comboBox1.Items.Clear();
            foreach (var e in db.Manufacturers)
            {
                comboBox1.Items.Add(e.Name);
            }
        }

        void UpdateProducts()
        {
            dataGridView1.Rows.Clear();
            foreach (var e in db.Products)
            {
                dataGridView1.Rows.Add(e.Id, e.Name, e.Warranty, e.PriceForOne, e.Ammount, e.Manufacturer.Name, e.Manufacturer.Adress, e.Manufacturer.TelephoneNumber, e.Manufacturer.Email, e.PriceForOne * e.Ammount);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e2)
        {
            foreach (DataGridViewRow e in dataGridView1.SelectedRows)
            {
                var id = (int)e.Cells[0].Value;
                var product = db.Products.First(x => x.Id == id);
                db.Products.Remove(product);
            }

            db.SaveChanges();
            UpdateProducts();
        }
    }
}