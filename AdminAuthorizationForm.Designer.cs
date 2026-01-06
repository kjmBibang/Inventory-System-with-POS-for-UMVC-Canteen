namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class AdminAuthorizationForm
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
            this.lblAdminAuthorizationForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorizationKey = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAdminAuthorizationForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblAdminAuthorizationForm
            // 
            this.lblAdminAuthorizationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdminAuthorizationForm.AutoSize = true;
            this.lblAdminAuthorizationForm.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminAuthorizationForm.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminAuthorizationForm.Location = new System.Drawing.Point(25, 9);
            this.lblAdminAuthorizationForm.Name = "lblAdminAuthorizationForm";
            this.lblAdminAuthorizationForm.Size = new System.Drawing.Size(251, 25);
            this.lblAdminAuthorizationForm.TabIndex = 0;
            this.lblAdminAuthorizationForm.Text = "Admin Authorization Form";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Call an admin before you can use this feature.\r\n      Admin should input his auth" +
    "orization\r\n\r\n";
            // 
            // txtAuthorizationKey
            // 
            this.txtAuthorizationKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthorizationKey.Location = new System.Drawing.Point(30, 110);
            this.txtAuthorizationKey.Name = "txtAuthorizationKey";
            this.txtAuthorizationKey.Size = new System.Drawing.Size(246, 20);
            this.txtAuthorizationKey.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(212, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AdminAuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(299, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAuthorizationKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAuthorizationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminAuthorizationForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorizationKey;
        private System.Windows.Forms.Button btnCancel;
    }
}