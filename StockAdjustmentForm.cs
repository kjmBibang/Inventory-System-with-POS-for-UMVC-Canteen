using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Managers;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    public partial class StockAdjustmentForm : Form
    {
        private readonly Product product;
        private readonly StockManager stockManager;
        private readonly User _currentUser;

        public StockAdjustmentForm(Product product, User currentUser)
        {
            InitializeComponent();
            this.product = product;
            _currentUser = currentUser;

            // Initialize manager
            var stockRepo = RepositoryFactory.CreateStockRepository();
            var productRepo = RepositoryFactory.CreateProductRepository();
            var supplierRepo = RepositoryFactory.CreateSupplierRepository();
            stockManager = new StockManager(stockRepo,supplierRepo, productRepo);
        }

        private void StockAdjustmentForm_Load(object sender, EventArgs e)
        {
            lblProductPlaceholder.Text = product.productName;
            txtQuantity.Text = product.stock.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Parse new quantity
            if (!int.TryParse(txtQuantity.Text, out int newQuantity) || newQuantity < 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            int currentStock = product.stock;
            int difference = newQuantity - currentStock;

            if (difference == 0)
            {
                MessageBox.Show("Stock is unchanged.");
                return;
            }

            try
            {
                // Adjust stock through manager
                stockManager.AdjustStock(
                    productID: product.productID,
                    quantityChange: difference,
                    reason: "Manual Adjustment",
                    createdBy: _currentUser.userID
                );

                MessageBox.Show("Stock updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Adjustment Failed");
            }
        }
    }
}
