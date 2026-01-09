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
        private TransactionManager transactionManager;
        User user;
        public ReportsForm(User user)
        {
            InitializeComponent();
            this.user = user;
            reportManager = new ReportManager(RepositoryFactory.CreateReportRepository());
            transactionManager = new TransactionManager(RepositoryFactory.CreateTransactionRepository(),RepositoryFactory.CreateProductRepository(),RepositoryFactory.CreateStockRepository());


        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            SetupSalesByProductGrid();
            LoadSalesByProduct();
            SetupTodaySalesGrid();
            LoadTodaySales();
            SetupTransactionHistoryGrid();
            LoadTransactionHistory();
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

        private void dgvTodaySale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupTodaySalesGrid()
        {
            dgvTodaySale.Columns.Clear();
            dgvTodaySale.AutoGenerateColumns = false;

            dgvTodaySale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Date",
                DataPropertyName = "transactionDate",
                Width = 90
            });

            dgvTodaySale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Barcode",
                DataPropertyName = "barcode",
                Width = 100
            });

            dgvTodaySale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Product Name",
                DataPropertyName = "productName",
                Width = 200
            });

            dgvTodaySale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Qty Sold",
                DataPropertyName = "quantity",
                Width = 80
            });

            dgvTodaySale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total Sales",
                DataPropertyName = "subTotal",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }
        private void LoadTodaySales()
        {
            dgvTodaySale.DataSource = reportManager.GetSalesByProductToday();
        }

        private void dgvTransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupTransactionHistoryGrid()
        {
            dgvTransactionHistory.Columns.Clear();
            dgvTransactionHistory.AutoGenerateColumns = false;

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Transaction ID",
                DataPropertyName = "transactionID",
                Width = 90
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Date",
                DataPropertyName = "transactionDate",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cashier",
                DataPropertyName = "cashierName",
                Width = 140
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total Amount",
                DataPropertyName = "totalAmount",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Status",
                DataPropertyName = "status",
                Width = 100
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Approved By",
                DataPropertyName = "approvedBy",
                Width = 120
            });

            dgvTransactionHistory.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Status Changed At",
                DataPropertyName = "statusChangedAt",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm" }
            });
        }
        

        private void LoadTransactionHistory()
        {
            dgvTransactionHistory.DataSource = transactionManager.GetTransactionHistory();
        }

    }
}
