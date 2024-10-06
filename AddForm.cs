using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text != string.Empty)
            //if (txtCustName.Text != string.Empty && txtTotal.Text != string.Empty)
            {
                var newOrder = new Coffee();
                newOrder.OrderId = Guid.NewGuid();
                //newOrder.OrderId = int.Parse(txtOrderid.Text);
                newOrder.Name = txtCoffeeName.Text;
                newOrder.Customer = txtCustName.Text;
                newOrder.BagCount = int.Parse(txtCount.Text);
                newOrder.OrderTotal = decimal.Parse(lblTotalPrice.Text.Substring(1));
                newOrder.BagSize = (BagSize)(comboSize.SelectedIndex);

                CoffeeData.Coffees.Add(newOrder);
                MessageBox.Show("Order Added!");
                RefreshInputs();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            comboSize.DataSource = Enum.GetValues(typeof(BagSize));
        }

        private void RefreshInputs()
        {
            //txtOrderid.Clear();
            txtCoffeeName.Clear();
            txtCustName.Clear();
            txtCount.Clear();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee();
            //int bagCount = int.Parse(txtCount.Text);
            int bagCount;

            if (int.TryParse(txtCount.Text, out bagCount))
            {
                int bagsize = comboSize.SelectedIndex;
                double bulkPrice = newCoffee.CoffeeBulkPrice(bagCount, bagsize);
                lblTotalPrice.Text = "$" + bulkPrice.ToString();
            }

            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                lblTotalPrice.Text = "$0.00";
            }
        }
    }
}
