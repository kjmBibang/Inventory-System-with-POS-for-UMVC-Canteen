namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class UpdateUsersForm
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
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdateUsername = new System.Windows.Forms.Label();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.lblUpdateRole = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblPasswordNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(192, 189);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(526, 22);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(192, 129);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(526, 22);
            this.txtUpdatePassword.TabIndex = 2;
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.Location = new System.Drawing.Point(192, 66);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(526, 22);
            this.txtUpdateUsername.TabIndex = 1;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(16, 192);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(118, 16);
            this.lblConfirmPassword.TabIndex = 13;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Location = new System.Drawing.Point(61, 132);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(70, 16);
            this.lblUpdatePassword.TabIndex = 12;
            this.lblUpdatePassword.Text = "Password:";
            // 
            // lblUpdateUsername
            // 
            this.lblUpdateUsername.AutoSize = true;
            this.lblUpdateUsername.Location = new System.Drawing.Point(61, 69);
            this.lblUpdateUsername.Name = "lblUpdateUsername";
            this.lblUpdateUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUpdateUsername.TabIndex = 11;
            this.lblUpdateUsername.Text = "Username:";
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(192, 249);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(250, 24);
            this.cmbUpdateRole.TabIndex = 4;
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.AutoSize = true;
            this.lblUpdateRole.Location = new System.Drawing.Point(93, 252);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(39, 16);
            this.lblUpdateRole.TabIndex = 18;
            this.lblUpdateRole.Text = "Role:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(618, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(498, 379);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblPasswordNote
            // 
            this.lblPasswordNote.AutoSize = true;
            this.lblPasswordNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPasswordNote.Location = new System.Drawing.Point(189, 154);
            this.lblPasswordNote.Name = "lblPasswordNote";
            this.lblPasswordNote.Size = new System.Drawing.Size(353, 16);
            this.lblPasswordNote.TabIndex = 21;
            this.lblPasswordNote.Text = "(Leave password fields blank if you don\'t want to change it)";
            // 
            // UpdateUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.lblPasswordNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.lblUpdateRole);
            this.Controls.Add(this.cmbUpdateRole);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtUpdatePassword);
            this.Controls.Add(this.txtUpdateUsername);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblUpdatePassword);
            this.Controls.Add(this.lblUpdateUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.UpdateUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdateUsername;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label lblUpdateRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblPasswordNote;
    }
}