namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class InventoryManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtvInventory = new System.Windows.Forms.DataGridView();
            this.DtvCriticalStock = new System.Windows.Forms.DataGridView();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockAdjustment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvCriticalStock)).BeginInit();
            this.SuspendLayout();
            // 
            // DtvInventory
            // 
            this.DtvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvInventory.Location = new System.Drawing.Point(12, 12);
            this.DtvInventory.Name = "DtvInventory";
            this.DtvInventory.Size = new System.Drawing.Size(1346, 431);
            this.DtvInventory.TabIndex = 0;
            // 
            // DtvCriticalStock
            // 
            this.DtvCriticalStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvCriticalStock.Location = new System.Drawing.Point(12, 449);
            this.DtvCriticalStock.Name = "DtvCriticalStock";
            this.DtvCriticalStock.Size = new System.Drawing.Size(362, 288);
            this.DtvCriticalStock.TabIndex = 4;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(505, 466);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(188, 78);
            this.btnAddNewProduct.TabIndex = 12;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(505, 562);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(188, 78);
            this.btnUpdateProduct.TabIndex = 13;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnStockIn
            // 
            this.btnStockIn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.Location = new System.Drawing.Point(710, 466);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(188, 78);
            this.btnStockIn.TabIndex = 14;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            // 
            // btnStockOut
            // 
            this.btnStockOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(710, 562);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(188, 78);
            this.btnStockOut.TabIndex = 15;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            // 
            // btnStockAdjustment
            // 
            this.btnStockAdjustment.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdjustment.Location = new System.Drawing.Point(710, 659);
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Size = new System.Drawing.Size(188, 78);
            this.btnStockAdjustment.TabIndex = 16;
            this.btnStockAdjustment.Text = "Stock Adjustment";
            this.btnStockAdjustment.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1260, 687);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 51);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStockAdjustment);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.DtvCriticalStock);
            this.Controls.Add(this.DtvInventory);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvCriticalStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtvInventory;
        private System.Windows.Forms.DataGridView DtvCriticalStock;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnBack;
    }
}