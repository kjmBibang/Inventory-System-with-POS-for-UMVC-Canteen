namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class ReportsForm
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
            this.bpReportsForm = new Inventory_System_with_POS_for_UMVC_Canteen.UIHelpers.Gradient_Panel();
            this.dgvSalesByProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.bpReportsForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // bpReportsForm
            // 
            this.bpReportsForm.ColorBottom = System.Drawing.Color.Maroon;
            this.bpReportsForm.ColorTop = System.Drawing.Color.DarkOrange;
            this.bpReportsForm.Controls.Add(this.btnBack);
            this.bpReportsForm.Controls.Add(this.label2);
            this.bpReportsForm.Controls.Add(this.label1);
            this.bpReportsForm.Controls.Add(this.dgvSalesByProduct);
            this.bpReportsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpReportsForm.Location = new System.Drawing.Point(0, 0);
            this.bpReportsForm.Name = "bpReportsForm";
            this.bpReportsForm.Size = new System.Drawing.Size(1924, 1055);
            this.bpReportsForm.TabIndex = 0;
            // 
            // dgvSalesByProduct
            // 
            this.dgvSalesByProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesByProduct.Location = new System.Drawing.Point(43, 105);
            this.dgvSalesByProduct.Name = "dgvSalesByProduct";
            this.dgvSalesByProduct.RowHeadersWidth = 51;
            this.dgvSalesByProduct.RowTemplate.Height = 24;
            this.dgvSalesByProduct.Size = new System.Drawing.Size(775, 394);
            this.dgvSalesByProduct.TabIndex = 0;
            this.dgvSalesByProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesByProduct_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALES BY PRODUCT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(830, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "REPORTS FORM";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(1736, 956);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 70);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.bpReportsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.bpReportsForm.ResumeLayout(false);
            this.bpReportsForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIHelpers.Gradient_Panel bpReportsForm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalesByProduct;
    }
}