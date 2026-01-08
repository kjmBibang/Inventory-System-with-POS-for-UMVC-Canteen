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
    public partial class UpdateProductForm : Form
    {
        private IProductRepository productRepository;
        private ProductManager productManager;
        private Product _product;
        IStockRepository stockRepository;
        public UpdateProductForm(Product product)
        {
            InitializeComponent();
            _product = product;
            stockRepository = RepositoryFactory.CreateStockRepository();
            productRepository = RepositoryFactory.CreateProductRepository();
            productManager = new ProductManager(productRepository,stockRepository);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryId = productManager.GetOrCreateCategory(txtCategory.Text.Trim());

                _product.productName = txtProductName.Text.Trim();
                _product.productBarcode = txtBarcode.Text.Trim();
                _product.unitPrice = decimal.Parse(txtPrice.Text);
                _product.unitCost = decimal.Parse(txtCost.Text);
                _product.categoryID = categoryId;

                productManager.UpdateProduct(_product);

                MessageBox.Show("Product updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            txtProductName.Text = _product.productName;
            txtBarcode.Text = _product.productBarcode;
            txtPrice.Text = _product.unitPrice.ToString("0.00");
            txtCost.Text = _product.unitCost.ToString("0.00");
            txtCategory.Text = _product.categoryName;
        }
    }
}
