namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class UserManagementForm
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
            this.gpBackGroundColor = new Inventory_System_with_POS_for_UMVC_Canteen.UIHelpers.Gradient_Panel();
            this.lblCriticalStock = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.userIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gpBackGroundColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBackGroundColor
            // 
            this.gpBackGroundColor.BackColor = System.Drawing.Color.Transparent;
            this.gpBackGroundColor.ColorBottom = System.Drawing.Color.Maroon;
            this.gpBackGroundColor.ColorTop = System.Drawing.Color.DarkOrange;
            this.gpBackGroundColor.Controls.Add(this.lblCriticalStock);
            this.gpBackGroundColor.Controls.Add(this.dgvUsers);
            this.gpBackGroundColor.Controls.Add(this.btnBack);
            this.gpBackGroundColor.Controls.Add(this.button2);
            this.gpBackGroundColor.Controls.Add(this.btnUpdateUser);
            this.gpBackGroundColor.Controls.Add(this.btnAddUser);
            this.gpBackGroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBackGroundColor.ForeColor = System.Drawing.Color.Transparent;
            this.gpBackGroundColor.Location = new System.Drawing.Point(0, 0);
            this.gpBackGroundColor.Margin = new System.Windows.Forms.Padding(4);
            this.gpBackGroundColor.Name = "gpBackGroundColor";
            this.gpBackGroundColor.Size = new System.Drawing.Size(1848, 970);
            this.gpBackGroundColor.TabIndex = 19;
            // 
            // lblCriticalStock
            // 
            this.lblCriticalStock.AutoSize = true;
            this.lblCriticalStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCriticalStock.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCriticalStock.Location = new System.Drawing.Point(888, 25);
            this.lblCriticalStock.Name = "lblCriticalStock";
            this.lblCriticalStock.Size = new System.Drawing.Size(361, 46);
            this.lblCriticalStock.TabIndex = 23;
            this.lblCriticalStock.Text = "USER MANAGEMENT";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDColumn,
            this.usernameColumn,
            this.passwordColumn,
            this.roleColumn});
            this.dgvUsers.Location = new System.Drawing.Point(57, 94);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(1429, 862);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDColumn
            // 
            this.userIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIDColumn.HeaderText = "User ID";
            this.userIDColumn.MinimumWidth = 6;
            this.userIDColumn.Name = "userIDColumn";
            this.userIDColumn.ReadOnly = true;
            this.userIDColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usernameColumn
            // 
            this.usernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.MinimumWidth = 6;
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            this.usernameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passwordColumn
            // 
            this.passwordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.MinimumWidth = 6;
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            this.passwordColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // roleColumn
            // 
            this.roleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleColumn.HeaderText = "Role";
            this.roleColumn.MinimumWidth = 6;
            this.roleColumn.Name = "roleColumn";
            this.roleColumn.ReadOnly = true;
            this.roleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(1701, 894);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 63);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(1563, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 96);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Location = new System.Drawing.Point(1563, 197);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(251, 96);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Location = new System.Drawing.Point(1563, 94);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(251, 96);
            this.btnAddUser.TabIndex = 13;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.gpBackGroundColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagementForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            this.gpBackGroundColor.ResumeLayout(false);
            this.gpBackGroundColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private UIHelpers.Gradient_Panel gpBackGroundColor;
        private System.Windows.Forms.Label lblCriticalStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
    }
}