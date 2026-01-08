using Inventory_System_with_POS_for_UMVC_Canteen.Data;
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
    public partial class InventoryManagementForm : Form
    {
        User currentUser;
        IProductRepository productRepository;
        ProductManager manager;

        public InventoryManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            productRepository = new SQLProductRepository();
            manager = new ProductManager(productRepository);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        
        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            dgvInventory.AutoGenerateColumns = false;
            productIDColumn.DataPropertyName = "ProductID";
            productNameColumn.DataPropertyName = "ProductName";
            barcodeColumn.DataPropertyName = "productBarcode";
            priceColumn.DataPropertyName = "unitPrice";
            costPriceColumn.DataPropertyName = "unitCost";
            stockColumn.DataPropertyName = "Stock";
            categoryColumn.DataPropertyName = "CategoryName";
            criticalProductNameColumn.DataPropertyName = "ProductName";
            criticalStockColumn.DataPropertyName = "Stock";
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.MultiSelect = false;


            LoadInventory();
            LoadCriticalStock();            
        }
        private void LoadCriticalStock()
        {
            var criticalItems = manager.GetCriticalStock(20);

            dgvCriticalStock.AutoGenerateColumns = false;
            dgvCriticalStock.DataSource = criticalItems;
        }

        private void LoadInventory()
        {
            
            dgvInventory.DataSource = manager.LoadInventory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBackToDashboard(this, currentUser);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            DataGridViewRow row = dgvInventory.SelectedRows[0];

            int productId = Convert.ToInt32(row.Cells["productIDColumn"].Value);
            string productName = row.Cells["productNameColumn"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete '{productName}'?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                manager.DeleteProduct(productId);
                MessageBox.Show("Product deleted successfully.");

                // refresh inventory grid
                dgvInventory.DataSource = manager.LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                addProductForm.ShowDialog(); // BLOCKS until closed
            }

            LoadInventory();
            LoadCriticalStock();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            DataGridViewRow row = dgvInventory.CurrentRow;

            Product product = new Product
            {
                productID = Convert.ToInt32(row.Cells["productIDColumn"].Value),
                productName = row.Cells["productNameColumn"].Value.ToString(),
                productBarcode = row.Cells["barcodeColumn"].Value.ToString(),
                unitPrice = Convert.ToDecimal(row.Cells["priceColumn"].Value),
                unitCost = Convert.ToDecimal(row.Cells["costPriceColumn"].Value),
                stock = Convert.ToInt32(row.Cells["stockColumn"].Value),
                categoryName = row.Cells["categoryColumn"].Value.ToString()
            };

            UpdateProductForm form = new UpdateProductForm(product);
            form.ShowDialog();

            // refresh after update
            LoadInventory();
            LoadCriticalStock();
        }

        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            manager.LoadInventory();
        }
    }
}
