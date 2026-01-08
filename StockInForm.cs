using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Managers;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    public partial class StockInForm : Form
    {
        User _currentUser;
        IStockRepository stockRepo;
        StockManager stockManager;
        int _productID;
        public StockInForm(int productID, User user)
        {
            InitializeComponent();

            var stockRepo = RepositoryFactory.CreateStockRepository();
            var supplierRepo = RepositoryFactory.CreateSupplierRepository();

            stockManager = new StockManager(stockRepo, supplierRepo);

            _productID = productID;
            _currentUser = user;
        }

        private void StockInForm_Load(object sender, EventArgs e)
        {
            var suppliers = stockManager.GetSuppliers();

            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStockIn.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            if (cmbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Please select a supplier.");
                return;
            }

            int supplierId = (int)cmbSupplier.SelectedValue;

            //try
            //{
                stockManager.StockIn(
                    productID: _productID,
                    quantity: quantity,
                    supplierId: supplierId,
                    createdBy: _currentUser.userID,
                    reason: "Stock In"
                );

                MessageBox.Show("Stock added successfully.");
                this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Stock In Failed");
            //}
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
