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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStockIn = new System.Windows.Forms.TextBox();
            this.lblStockIn = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 336);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(19, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 305);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(572, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 305);
            this.panel3.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1058, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 32);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // txtStockIn
            // 
            this.txtStockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockIn.Location = new System.Drawing.Point(439, 372);
            this.txtStockIn.Name = "txtStockIn";
            this.txtStockIn.Size = new System.Drawing.Size(256, 40);
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
            this.lblStockIn.Location = new System.Drawing.Point(326, 382);
            this.lblStockIn.Multiline = true;
            this.lblStockIn.Name = "lblStockIn";
            this.lblStockIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStockIn.Size = new System.Drawing.Size(107, 27);
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
            this.lblSupplier.Location = new System.Drawing.Point(326, 440);
            this.lblSupplier.Multiline = true;
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupplier.Size = new System.Drawing.Size(107, 27);
            this.lblSupplier.TabIndex = 66;
            this.lblSupplier.TabStop = false;
            this.lblSupplier.Text = "SUPPLIER:";
            // 
            // ListBox
            // 
            this.ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 33;
            this.ListBox.Location = new System.Drawing.Point(439, 434);
            this.ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(256, 33);
            this.ListBox.TabIndex = 71;
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1131, 496);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblStockIn);
            this.Controls.Add(this.txtStockIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockInForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtStockIn;
        private System.Windows.Forms.TextBox lblStockIn;
        private System.Windows.Forms.TextBox lblSupplier;
        private System.Windows.Forms.ListBox ListBox;
    }
}