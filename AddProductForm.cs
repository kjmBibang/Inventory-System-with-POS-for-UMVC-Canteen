using Inventory_System_with_POS_for_UMVC_Canteen.Data;
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
    public partial class AddProductForm : Form
    {
        private IProductRepository productRepository;
        private ProductManager productManager;
        IStockRepository stockRepository;
        public AddProductForm()
        {

            InitializeComponent();
            stockRepository = RepositoryFactory.CreateStockRepository();
            productRepository = RepositoryFactory.CreateProductRepository();
            productManager = new ProductManager(productRepository,stockRepository);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int categoryId;
            //MessageBox.Show($"CategoryID = {categoryId}");
            try
            {
                 categoryId = productManager.GetOrCreateCategory(txtCategory.Text.Trim());

                // Change the Product instantiation to use the constructor with required parameters
                Product product = new Product
                {
                    productName = txtProductName.Text.Trim(),
                    productBarcode = txtBarcode.Text.Trim(),
                    unitPrice = decimal.Parse(txtPrice.Text),
                    unitCost = decimal.Parse(txtCost.Text),
                    stock = 0,
                    categoryID = categoryId,
                    categoryName = txtCategory.Text.Trim()
                };


                productManager.AddProduct(product);

                MessageBox.Show("Product added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
