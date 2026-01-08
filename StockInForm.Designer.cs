namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class StockInForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStockIn = new System.Windows.Forms.TextBox();
            this.lblStockIn = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(568, 303);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 39);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Close";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStockIn
            // 
            this.txtStockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockIn.Location = new System.Drawing.Point(233, 108);
            this.txtStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockIn.Name = "txtStockIn";
            this.txtStockIn.Size = new System.Drawing.Size(340, 49);
            this.txtStockIn.TabIndex = 63;
            this.txtStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStockIn
            // 
            this.lblStockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockIn.BackColor = System.Drawing.Color.Maroon;
            this.lblStockIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStockIn.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblStockIn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockIn.ForeColor = System.Drawing.Color.White;
            this.lblStockIn.Location = new System.Drawing.Point(59, 118);
            this.lblStockIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblStockIn.Multiline = true;
            this.lblStockIn.Name = "lblStockIn";
            this.lblStockIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStockIn.Size = new System.Drawing.Size(143, 33);
            this.lblStockIn.TabIndex = 65;
            this.lblStockIn.TabStop = false;
            this.lblStockIn.Text = "STOCK IN:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSupplier.BackColor = System.Drawing.Color.Maroon;
            this.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSupplier.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblSupplier.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(59, 179);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSupplier.Multiline = true;
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupplier.Size = new System.Drawing.Size(143, 33);
            this.lblSupplier.TabIndex = 66;
            this.lblSupplier.TabStop = false;
            this.lblSupplier.Text = "SUPPLIER:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(227, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "Stock In Form";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(233, 179);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(340, 39);
            this.cmbSupplier.TabIndex = 73;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 53);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(693, 367);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblStockIn);
            this.Controls.Add(this.txtStockIn);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockInForm";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtStockIn;
        private System.Windows.Forms.TextBox lblStockIn;
        private System.Windows.Forms.TextBox lblSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnSave;
    }
}