using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3_4
{
    public partial class CoffeeForm : Form
    {
        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            CoffeeData.Coffees.Add(new Coffee() { OrderId = Guid.NewGuid(), Name = "Midnight Espresso", Customer = "Any Time Coffee", BagSize = BagSize._12oz, BagCount = 3, OrderTotal = 30.00m });
            CoffeeData.Coffees.Add(new Coffee() { OrderId = Guid.NewGuid(), Name = "Morning Sunrise", Customer = "Sunny Side Co", BagSize = BagSize._16oz, BagCount = 1, OrderTotal = 17.99m });
            CoffeeData.Coffees.Add(new Coffee() { OrderId = Guid.NewGuid(), Name = "Nutty Hazelnut", Customer = "3 Squirrels", BagSize = BagSize._32oz, BagCount = 5, OrderTotal = 144.95m });
            orderGrid.DataSource = CoffeeData.Coffees;
        }
        private void RefreshData()
        {
            orderGrid.DataSource = null;
            orderGrid.DataSource = CoffeeData.Coffees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CoffeeData.Coffees.RemoveAt(orderGrid.CurrentRow.Index);
                RefreshData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
