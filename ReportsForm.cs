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
    public partial class ReportsForm : Form
    {
        ReportManager reportManager;
        
        User user;
        public ReportsForm(User user)
        {
            InitializeComponent();
            this.user = user;
            reportManager = new ReportManager(RepositoryFactory.CreateReportRepository());
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            SetupSalesByProductGrid();
            LoadSalesByProduct();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBackToDashboard(this, user);
        }

        private void dgvSalesByProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupSalesByProductGrid()
        {
            dgvSalesByProduct.Columns.Clear();
            dgvSalesByProduct.AutoGenerateColumns = false;

            dgvSalesByProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Barcode",
                DataPropertyName = "barcode",
                Width = 100
            });

            dgvSalesByProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Product Name",
                DataPropertyName = "productName",
                Width = 200
            });

            dgvSalesByProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Quantity Sold",
                DataPropertyName = "quantity",
                Width = 80
            });

            dgvSalesByProduct.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total Sales",
                DataPropertyName = "subTotal",
                Width = 100,
                //DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // currency format
            });
        }

        private void LoadSalesByProduct(DateTime? start = null, DateTime? end = null)
        {
            List<TransactionItem> sales;

            if (start.HasValue && end.HasValue)
                sales = reportManager.GetSalesByProductByDateRange(start.Value, end.Value); // manager handles repo internally
            else
                sales = reportManager.GetSalesByProductAllTime();

            dgvSalesByProduct.DataSource = sales;
        }

    }
}
