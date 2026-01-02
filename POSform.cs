using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
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
        


        private void btnNumber1_Click(object sender, EventArgs e)
        {
            
               
            
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            
               
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            
              
            
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            
               
            
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            
               
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            
              
            
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        
            if (_activeTextBox == null) return;

            _activeTextBox.Text = "0";
        

    }

        private void DGVSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblQuantity_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCashierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
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

         IServerHelper serverHelper = new SQLHelper();
        private void ReduceStock(string barcode)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
        UPDATE Products
        SET Stock = Stock - 1
        WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadProductByBarcode(string barcode)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
        SELECT Barcode, ProductName, Price, Stock
        FROM Products
        WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int stock = Convert.ToInt32(reader["Stock"]);

                            if (stock <= 0)
                            {
                                MessageBox.Show("Out of stock");
                                return;
                            }

                            // add to grid
                            AddProductToGrid(
                                reader["Barcode"].ToString(),
                                reader["ProductName"].ToString(),
                                Convert.ToDecimal(reader["Price"])
                            );

                            // reduce stock
                            ReduceStock(barcode);
                        }
                        else
                        {
                            MessageBox.Show("Product not found");
                        }
                    }
                }
            }
        }
    }
}
