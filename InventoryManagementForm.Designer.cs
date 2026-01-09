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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.productIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCriticalStock = new System.Windows.Forms.DataGridView();
            this.criticalProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticalStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockAdjustment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dgvStockMovement = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCriticalStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDColumn,
            this.productNameColumn,
            this.barcodeColumn,
            this.priceColumn,
            this.costPriceColumn,
            this.stockColumn,
            this.categoryColumn});
            this.dgvInventory.Location = new System.Drawing.Point(16, 58);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.Size = new System.Drawing.Size(924, 487);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // productIDColumn
            // 
            this.productIDColumn.HeaderText = "Product ID";
            this.productIDColumn.MinimumWidth = 6;
            this.productIDColumn.Name = "productIDColumn";
            this.productIDColumn.ReadOnly = true;
            this.productIDColumn.Width = 125;
            // 
            // productNameColumn
            // 
            this.productNameColumn.HeaderText = "Product Name";
            this.productNameColumn.MinimumWidth = 6;
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            this.productNameColumn.Width = 125;
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.HeaderText = "Barcode";
            this.barcodeColumn.MinimumWidth = 6;
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.ReadOnly = true;
            this.barcodeColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Unit Price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 125;
            // 
            // costPriceColumn
            // 
            this.costPriceColumn.HeaderText = "Unit Cost";
            this.costPriceColumn.MinimumWidth = 6;
            this.costPriceColumn.Name = "costPriceColumn";
            this.costPriceColumn.ReadOnly = true;
            this.costPriceColumn.Width = 125;
            // 
            // stockColumn
            // 
            this.stockColumn.HeaderText = "Stock";
            this.stockColumn.MinimumWidth = 6;
            this.stockColumn.Name = "stockColumn";
            this.stockColumn.ReadOnly = true;
            this.stockColumn.Width = 125;
            // 
            // categoryColumn
            // 
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.MinimumWidth = 6;
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.ReadOnly = true;
            this.categoryColumn.Width = 125;
            // 
            // dgvCriticalStock
            // 
            this.dgvCriticalStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriticalStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criticalProductNameColumn,
            this.criticalStockColumn});
            this.dgvCriticalStock.Location = new System.Drawing.Point(1401, 610);
            this.dgvCriticalStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCriticalStock.Name = "dgvCriticalStock";
            this.dgvCriticalStock.RowHeadersWidth = 51;
            this.dgvCriticalStock.Size = new System.Drawing.Size(452, 211);
            this.dgvCriticalStock.TabIndex = 4;
            // 
            // criticalProductNameColumn
            // 
            this.criticalProductNameColumn.HeaderText = "Product Name";
            this.criticalProductNameColumn.MinimumWidth = 6;
            this.criticalProductNameColumn.Name = "criticalProductNameColumn";
            this.criticalProductNameColumn.ReadOnly = true;
            this.criticalProductNameColumn.Width = 125;
            // 
            // criticalStockColumn
            // 
            this.criticalStockColumn.HeaderText = "Stock";
            this.criticalStockColumn.MinimumWidth = 6;
            this.criticalStockColumn.Name = "criticalStockColumn";
            this.criticalStockColumn.ReadOnly = true;
            this.criticalStockColumn.Width = 125;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.Location = new System.Drawing.Point(16, 557);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(251, 96);
            this.btnAddNewProduct.TabIndex = 12;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(16, 672);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(251, 96);
            this.btnUpdateProduct.TabIndex = 13;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.Location = new System.Drawing.Point(1075, 557);
            this.btnStockIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(251, 96);
            this.btnStockIn.TabIndex = 14;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(1075, 672);
            this.btnStockOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(251, 96);
            this.btnStockOut.TabIndex = 15;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockAdjustment
            // 
            this.btnStockAdjustment.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdjustment.Location = new System.Drawing.Point(1075, 786);
            this.btnStockAdjustment.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Size = new System.Drawing.Size(251, 96);
            this.btnStockAdjustment.TabIndex = 16;
            this.btnStockAdjustment.Text = "Stock Adjustment";
            this.btnStockAdjustment.UseVisualStyleBackColor = true;
            this.btnStockAdjustment.Click += new System.EventHandler(this.btnStockAdjustment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1680, 848);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 63);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(16, 786);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(251, 96);
            this.btnDeleteProduct.TabIndex = 18;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dgvStockMovement
            // 
            this.dgvStockMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockMovement.Location = new System.Drawing.Point(979, 58);
            this.dgvStockMovement.Name = "dgvStockMovement";
            this.dgvStockMovement.RowHeadersWidth = 51;
            this.dgvStockMovement.RowTemplate.Height = 24;
            this.dgvStockMovement.Size = new System.Drawing.Size(915, 487);
            this.dgvStockMovement.TabIndex = 19;
            this.dgvStockMovement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockMovement_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(327, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stock Movement";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCriticalStock
            // 
            this.lblCriticalStock.AutoSize = true;
            this.lblCriticalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCriticalStock.Location = new System.Drawing.Point(1506, 557);
            this.lblCriticalStock.Name = "lblCriticalStock";
            this.lblCriticalStock.Size = new System.Drawing.Size(229, 29);
            this.lblCriticalStock.TabIndex = 22;
            this.lblCriticalStock.Text = "Critical Stock Levels";
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1924, 922);
            this.Controls.Add(this.lblCriticalStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockMovement);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStockAdjustment);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.dgvCriticalStock);
            this.Controls.Add(this.dgvInventory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriticalStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockMovement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvCriticalStock;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgvStockMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticalProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticalStockColumn;
        private System.Windows.Forms.Label lblCriticalStock;
    }
}