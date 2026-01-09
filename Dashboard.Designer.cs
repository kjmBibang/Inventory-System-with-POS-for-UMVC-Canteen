namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gpColorBackground = new Inventory_System_with_POS_for_UMVC_Canteen.UIHelpers.Gradient_Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.picboxUMLOGO = new System.Windows.Forms.PictureBox();
            this.gpColorBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // gpColorBackground
            // 
            this.gpColorBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpColorBackground.ColorBottom = System.Drawing.Color.Maroon;
            this.gpColorBackground.ColorTop = System.Drawing.Color.DarkOrange;
            this.gpColorBackground.Controls.Add(this.picboxUMLOGO);
            this.gpColorBackground.Controls.Add(this.panel);
            this.gpColorBackground.Controls.Add(this.btnReports);
            this.gpColorBackground.Controls.Add(this.btnBack);
            this.gpColorBackground.Controls.Add(this.btnPOS);
            this.gpColorBackground.Controls.Add(this.btnUsers);
            this.gpColorBackground.Controls.Add(this.btnInventory);
            this.gpColorBackground.Location = new System.Drawing.Point(0, 0);
            this.gpColorBackground.Name = "gpColorBackground";
            this.gpColorBackground.Size = new System.Drawing.Size(1386, 788);
            this.gpColorBackground.TabIndex = 5;
            this.gpColorBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.gpColorBackground_Paint);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Location = new System.Drawing.Point(43, 17);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1301, 535);
            this.panel.TabIndex = 5;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Maroon;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(292, 587);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(172, 75);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1223, 715);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Maroon;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(292, 687);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(2);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(172, 75);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "Open POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(116, 687);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(172, 75);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Maroon;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(116, 587);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(172, 75);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // picboxUMLOGO
            // 
            this.picboxUMLOGO.BackColor = System.Drawing.Color.Transparent;
            this.picboxUMLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picboxUMLOGO.Image")));
            this.picboxUMLOGO.Location = new System.Drawing.Point(469, 587);
            this.picboxUMLOGO.Name = "picboxUMLOGO";
            this.picboxUMLOGO.Size = new System.Drawing.Size(749, 175);
            this.picboxUMLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUMLOGO.TabIndex = 6;
            this.picboxUMLOGO.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.gpColorBackground);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gpColorBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBack;
        private UIHelpers.Gradient_Panel gpColorBackground;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox picboxUMLOGO;
    }
}