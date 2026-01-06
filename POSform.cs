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

namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    public partial class POSform : Form
    {
        private TextBox _activeTextBox;
        private IProductRepository productRepository = new MockDBProductRepository();//kung i change nimo ang repo i change pud sa ubos
        ITransactionRepository transactionRepository = new MockDBTransactionRepository();//kini i change pud, hand in hand sila
        private ProductManager productManager;
        private User currentUser;
        
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

            productManager = new ProductManager(productRepository);

            // suggestions hidden by default
            lstboxSuggestion.Visible = false;

            // events
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            lstboxSuggestion.DoubleClick += lstboxSuggestion_DoubleClick;

            //for quantity change
            dgvSales.SelectionChanged += dgvSales_SelectionChanged;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            btnEnterQuantity.Click += btnEnterQuantity_Click;

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
            NavigationHelper.GoBack(this, currentUser);
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
            productRepository.ReduceStock(barcode, quantity);

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
                Transaction transaction = BuildTransactionFromGrid();

                manager = new TransactionManager(transactionRepository);

                int transactionId = manager.ProcessTransaction(transaction);

                decimal change = cashReceived - total;

                MessageBox.Show($"Transaction #{transactionId} completed!\n\n" +
                               $"Total: ₱{total:0.00}\n" +
                               $"Cash: ₱{cashReceived:0.00}\n" +
                               $"Change: ₱{change:0.00}",
                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset everything for next customer
                ResetPOS();
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

            txtBarcode.Focus();
        }


        //==========================PRODUCT SEARCHING DIRI=============================================
        private void btnAdmin_Click(object sender, EventArgs e)
        {

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
                // Update stock
                if (diff > 0)
                {
                    // Check if enough stock is available
                    Product product = productRepository.LoadProductByBarcode(barcode);
                    if (product.stock < diff)
                    {
                        MessageBox.Show($"Not enough stock. Available: {product.stock}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Update DB stock
                productRepository.ReduceStock(barcode, diff);

                // Update row Tag
                dgvSales.CurrentRow.Tag = newQty;
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

        private void btnVoidIten_Click(object sender, EventArgs e)
        {
            // Check if already checked out
            if (isCheckedOut)
            {
                MessageBox.Show("Cannot void items after checkout. Use Refund instead.",
                                "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if a row is selected
            if (dgvSales.CurrentRow == null || dgvSales.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select an item to void.", "No Item Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get item details
            string barcode = dgvSales.CurrentRow.Cells["barcodeColumn"].Value.ToString();
            string productName = dgvSales.CurrentRow.Cells["productNameColumn"].Value.ToString();
            int quantity = Convert.ToInt32(dgvSales.CurrentRow.Cells["quantityColumn"].Value);

            // Confirm void action
            DialogResult result = MessageBox.Show(
                $"Void {quantity}x {productName}?\n\nThis will return the stock.",
                "Confirm Void Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Return stock to inventory
                productRepository.ReduceStock(barcode, -quantity); // negative to add back

                // Remove from grid
                dgvSales.Rows.Remove(dgvSales.CurrentRow);

                // Update total
                UpdateTotal();

                MessageBox.Show("Item voided successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnVoidTransaction_Click(object sender, EventArgs e)
        {
         
            // Check if cart is empty
            if (dgvSales.Rows.Count <= 1)
            {
                MessageBox.Show("Cart is already empty.", "Nothing to Void",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm void action
            DialogResult result = MessageBox.Show(
                "Void entire transaction?\n\nThis will return all items to stock and clear the cart.",
                "Confirm Void Transaction",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Return all stock
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    if (row.IsNewRow) continue;

                    string barcode = row.Cells["barcodeColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantityColumn"].Value);

                    // Return stock (negative quantity adds back)
                    productRepository.ReduceStock(barcode, -quantity);
                }

                // Clear everything
                ResetPOS();

                MessageBox.Show("Transaction voided. All items returned to stock.",
                                "Transaction Voided", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            // Block if currently in an active transaction
            if (dgvSales.Rows.Count > 1 && !isCheckedOut)
            {
                MessageBox.Show("Please complete or void the current transaction first.",
                                "Active Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prompt for transaction ID
            string input = PromptForTransactionID();

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (!int.TryParse(input, out int transactionId))
            {
                MessageBox.Show("Invalid transaction ID.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create manager with both repositories
                TransactionManager manager = new TransactionManager(transactionRepository, productRepository);

                // Get the transaction
                Transaction transaction = manager.GetTransactionById(transactionId);

                if (transaction == null)
                {
                    MessageBox.Show($"Transaction #{transactionId} not found.",
                                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if already refunded
                if (transaction.isRefunded)
                {
                    MessageBox.Show($"Transaction #{transactionId} has already been refunded on {transaction.refundDate:yyyy-MM-dd HH:mm}.",
                                    "Already Refunded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Show transaction details and confirm
                string itemsList = string.Join("\n",
                    transaction.items.Select(i => $"  {i.quantity}x {i.productName} - ₱{i.subTotal:0.00}"));

                DialogResult result = MessageBox.Show(
                    $"Refund Transaction #{transactionId}?\n\n" +
                    $"Date: {transaction.transactionDate:yyyy-MM-dd HH:mm}\n" +
                    $"Cashier: {transaction.cashierName}\n\n" +
                    $"Items:\n{itemsList}\n\n" +
                    $"Total: ₱{transaction.totalAmount:0.00}\n\n" +
                    $"This will return all items to stock.",
                    "Confirm Refund",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Process the refund through business layer
                    manager.ProcessRefund(transactionId, currentUser.username, productRepository);

                    MessageBox.Show(
                        $"Transaction #{transactionId} refunded successfully.\n\n" +
                        $"Amount: ₱{transaction.totalAmount:0.00}\n" +
                        $"All items returned to stock.",
                        "Refund Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Clear the current form if needed
                    if (isCheckedOut)
                    {
                        ResetPOS();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing refund: {ex.Message}",
                                "Refund Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to get transaction ID from user
        private string PromptForTransactionID()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter Transaction ID",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = "Transaction ID to refund:",
                Width = 350
            };

            TextBox textBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 340,
                Font = new Font("Arial", 12)
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 200,
                Width = 80,
                Top = 90,
                DialogResult = DialogResult.OK
            };

            Button cancel = new Button()
            {
                Text = "Cancel",
                Left = 290,
                Width = 80,
                Top = 90,
                DialogResult = DialogResult.Cancel
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
