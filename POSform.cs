using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Managers;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_System_with_POS_for_UMVC_Canteen.Factories;

namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    public partial class POSform : Form
    {
        private TextBox _activeTextBox;
        private IProductRepository productRepository = RepositoryFactory.CreateProductRepository();//kung i change nimo ang repo i change pud sa ubos
        ITransactionRepository transactionRepository = RepositoryFactory.CreateTransactionRepository();//kini i change pud, hand in hand sila
        private ProductManager productManager;
        IStockRepository stockRepository = RepositoryFactory.CreateStockRepository();
        private User currentUser;
        private bool adminAuthorized = false; // per-transaction admin approval
        private Transaction currentTransaction; // tracks the current transaction in memory
        private User approvingAdmin = null; // store admin user who authorized this transaction


        TransactionManager manager;
        // Add these fields at the top of your class (near _activeTextBox and productRepository)
        private bool isCheckedOut = false;
        private decimal cashReceived = 0;
        private void TextBox_Enter(object sender, EventArgs e)
        {
            _activeTextBox = sender as TextBox;
        }

        public POSform(User user)
        {
            InitializeComponent();
            currentUser = user; // store user for later use
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            txtBarcode.KeyDown += txtBarcode_KeyDown; //mao ni need for txtBarcode_keydown()

            // instantiate manager once for the form lifetime
            manager = new TransactionManager(transactionRepository, productRepository,stockRepository);

            // initialize an empty in-memory transaction for the new session
            currentTransaction = new Transaction(
                transactionID: 0,
                transactionDate: DateTime.Now,
                totalAmount: 0m,
                items: new List<TransactionItem>(),
                cashierName: user?.username ?? string.Empty
            );

            txtBarcode.Enter += TextBox_Enter;
            txtQuantity.Enter += TextBox_Enter;
            txtTotal.Enter += TextBox_Enter;
            txtCash.Enter += TextBox_Enter;
            txtChange.Enter += TextBox_Enter;

            btnNumber0.Click += NumberButton_Click;
            btnNumber1.Click += NumberButton_Click;
            btnNumber2.Click += NumberButton_Click;
            btnNumber3.Click += NumberButton_Click;
            btnNumber4.Click += NumberButton_Click;
            btnNumber5.Click += NumberButton_Click;
            btnNumber6.Click += NumberButton_Click;
            btnNumber7.Click += NumberButton_Click;
            btnNumber8.Click += NumberButton_Click;
            btnNumber9.Click += NumberButton_Click;
            btnDecimal.Click += NumberButton_Click;
            btnClear.Click += btnClear_Click;
            lblCashierName.Text = user.username;

            btnPay.Enabled = false;
            txtCash.Enabled = false;

            productManager = new ProductManager(productRepository, stockRepository);

            // suggestions hidden by default
            lstboxSuggestion.Visible = false;

            // events
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            lstboxSuggestion.DoubleClick += lstboxSuggestion_DoubleClick;

            //for quantity change
            dgvSales.SelectionChanged += dgvSales_SelectionChanged;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            btnEnterQuantity.Click += btnEnterQuantity_Click;

            InitializeAdminState();

        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            txtBarcode.Text = "0";
            txtQuantity.Text = "0";
            txtTotal.Text = "0";
            txtCash.Text = "0";
            txtChange.Text = "0";

        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (_activeTextBox == null) return;

            Button btn = sender as Button;
            if (btn == null) return;

            string input = btn.Text;

            if (input == ".")
            {
                if (!_activeTextBox.Text.Contains("."))
                    _activeTextBox.Text += ".";
            }
            else
            {
                if (_activeTextBox.Text == "0")
                    _activeTextBox.Text = input;
                else
                    _activeTextBox.Text += input;
            }
        }
        private void btnNumber1_Click(object sender, EventArgs e) { }

        private void btnNumber2_Click(object sender, EventArgs e) { }
        private void btnNumber3_Click(object sender, EventArgs e) { }

        private void btnNumber4_Click(object sender, EventArgs e) { }

        private void btnNumber5_Click(object sender, EventArgs e) { }

        private void btnNumber6_Click(object sender, EventArgs e) { }

        private void btnNumber7_Click(object sender, EventArgs e) { }

        private void btnNumber8_Click(object sender, EventArgs e) { }

        private void btnNumber9_Click(object sender, EventArgs e) { }

        private void btnNumber0_Click(object sender, EventArgs e) { }

        private void txtBarcode_TextChanged(object sender, EventArgs e) { }

        private void txtQuantity_TextChanged(object sender, EventArgs e) { }

        private void txtTotal_TextChanged(object sender, EventArgs e) { }

        private void txtChange_TextChanged(object sender, EventArgs e) { }
        private void DGVSales_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lblQuantity_TextChanged(object sender, EventArgs e) { }


        private void lblTotal_TextChanged(object sender, EventArgs e) { }

        private void lblCash_TextChanged(object sender, EventArgs e) { }

        private void lblCashierName_TextChanged(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigationHelper.GoBackToDashboard(this, currentUser);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (_activeTextBox == null) return;

            _activeTextBox.Text = "0";


        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)// stores barcode as string when user enters
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstboxSuggestion.Visible = false;

                string barcode = txtBarcode.Text.Trim();
                LoadProductByBarcode(barcode);

                e.SuppressKeyPress = true;
            }
        }

        // In AddProductToGrid, initialize row Tag with the quantity
        private void AddProductToGrid(string barcode, string productName, decimal price)
        {
            int quantity = 1;
            decimal subtotal = price * quantity;

            var rowIndex = dgvSales.Rows.Add(barcode, productName, price, quantity, subtotal);

            // Store the quantity already deducted from stock in the Tag
            dgvSales.Rows[rowIndex].Tag = quantity;

            // Reduce stock in DB
            stockRepository.ReduceStockByBarcode(barcode, quantity);

            // ADD TO currentTransaction
            currentTransaction.items.Add(new TransactionItem(
                transactionItemID: 0,
                transactionID: 0,
                productID: 0,
                unitPrice: price,
                quantity: quantity,
                subTotal: subtotal,
                barcode: barcode,
                productName: productName
            ));

            UpdateTotal();
        }


        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells["subtotalColumn"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotalColumn"].Value);
                }
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void LoadProductByBarcode(string barcode)
        {
            Product product = productRepository.LoadProductByBarcode(barcode);

            if (product == null)
            {
                MessageBox.Show("Product not found");
                return;
            }

            if (product.stock <= 0)
            {
                MessageBox.Show("Out of stock");
                return;
            }

            // add to grid
            AddProductToGrid(
                product.productBarcode,
                product.productName,
                product.unitPrice
            );

            // reduce stock
            //productRepository.ReduceStock(barcode);
        }      
        private void lblTransactionIDPlaceholder_Click(object sender, EventArgs e)
        {

        }

        //=================trasnsaction ni diri na flow, subject to change===============

        

        private Transaction BuildTransactionFromGrid()
        {
            var items = new List<TransactionItem>();

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;

                items.Add(new TransactionItem(
                    transactionItemID: 0,
                    transactionID: 0,
                    productID: 0,
                    unitPrice: Convert.ToDecimal(row.Cells["unitPriceColumn"].Value),
                    quantity: Convert.ToInt32(row.Cells["quantityColumn"].Value),
                    subTotal: Convert.ToDecimal(row.Cells["subtotalColumn"].Value),
                    barcode: row.Cells["barcodeColumn"].Value.ToString(),
                    productName: row.Cells["productNameColumn"].Value.ToString()
                ));
            }

            return new Transaction(
                transactionID: 0,
                transactionDate: DateTime.Now,
                totalAmount: items.Sum(i => i.subTotal),
                items,
                cashierName: lblCashierName.Text
            );
        }

      private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Check if cart is empty
            if (dgvSales.Rows.Count <= 1) // only the new row exists
            {
                MessageBox.Show("Cart is empty! Scan items first.", "Cannot Checkout",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lock the cart
            isCheckedOut = true;
            dgvSales.ReadOnly = true;
            txtBarcode.Enabled = false;
            txtBarcode.Text = "0";

            // Calculate and display total
            decimal total = 0;
            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["subtotalColumn"].Value);
            }
            txtTotal.Text = total.ToString("0.00");

            // Enable cash entry
            txtCash.Enabled = true;
            txtCash.Text = "0";
            txtCash.Focus();

            MessageBox.Show($"Total: ₱{total:0.00}\n\nEnter cash amount received.",
                            "Ready for Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // STEP 2: Calculate change when cash is entered
        // UPDATE your existing txtCash_TextChanged method with this code
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (!isCheckedOut) return;

            if (decimal.TryParse(txtCash.Text, out decimal cash))
            {
                cashReceived = cash;
                decimal total = Convert.ToDecimal(txtTotal.Text);
                decimal change = cash - total;

                txtChange.Text = change.ToString("0.00");

                // Enable PAY button only if cash is enough
                btnPay.Enabled = (cash >= total);
            }
            else
            {
                txtChange.Text = "0.00";
                btnPay.Enabled = false;
            }
        }

        // STEP 3: PAY - Save transaction
        // REPLACE your existing btnPay_Click with this
        private void btnPay_Click(object sender, EventArgs e)
        {
            
            // Safety check #1: Must checkout first
            if (!isCheckedOut)
            {
                MessageBox.Show("Please press CHECKOUT first!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Safety check #2: Validate cash amount
            decimal total = Convert.ToDecimal(txtTotal.Text);
            if (cashReceived < total)
            {
                MessageBox.Show($"Insufficient cash!\n\nTotal: ₱{total:0.00}\nCash: ₱{cashReceived:0.00}\nShort: ₱{(total - cashReceived):0.00}",
                                "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Process the transaction
            try
            {
                currentTransaction = BuildTransactionFromGrid();
                manager = new TransactionManager(transactionRepository, productRepository,stockRepository);
                int transactionId = manager.ProcessTransaction(currentTransaction);
                currentTransaction.transactionID = transactionId; // store ID for void/refund


                
                decimal change = cashReceived - total;

                MessageBox.Show($"Transaction #{transactionId} completed!\n\n" +
                               $"Total: ₱{total:0.00}\n" +
                               $"Cash: ₱{cashReceived:0.00}\n" +
                               $"Change: ₱{change:0.00}",
                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset everything for next customer
                //ResetPOS();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to reset the POS for next transaction
        private void ResetPOS()
        {
            dgvSales.Rows.Clear();
            txtBarcode.Text = "0";
            txtQuantity.Text = "0";
            txtTotal.Text = "0";
            txtCash.Text = "0";
            txtChange.Text = "0";

            isCheckedOut = false;
            cashReceived = 0;

            dgvSales.ReadOnly = false;
            txtBarcode.Enabled = true;
            txtCash.Enabled = false;
            btnPay.Enabled = false;
            adminAuthorized = (currentUser.roleID == 1);
            UpdateAdminUI();

            // Recreate a fresh empty transaction for next customer
            currentTransaction = new Transaction(
                transactionID: 0,
                transactionDate: DateTime.Now,
                totalAmount: 0m,
                items: new List<TransactionItem>(),
                cashierName: lblCashierName.Text
            );

            txtBarcode.Focus();
        }


        //==========================PRODUCT SEARCHING DIRI=============================================
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Already authorized? Do nothing
            if (adminAuthorized)
                return;

            // Only cashiers need approval
            if (currentUser.roleID == 2)
            {
                using (var authForm = new AdminAuthorizationForm())
                {
                    if (authForm.ShowDialog() == DialogResult.OK)
                    {
                        if (authForm.AuthorizedAdmin != null && authForm.AuthorizedAdmin.roleID == 1)
                        {
                            adminAuthorized = true;
                            approvingAdmin = authForm.AuthorizedAdmin; // <-- store admin user
                            UpdateAdminUI();

                            MessageBox.Show(
                                "Admin authorization granted for this transaction.",
                                "Authorized",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }

                    }
                    else
                        {
                            MessageBox.Show(
                                "Invalid admin credentials.",
                                "Authorization Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            

        }

        private void button1_Click(object sender, EventArgs e)//btnEnterQuantity ni
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtSearchbar ni
        {
            
        }
        
        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchbar.Text.Trim();

            if (keyword.Length < 2)
            {
                lstboxSuggestion.Visible = false;
                return;
            }

            var results = productManager.SearchProducts(keyword);

            if (results.Count == 0)
            {
                lstboxSuggestion.Visible = false;
                return;
            }

            lstboxSuggestion.DataSource = results;
            lstboxSuggestion.DisplayMember = "productName";
            lstboxSuggestion.ValueMember = "productBarcode";
            lstboxSuggestion.Visible = true;
        }
        
        private void lstboxSuggestion_DoubleClick(object sender, EventArgs e)
        {
            if (lstboxSuggestion.SelectedItem is Product product)
            {
                AddProductToGrid(
                    product.productBarcode,
                    product.productName,
                    product.unitPrice
                );

                txtSearchbar.Clear();
                lstboxSuggestion.Visible = false;
            }
        }
        //=======================QUANTITY BUTTON ni diri======================
        // [UI] – populate txtQuantity when row selected
        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSales.CurrentRow != null && !dgvSales.CurrentRow.IsNewRow)
            {
                txtQuantity.Text = dgvSales.CurrentRow.Cells["quantityColumn"].Value.ToString();
                txtQuantity.Focus();
            }
        }
        // [UI] – update selected row quantity from txtQuantity
        private void btnEnterQuantity_Click(object sender, EventArgs e)
        {
            UpdateSelectedRowQuantity();
        }
        // [UI] – Enter key in txtQuantity updates quantity
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateSelectedRowQuantity();
                e.SuppressKeyPress = true; // prevent beep
            }
        }
        // [UI] – helper method
        private void UpdateSelectedRowQuantity()
        {
            if (dgvSales.CurrentRow == null || dgvSales.CurrentRow.IsNewRow) return;

            if (!int.TryParse(txtQuantity.Text.Trim(), out int newQty) || newQty <= 0)
            {
                MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oldQty = dgvSales.CurrentRow.Tag != null ? (int)dgvSales.CurrentRow.Tag : 0;
            string barcode = dgvSales.CurrentRow.Cells["barcodeColumn"].Value.ToString();

            int diff = newQty - oldQty; // positive = add more, negative = reduce

            if (diff != 0)
            {
                // Check if enough stock is available
                if (diff > 0)
                {
                    Product product = productRepository.LoadProductByBarcode(barcode);
                    if (product.stock < diff)
                    {
                        MessageBox.Show($"Not enough stock. Available: {product.stock}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Update DB stock
                stockRepository.ReduceStockByBarcode(barcode, diff);

                // Update row Tag
                dgvSales.CurrentRow.Tag = newQty;

                // Update currentTransaction item
                var item = currentTransaction.items.FirstOrDefault(i => i.barcode == barcode);
                if (item != null)
                {
                    item.quantity = newQty;
                    item.subTotal = newQty * item.unitPrice;
                }
            }

            // Update quantity cell
            dgvSales.CurrentRow.Cells["quantityColumn"].Value = newQty;

            // Recalculate subtotal
            decimal unitPrice = Convert.ToDecimal(dgvSales.CurrentRow.Cells["unitPriceColumn"].Value);
            dgvSales.CurrentRow.Cells["subtotalColumn"].Value = unitPrice * newQty;

            // Update total
            UpdateTotal();

            txtBarcode.Focus();
        }

        private void lstboxSuggestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //==================================VOID REFUN PROCESS AND ADMIN AUTHORIZATION============================
        //nasa line 412 ang btnAdmin_Click()
        private void InitializeAdminState()
        {
            if (currentUser.roleID == 1)
            {
                adminAuthorized = true;
                approvingAdmin = currentUser; // <-- auto store
            }
            UpdateAdminUI();
        }
        private void UpdateAdminUI()
        {
            if (adminAuthorized)
            {
                btnAdmin.ForeColor = Color.Green;
                btnAdmin.Text = "ADMIN MODE";

                btnVoidItem.Enabled = true;
                btnVoidTransaction.Enabled = true;
                btnRefund.Enabled = true;
            }
            else
            {
                btnAdmin.ForeColor = Color.Red;
                btnAdmin.Text = "ADMIN REQUIRED";

                btnVoidItem.Enabled = false;
                btnVoidTransaction.Enabled = false;
                btnRefund.Enabled = false;
            }
        }
        
        private void btnVoidItem_Click(object sender, EventArgs e)
        {
            if (!adminAuthorized)
            {
                MessageBox.Show("Admin approval required.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvSales.CurrentRow == null || dgvSales.CurrentRow.IsNewRow) return;

            string barcode = dgvSales.CurrentRow.Cells["barcodeColumn"].Value.ToString();
            var item = currentTransaction.items.FirstOrDefault(i => i.barcode == barcode);

            if (item != null)
            {
                manager.VoidItem(currentTransaction, item, approvingAdmin);

                dgvSales.Rows.Remove(dgvSales.CurrentRow);
                UpdateTotal();

                MessageBox.Show($"Item {item.productName} voided.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (!adminAuthorized)
            {
                MessageBox.Show("Admin approval required.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentTransaction == null)
            {
                MessageBox.Show("No transaction to refund.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            manager.RefundTransaction(currentTransaction, approvingAdmin);

            dgvSales.Rows.Clear();
            UpdateTotal();

            MessageBox.Show("Transaction refunded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetPOS();
        }

        private void btnVoidTransaction_Click(object sender, EventArgs e)
        {
            if (!adminAuthorized)
            {
                MessageBox.Show("Admin approval required.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentTransaction == null)
            {
                MessageBox.Show("No transaction to void.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            manager.VoidTransaction(currentTransaction, approvingAdmin);

            dgvSales.Rows.Clear();
            UpdateTotal();

            MessageBox.Show("Transaction voided.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetPOS();
        }


        //========================================Reciept Printing============================================

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (currentTransaction == null || currentTransaction.transactionID == 0)
            {
                MessageBox.Show("No completed transaction to print.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Option 1: Show in dialog
                ShowReceiptDialog();

                // Option 2: Copy to clipboard (uncomment if needed)
                // Clipboard.SetText(GenerateReceiptString());
                // MessageBox.Show("Receipt copied to clipboard!", "Success");

                // Option 3: Save to file (uncomment if needed)
                // string filePath = $"Receipt_{currentTransaction.transactionID}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                // File.WriteAllText(filePath, GenerateReceiptString());
                // MessageBox.Show($"Receipt saved to: {filePath}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetPOS();
        }
        private string GenerateReceiptString()
        {
            StringBuilder receipt = new StringBuilder();

            // Header
            receipt.AppendLine("========================================");
            receipt.AppendLine("     UMVC CANTEEN - RECEIPT");
            receipt.AppendLine("========================================");
            receipt.AppendLine();

            // Transaction Details
            receipt.AppendLine($"Transaction ID: {currentTransaction.transactionID}");
            receipt.AppendLine($"Date: {currentTransaction.transactionDate:yyyy-MM-dd HH:mm:ss}");
            receipt.AppendLine($"Cashier: {lblCashierName.Text}");

            // Admin approval if applicable
            if (adminAuthorized && approvingAdmin != null && currentUser.roleID == 2)
            {
                receipt.AppendLine($"Approved by: {approvingAdmin.username}");
            }

            receipt.AppendLine("========================================");
            receipt.AppendLine();

            // Items Header
            receipt.AppendLine("ITEMS:");
            receipt.AppendLine("----------------------------------------");
            receipt.AppendLine(string.Format("{0,-25} {1,5} {2,8}", "Product", "Qty", "Amount"));
            receipt.AppendLine("----------------------------------------");

            // Items List
            foreach (var item in currentTransaction.items)
            {
                string productName = item.productName.Length > 25
                    ? item.productName.Substring(0, 22) + "..."
                    : item.productName;

                receipt.AppendLine(string.Format("{0,-25} x{1,3} {2,8:F2}",
                    productName,
                    item.quantity,
                    item.subTotal));
            }

            receipt.AppendLine("----------------------------------------");
            receipt.AppendLine();

            // Totals
            decimal total = currentTransaction.totalAmount;
            decimal cash = cashReceived;
            decimal change = cash - total;

            receipt.AppendLine(string.Format("{0,-30} {1,8:F2}", "SUBTOTAL:", total));
            receipt.AppendLine(string.Format("{0,-30} {1,8:F2}", "TOTAL:", total));
            receipt.AppendLine();
            receipt.AppendLine(string.Format("{0,-30} {1,8:F2}", "CASH:", cash));
            receipt.AppendLine(string.Format("{0,-30} {1,8:F2}", "CHANGE:", change));

            receipt.AppendLine();
            receipt.AppendLine("========================================");
            receipt.AppendLine("       Thank you for your purchase!");
            receipt.AppendLine("========================================");

            return receipt.ToString();
        }

        // Optional: Method to display receipt in a dialog
        private void ShowReceiptDialog()
        {
            string receiptText = GenerateReceiptString();

            Form receiptForm = new Form();
            receiptForm.Text = "Receipt Preview";
            receiptForm.Size = new Size(500, 600);
            receiptForm.StartPosition = FormStartPosition.CenterParent;

            TextBox receiptTextBox = new TextBox();
            receiptTextBox.Multiline = true;
            receiptTextBox.ScrollBars = ScrollBars.Vertical;
            receiptTextBox.Font = new Font("Courier New", 10);
            receiptTextBox.Text = receiptText;
            receiptTextBox.ReadOnly = true;
            receiptTextBox.Dock = DockStyle.Fill;

            receiptForm.Controls.Add(receiptTextBox);
            receiptForm.ShowDialog();
        }
        

        
    }
}
