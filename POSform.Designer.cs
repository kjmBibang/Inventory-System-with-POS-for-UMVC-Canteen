namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class POSform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSform));
            this.picboxUMLOGO = new System.Windows.Forms.PictureBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInvertory = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.TextBox();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnVoidIten = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.CashierOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTransactionIDPlaceholder = new System.Windows.Forms.Label();
            this.btnEnterQuantity = new System.Windows.Forms.Button();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.lstboxSuggestion = new System.Windows.Forms.ListBox();
            this.picboxUSER = new System.Windows.Forms.PictureBox();
            this.lblCashierName = new System.Windows.Forms.TextBox();
            this.lblTransactionID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxUMLOGO
            // 
            this.picboxUMLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picboxUMLOGO.Image")));
            this.picboxUMLOGO.Location = new System.Drawing.Point(22, 33);
            this.picboxUMLOGO.Name = "picboxUMLOGO";
            this.picboxUMLOGO.Size = new System.Drawing.Size(80, 70);
            this.picboxUMLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUMLOGO.TabIndex = 2;
            this.picboxUMLOGO.TabStop = false;
            // 
            // dgvSales
            // 
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumn,
            this.productNameColumn,
            this.unitPriceColumn,
            this.quantityColumn,
            this.subtotalColumn});
            this.dgvSales.Location = new System.Drawing.Point(22, 135);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.Size = new System.Drawing.Size(677, 547);
            this.dgvSales.TabIndex = 10;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSales_CellContentClick);
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.HeaderText = "Barcode";
            this.barcodeColumn.MinimumWidth = 6;
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.Width = 125;
            // 
            // productNameColumn
            // 
            this.productNameColumn.HeaderText = "Product";
            this.productNameColumn.MinimumWidth = 6;
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.Width = 125;
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.HeaderText = "Price";
            this.unitPriceColumn.MinimumWidth = 6;
            this.unitPriceColumn.Name = "unitPriceColumn";
            this.unitPriceColumn.Width = 125;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.MinimumWidth = 6;
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.Width = 125;
            // 
            // subtotalColumn
            // 
            this.subtotalColumn.HeaderText = "Subtotal";
            this.subtotalColumn.MinimumWidth = 6;
            this.subtotalColumn.Name = "subtotalColumn";
            this.subtotalColumn.Width = 125;
            // 
            // lblInvertory
            // 
            this.lblInvertory.BackColor = System.Drawing.Color.Maroon;
            this.lblInvertory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvertory.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertory.ForeColor = System.Drawing.Color.White;
            this.lblInvertory.Location = new System.Drawing.Point(108, 50);
            this.lblInvertory.Multiline = true;
            this.lblInvertory.Name = "lblInvertory";
            this.lblInvertory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInvertory.Size = new System.Drawing.Size(175, 40);
            this.lblInvertory.TabIndex = 12;
            this.lblInvertory.TabStop = false;
            this.lblInvertory.Text = "POS Module";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(756, 320);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(156, 40);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.BackColor = System.Drawing.Color.Maroon;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(756, 365);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(127, 28);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.TabStop = false;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(1071, 157);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(282, 40);
            this.txtBarcode.TabIndex = 16;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.BackColor = System.Drawing.Color.Maroon;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblQuantity.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblQuantity.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(756, 283);
            this.lblQuantity.Multiline = true;
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuantity.Size = new System.Drawing.Size(127, 30);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.TabStop = false;
            this.lblQuantity.Text = "QUANTITY:";
            this.lblQuantity.TextChanged += new System.EventHandler(this.lblQuantity_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(756, 399);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(256, 40);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblCash
            // 
            this.lblCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCash.BackColor = System.Drawing.Color.Maroon;
            this.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCash.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblCash.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(756, 446);
            this.lblCash.Multiline = true;
            this.lblCash.Name = "lblCash";
            this.lblCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCash.Size = new System.Drawing.Size(127, 27);
            this.lblCash.TabIndex = 20;
            this.lblCash.TabStop = false;
            this.lblCash.Text = "CASH:";
            this.lblCash.TextChanged += new System.EventHandler(this.lblCash_TextChanged);
            // 
            // txtCash
            // 
            this.txtCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(756, 478);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(256, 40);
            this.txtCash.TabIndex = 21;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(756, 558);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(256, 40);
            this.txtChange.TabIndex = 36;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChange.BackColor = System.Drawing.Color.Maroon;
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblChange.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblChange.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(756, 525);
            this.lblChange.Multiline = true;
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(127, 27);
            this.lblChange.TabIndex = 35;
            this.lblChange.TabStop = false;
            this.lblChange.Text = "CHANGE:";
            // 
            // btnNumber4
            // 
            this.btnNumber4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber4.BackColor = System.Drawing.Color.White;
            this.btnNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber4.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber4.ForeColor = System.Drawing.Color.Black;
            this.btnNumber4.Location = new System.Drawing.Point(1071, 267);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(90, 53);
            this.btnNumber4.TabIndex = 57;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = false;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber4_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDecimal.BackColor = System.Drawing.Color.White;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.Color.Black;
            this.btnDecimal.Location = new System.Drawing.Point(1263, 385);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(90, 53);
            this.btnDecimal.TabIndex = 56;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1167, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 53);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNumber0
            // 
            this.btnNumber0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber0.BackColor = System.Drawing.Color.White;
            this.btnNumber0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber0.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber0.ForeColor = System.Drawing.Color.Black;
            this.btnNumber0.Location = new System.Drawing.Point(1071, 385);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(90, 53);
            this.btnNumber0.TabIndex = 54;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = false;
            this.btnNumber0.Click += new System.EventHandler(this.btnNumber0_Click);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber9.BackColor = System.Drawing.Color.White;
            this.btnNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber9.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber9.ForeColor = System.Drawing.Color.Black;
            this.btnNumber9.Location = new System.Drawing.Point(1263, 326);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(90, 53);
            this.btnNumber9.TabIndex = 53;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = false;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber9_Click);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber8.BackColor = System.Drawing.Color.White;
            this.btnNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber8.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber8.ForeColor = System.Drawing.Color.Black;
            this.btnNumber8.Location = new System.Drawing.Point(1167, 326);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(90, 53);
            this.btnNumber8.TabIndex = 52;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = false;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber8_Click);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber7.BackColor = System.Drawing.Color.White;
            this.btnNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber7.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber7.ForeColor = System.Drawing.Color.Black;
            this.btnNumber7.Location = new System.Drawing.Point(1071, 326);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(90, 53);
            this.btnNumber7.TabIndex = 51;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = false;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber7_Click);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber6.BackColor = System.Drawing.Color.White;
            this.btnNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber6.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber6.ForeColor = System.Drawing.Color.Black;
            this.btnNumber6.Location = new System.Drawing.Point(1263, 267);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(90, 53);
            this.btnNumber6.TabIndex = 50;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = false;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber6_Click);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber5.BackColor = System.Drawing.Color.White;
            this.btnNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber5.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber5.ForeColor = System.Drawing.Color.Black;
            this.btnNumber5.Location = new System.Drawing.Point(1167, 267);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(90, 53);
            this.btnNumber5.TabIndex = 49;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = false;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber5_Click);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber3.BackColor = System.Drawing.Color.White;
            this.btnNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber3.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber3.ForeColor = System.Drawing.Color.Black;
            this.btnNumber3.Location = new System.Drawing.Point(1263, 208);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(90, 53);
            this.btnNumber3.TabIndex = 48;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = false;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber3_Click);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber2.BackColor = System.Drawing.Color.White;
            this.btnNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber2.ForeColor = System.Drawing.Color.Black;
            this.btnNumber2.Location = new System.Drawing.Point(1167, 208);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(90, 53);
            this.btnNumber2.TabIndex = 47;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = false;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber2_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumber1.BackColor = System.Drawing.Color.White;
            this.btnNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber1.ForeColor = System.Drawing.Color.Black;
            this.btnNumber1.Location = new System.Drawing.Point(1071, 208);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(90, 53);
            this.btnNumber1.TabIndex = 46;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = false;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber1_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(1071, 465);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 53);
            this.btnPay.TabIndex = 60;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnVoidIten
            // 
            this.btnVoidIten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoidIten.BackColor = System.Drawing.Color.White;
            this.btnVoidIten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidIten.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidIten.ForeColor = System.Drawing.Color.Black;
            this.btnVoidIten.Location = new System.Drawing.Point(1167, 465);
            this.btnVoidIten.Name = "btnVoidIten";
            this.btnVoidIten.Size = new System.Drawing.Size(90, 53);
            this.btnVoidIten.TabIndex = 60;
            this.btnVoidIten.Text = "Void Item";
            this.btnVoidIten.UseVisualStyleBackColor = false;
            // 
            // btnRefund
            // 
            this.btnRefund.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefund.BackColor = System.Drawing.Color.White;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.Black;
            this.btnRefund.Location = new System.Drawing.Point(1263, 465);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(90, 53);
            this.btnRefund.TabIndex = 60;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.White;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.Location = new System.Drawing.Point(1071, 583);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(282, 53);
            this.btnPrintReceipt.TabIndex = 60;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.Location = new System.Drawing.Point(1071, 524);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(90, 53);
            this.btnCheckout.TabIndex = 60;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnHold
            // 
            this.btnHold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHold.BackColor = System.Drawing.Color.White;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.Black;
            this.btnHold.Location = new System.Drawing.Point(1263, 524);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(90, 53);
            this.btnHold.TabIndex = 60;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            // 
            // CashierOut
            // 
            this.CashierOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CashierOut.BackColor = System.Drawing.Color.White;
            this.CashierOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOut.ForeColor = System.Drawing.Color.Black;
            this.CashierOut.Location = new System.Drawing.Point(841, 618);
            this.CashierOut.Name = "CashierOut";
            this.CashierOut.Size = new System.Drawing.Size(90, 53);
            this.CashierOut.TabIndex = 60;
            this.CashierOut.Text = "Cashier Out";
            this.CashierOut.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(937, 618);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(90, 53);
            this.btnAdmin.TabIndex = 60;
            this.btnAdmin.Text = "Admin Permission";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(745, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 53);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTransactionIDPlaceholder
            // 
            this.lblTransactionIDPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionIDPlaceholder.AutoSize = true;
            this.lblTransactionIDPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionIDPlaceholder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTransactionIDPlaceholder.Location = new System.Drawing.Point(1260, 130);
            this.lblTransactionIDPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionIDPlaceholder.Name = "lblTransactionIDPlaceholder";
            this.lblTransactionIDPlaceholder.Size = new System.Drawing.Size(46, 17);
            this.lblTransactionIDPlaceholder.TabIndex = 66;
            this.lblTransactionIDPlaceholder.Text = "label1";
            this.lblTransactionIDPlaceholder.Click += new System.EventHandler(this.lblTransactionIDPlaceholder_Click);
            // 
            // btnEnterQuantity
            // 
            this.btnEnterQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnterQuantity.Location = new System.Drawing.Point(918, 320);
            this.btnEnterQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterQuantity.Name = "btnEnterQuantity";
            this.btnEnterQuantity.Size = new System.Drawing.Size(94, 40);
            this.btnEnterQuantity.TabIndex = 67;
            this.btnEnterQuantity.Text = "Enter Quantity";
            this.btnEnterQuantity.UseVisualStyleBackColor = true;
            this.btnEnterQuantity.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearchProduct.Location = new System.Drawing.Point(756, 112);
            this.lblSearchProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(110, 17);
            this.lblSearchProduct.TabIndex = 68;
            this.lblSearchProduct.Text = "Search Product:";
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchbar.Location = new System.Drawing.Point(756, 131);
            this.txtSearchbar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(256, 20);
            this.txtSearchbar.TabIndex = 69;
            this.txtSearchbar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstboxSuggestion
            // 
            this.lstboxSuggestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstboxSuggestion.FormattingEnabled = true;
            this.lstboxSuggestion.Location = new System.Drawing.Point(756, 171);
            this.lstboxSuggestion.Margin = new System.Windows.Forms.Padding(2);
            this.lstboxSuggestion.Name = "lstboxSuggestion";
            this.lstboxSuggestion.Size = new System.Drawing.Size(256, 95);
            this.lstboxSuggestion.TabIndex = 70;
            this.lstboxSuggestion.SelectedIndexChanged += new System.EventHandler(this.lstboxSuggestion_SelectedIndexChanged);
            // 
            // picboxUSER
            // 
            this.picboxUSER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picboxUSER.Image = ((System.Drawing.Image)(resources.GetObject("picboxUSER.Image")));
            this.picboxUSER.Location = new System.Drawing.Point(31, 737);
            this.picboxUSER.Name = "picboxUSER";
            this.picboxUSER.Size = new System.Drawing.Size(43, 39);
            this.picboxUSER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUSER.TabIndex = 64;
            this.picboxUSER.TabStop = false;
            // 
            // lblCashierName
            // 
            this.lblCashierName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCashierName.BackColor = System.Drawing.Color.Maroon;
            this.lblCashierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCashierName.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblCashierName.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(80, 737);
            this.lblCashierName.Multiline = true;
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCashierName.Size = new System.Drawing.Size(188, 39);
            this.lblCashierName.TabIndex = 65;
            this.lblCashierName.TabStop = false;
            this.lblCashierName.Text = "CASHIER 1";
            this.lblCashierName.TextChanged += new System.EventHandler(this.lblCashierName_TextChanged);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionID.BackColor = System.Drawing.Color.Maroon;
            this.lblTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTransactionID.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTransactionID.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.ForeColor = System.Drawing.Color.White;
            this.lblTransactionID.Location = new System.Drawing.Point(1071, 130);
            this.lblTransactionID.Multiline = true;
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransactionID.Size = new System.Drawing.Size(282, 25);
            this.lblTransactionID.TabIndex = 11;
            this.lblTransactionID.TabStop = false;
            this.lblTransactionID.Text = "TRANSACTION ID:";
            // 
            // POSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.lstboxSuggestion);
            this.Controls.Add(this.txtSearchbar);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.btnEnterQuantity);
            this.Controls.Add(this.lblTransactionIDPlaceholder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.CashierOut);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.picboxUSER);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnVoidIten);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNumber0);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblInvertory);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.picboxUMLOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUSER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxUMLOGO;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox lblInvertory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox lblQuantity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox lblChange;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnVoidIten;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button CashierOut;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTransactionIDPlaceholder;
        private System.Windows.Forms.Button btnEnterQuantity;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.ListBox lstboxSuggestion;
        private System.Windows.Forms.PictureBox picboxUSER;
        private System.Windows.Forms.TextBox lblCashierName;
        private System.Windows.Forms.TextBox lblTransactionID;
    }
}