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
        private SQLProductRepository productRepository;

        private void TextBox_Enter(object sender, EventArgs e)
        {
            _activeTextBox = sender as TextBox;
        }

        public POSform(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            txtBarcode.KeyDown += txtBarcode_KeyDown; //mao ni need for txtBarcode_keydown()

            productRepository = new SQLProductRepository();

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

        private void btnBack_Click(object sender, EventArgs e) { }
        private void btnClear_Click(object sender, EventArgs e)
        {

            if (_activeTextBox == null) return;

            _activeTextBox.Text = "0";


        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)// stores barcode as string when user enters
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();
                LoadProductByBarcode(barcode);
                e.SuppressKeyPress = true; // prevents beep
            }
        }

        private void AddProductToGrid(string barcode, string productName, decimal price)
        {
            int quantity = 1;
            decimal subtotal = price * quantity;

            dgvSales.Rows.Add(
                barcode,          // Barcode column
                productName,      // Product column
                price,            // Price column
                quantity,         // Quantity column
                subtotal          // Subtotal column
            );

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
            productRepository.ReduceStock(barcode);
        }      
        private void lblTransactionIDPlaceholder_Click(object sender, EventArgs e)
        {

        }

        //=================trasnsaction ni diri na flow, subject to change===============

        // Add these fields at the top of your class (near _activeTextBox and productRepository)
        private bool isCheckedOut = false;
        private decimal cashReceived = 0;

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

                ITransactionRepository repo = new SQLTransactionRepository();
                TransactionManager manager = new TransactionManager(repo);

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

       
    }
}
