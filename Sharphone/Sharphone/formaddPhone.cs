using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharphone
{
    public partial class formaddPhone : Form
    {
        public SmartPhone Phone { get; private set; }
        


        public formaddPhone()
        {
            InitializeComponent();
        }

        public formaddPhone(SmartPhone phone)
        {
            InitializeComponent();
            Phone = phone;

            txtModel.Text = Phone.Model;
            txtBrand.Text = Phone.Brand;
            txtPrice.Text = Phone.Price.ToString();
            txtSize.Text = Phone.StorageSizeMb.ToString();
            txtStock.Text = Phone.Stock.ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool modelValidated = string.IsNullOrEmpty(txtModel.Text);
            if (modelValidated)
            {
                MessageBox.Show("Invalid input, please enter a valid input");
                return;
            }
            bool brandValidated = string.IsNullOrEmpty(txtBrand.Text);
            if (modelValidated)
            {
                MessageBox.Show("Invalid input, please enter a valid input");
                return;
            }
            bool sizeValidated = string.IsNullOrEmpty(txtSize.Text);
            if (modelValidated)
            {
                MessageBox.Show("Invalid input, please enter a valid input");
                return;
            }
            bool priceValidated = string.IsNullOrEmpty(txtPrice.Text);
            if (modelValidated)
            {
                MessageBox.Show("Invalid input, please enter a valid input");
                return;
            }


            int Id = 1;
            string Model = (txtModel.Text);
            string Brand = (txtBrand.Text);
            int Size = int.Parse(txtSize.Text);
            double Price = double.Parse(txtPrice.Text);
            int stock = int.Parse(txtStock.Text);
            if (Phone != null)
            {
                Phone.Brand = Brand;
                Phone.Model = Model;
                Phone.StorageSizeMb = Size;
                Phone.Price = Price;
                Phone.Stock = stock;
            }
            else
            {
                Phone = new SmartPhone(Id, Brand, Model, Size, Price,stock);

            }
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


