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
            this.lblTransactionID = new System.Windows.Forms.TextBox();
            this.lblInvertory = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
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
            this.btnOpenDrawer = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.picboxUSER = new System.Windows.Forms.PictureBox();
            this.lblCashierName = new System.Windows.Forms.TextBox();
            this.btnCashierIn = new System.Windows.Forms.Button();
            this.CashierOut = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxUMLOGO
            // 
            this.picboxUMLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picboxUMLOGO.Image")));
            this.picboxUMLOGO.Location = new System.Drawing.Point(13, 13);
            this.picboxUMLOGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxUMLOGO.Name = "picboxUMLOGO";
            this.picboxUMLOGO.Size = new System.Drawing.Size(67, 46);
            this.picboxUMLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUMLOGO.TabIndex = 2;
            this.picboxUMLOGO.TabStop = false;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumn,
            this.productNameColumn,
            this.unitPriceColumn,
            this.quantityColumn,
            this.subtotalColumn});
            this.dgvSales.Location = new System.Drawing.Point(13, 71);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.Size = new System.Drawing.Size(678, 576);
            this.dgvSales.TabIndex = 10;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSales_CellContentClick);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionID.BackColor = System.Drawing.Color.Maroon;
            this.lblTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTransactionID.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTransactionID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.ForeColor = System.Drawing.Color.White;
            this.lblTransactionID.Location = new System.Drawing.Point(933, 27);
            this.lblTransactionID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTransactionID.Multiline = true;
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransactionID.Size = new System.Drawing.Size(376, 20);
            this.lblTransactionID.TabIndex = 11;
            this.lblTransactionID.TabStop = false;
            this.lblTransactionID.Text = "Transaction ID:";
            this.lblTransactionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInvertory
            // 
            this.lblInvertory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInvertory.BackColor = System.Drawing.Color.Maroon;
            this.lblInvertory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvertory.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertory.ForeColor = System.Drawing.Color.White;
            this.lblInvertory.Location = new System.Drawing.Point(88, 13);
            this.lblInvertory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInvertory.Multiline = true;
            this.lblInvertory.Name = "lblInvertory";
            this.lblInvertory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInvertory.Size = new System.Drawing.Size(163, 33);
            this.lblInvertory.TabIndex = 12;
            this.lblInvertory.TabStop = false;
            this.lblInvertory.Text = "POS Module";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtotal.BackColor = System.Drawing.Color.Maroon;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSubtotal.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblSubtotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(713, 149);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSubtotal.Multiline = true;
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubtotal.Size = new System.Drawing.Size(125, 35);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.TabStop = false;
            this.lblSubtotal.Text = "SUB TOTAL:";
            this.lblSubtotal.TextChanged += new System.EventHandler(this.lblSubtotal_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(713, 92);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(207, 49);
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
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(713, 237);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(78, 30);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.TabStop = false;
            this.lblTotal.Text = "TOTAL:";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(933, 55);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(376, 49);
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
            this.lblQuantity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(713, 55);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblQuantity.Multiline = true;
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuantity.Size = new System.Drawing.Size(125, 29);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.TabStop = false;
            this.lblQuantity.Text = "QUANTITY:";
            this.lblQuantity.TextChanged += new System.EventHandler(this.lblQuantity_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(713, 180);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(207, 49);
            this.txtSubtotal.TabIndex = 18;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(713, 262);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(207, 49);
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
            this.lblCash.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(713, 319);
            this.lblCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCash.Multiline = true;
            this.lblCash.Name = "lblCash";
            this.lblCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCash.Size = new System.Drawing.Size(78, 24);
            this.lblCash.TabIndex = 20;
            this.lblCash.TabStop = false;
            this.lblCash.Text = "CASH:";
            this.lblCash.TextChanged += new System.EventHandler(this.lblCash_TextChanged);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(713, 351);
            this.txtCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(207, 49);
            this.txtCash.TabIndex = 21;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(713, 442);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(207, 49);
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
            this.lblChange.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(713, 408);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblChange.Multiline = true;
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(112, 26);
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
            this.btnNumber4.Location = new System.Drawing.Point(933, 185);
            this.btnNumber4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(120, 65);
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
            this.btnDecimal.Location = new System.Drawing.Point(1189, 330);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(120, 65);
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
            this.btnClear.Location = new System.Drawing.Point(1061, 330);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber0.Location = new System.Drawing.Point(933, 330);
            this.btnNumber0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber9.Location = new System.Drawing.Point(1189, 257);
            this.btnNumber9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber8.Location = new System.Drawing.Point(1061, 257);
            this.btnNumber8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber7.Location = new System.Drawing.Point(933, 257);
            this.btnNumber7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber6.Location = new System.Drawing.Point(1189, 185);
            this.btnNumber6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber5.Location = new System.Drawing.Point(1061, 185);
            this.btnNumber5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber3.Location = new System.Drawing.Point(1189, 112);
            this.btnNumber3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber2.Location = new System.Drawing.Point(1061, 112);
            this.btnNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(120, 65);
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
            this.btnNumber1.Location = new System.Drawing.Point(933, 112);
            this.btnNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(120, 65);
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
            this.btnPay.Location = new System.Drawing.Point(933, 428);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 65);
            this.btnPay.TabIndex = 58;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnVoidIten
            // 
            this.btnVoidIten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoidIten.BackColor = System.Drawing.Color.White;
            this.btnVoidIten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoidIten.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidIten.ForeColor = System.Drawing.Color.Black;
            this.btnVoidIten.Location = new System.Drawing.Point(1061, 428);
            this.btnVoidIten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoidIten.Name = "btnVoidIten";
            this.btnVoidIten.Size = new System.Drawing.Size(120, 65);
            this.btnVoidIten.TabIndex = 59;
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
            this.btnRefund.Location = new System.Drawing.Point(1189, 428);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(120, 65);
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
            this.btnPrintReceipt.Location = new System.Drawing.Point(933, 574);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(376, 65);
            this.btnPrintReceipt.TabIndex = 61;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenDrawer.BackColor = System.Drawing.Color.White;
            this.btnOpenDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDrawer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDrawer.ForeColor = System.Drawing.Color.Black;
            this.btnOpenDrawer.Location = new System.Drawing.Point(933, 501);
            this.btnOpenDrawer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(120, 65);
            this.btnOpenDrawer.TabIndex = 62;
            this.btnOpenDrawer.Text = "Open Drawer";
            this.btnOpenDrawer.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHold.BackColor = System.Drawing.Color.White;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.Black;
            this.btnHold.Location = new System.Drawing.Point(1189, 501);
            this.btnHold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(120, 65);
            this.btnHold.TabIndex = 63;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            // 
            // picboxUSER
            // 
            this.picboxUSER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picboxUSER.Image = ((System.Drawing.Image)(resources.GetObject("picboxUSER.Image")));
            this.picboxUSER.Location = new System.Drawing.Point(13, 666);
            this.picboxUSER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxUSER.Name = "picboxUSER";
            this.picboxUSER.Size = new System.Drawing.Size(30, 32);
            this.picboxUSER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUSER.TabIndex = 64;
            this.picboxUSER.TabStop = false;
            // 
            // lblCashierName
            // 
            this.lblCashierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCashierName.BackColor = System.Drawing.Color.Maroon;
            this.lblCashierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCashierName.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblCashierName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(51, 677);
            this.lblCashierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCashierName.Multiline = true;
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCashierName.Size = new System.Drawing.Size(101, 21);
            this.lblCashierName.TabIndex = 65;
            this.lblCashierName.TabStop = false;
            this.lblCashierName.Text = "CASHIER 1";
            this.lblCashierName.TextChanged += new System.EventHandler(this.lblCashierName_TextChanged);
            // 
            // btnCashierIn
            // 
            this.btnCashierIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCashierIn.BackColor = System.Drawing.Color.White;
            this.btnCashierIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashierIn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierIn.ForeColor = System.Drawing.Color.Black;
            this.btnCashierIn.Location = new System.Drawing.Point(152, 655);
            this.btnCashierIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCashierIn.Name = "btnCashierIn";
            this.btnCashierIn.Size = new System.Drawing.Size(102, 43);
            this.btnCashierIn.TabIndex = 66;
            this.btnCashierIn.Text = "Cashier In";
            this.btnCashierIn.UseVisualStyleBackColor = false;
            // 
            // CashierOut
            // 
            this.CashierOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CashierOut.BackColor = System.Drawing.Color.White;
            this.CashierOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOut.ForeColor = System.Drawing.Color.Black;
            this.CashierOut.Location = new System.Drawing.Point(262, 655);
            this.CashierOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CashierOut.Name = "CashierOut";
            this.CashierOut.Size = new System.Drawing.Size(120, 43);
            this.CashierOut.TabIndex = 67;
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
            this.btnAdmin.Location = new System.Drawing.Point(390, 655);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(79, 43);
            this.btnAdmin.TabIndex = 68;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
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
            // POSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1337, 700);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.CashierOut);
            this.Controls.Add(this.btnCashierIn);
            this.Controls.Add(this.lblCashierName);
            this.Controls.Add(this.picboxUSER);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnOpenDrawer);
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
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblInvertory);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.picboxUMLOGO);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "POSform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
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
        private System.Windows.Forms.TextBox lblTransactionID;
        private System.Windows.Forms.TextBox lblInvertory;
        private System.Windows.Forms.TextBox lblSubtotal;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox lblQuantity;
        private System.Windows.Forms.TextBox txtSubtotal;
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
        private System.Windows.Forms.Button btnOpenDrawer;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.PictureBox picboxUSER;
        private System.Windows.Forms.TextBox lblCashierName;
        private System.Windows.Forms.Button btnCashierIn;
        private System.Windows.Forms.Button CashierOut;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalColumn;
    }
}