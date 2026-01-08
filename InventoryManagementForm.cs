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

        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }
    }
}
