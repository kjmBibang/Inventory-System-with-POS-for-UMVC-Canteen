using Inventory_System_with_POS_for_UMVC_Canteen.Factories;
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
    public partial class StockOutForm : Form
    {
        Product currentProduct;
        StockManager stockManager;
        ISupplierRepository supplierRepository;
        IStockRepository stockRepository;
        IProductRepository productRepository;
        User _currentUser;
        public StockOutForm(Product product, User user)
        {
            InitializeComponent();
            currentProduct = product;
            productRepository = RepositoryFactory.CreateProductRepository();
            stockRepository = RepositoryFactory.CreateStockRepository();
            supplierRepository = RepositoryFactory.CreateSupplierRepository();
            stockManager = new StockManager(stockRepository, supplierRepository, productRepository);
            _currentUser = user;
        }

        private void grboxForStockOut_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//txtOtherReason
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtQuantity
        {

        }

        private void rdBtnOtherReason_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnExpired_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnDestroyed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {

            lblProductPlaceholder.Text = currentProduct.productName ?? "Unknown Product";
        }

        private void lblStockOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }



            //try
            //{
                // Subtract stock
                stockManager.StockOut(
                    productID: currentProduct.productID,
                    quantity: quantity,
                    reason: StockMovementType.StockOut.ToString(),
                    createdBy: _currentUser.userID
                );

                MessageBox.Show("Stock removed successfully.");
                this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Stock Out Failed");
            //}
        }
    }
}
