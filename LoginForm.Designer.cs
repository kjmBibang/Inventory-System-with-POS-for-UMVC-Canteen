namespace Inventory_System_with_POS_for_UMVC_Canteen
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelColor = new System.Windows.Forms.Panel();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picboxUMLOGO = new System.Windows.Forms.PictureBox();
            this.picboxUSER = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picboxPASS = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUSER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPASS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelColor.BackColor = System.Drawing.Color.Maroon;
            this.panelColor.Controls.Add(this.lblDeveloperName);
            this.panelColor.Controls.Add(this.lblWelcome);
            this.panelColor.Controls.Add(this.picboxUMLOGO);
            this.panelColor.Location = new System.Drawing.Point(-1, 0);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(303, 370);
            this.panelColor.TabIndex = 0;
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDeveloperName.BackColor = System.Drawing.Color.Maroon;
            this.lblDeveloperName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDeveloperName.ForeColor = System.Drawing.Color.White;
            this.lblDeveloperName.Location = new System.Drawing.Point(173, 299);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(116, 55);
            this.lblDeveloperName.TabIndex = 0;
            this.lblDeveloperName.Text = "Developed by: Monkey Development";
            this.lblDeveloperName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWelcome.BackColor = System.Drawing.Color.Maroon;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(3, 153);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 129);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the Inventory System UMVC Canteen";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxUMLOGO
            // 
            this.picboxUMLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picboxUMLOGO.Image")));
            this.picboxUMLOGO.Location = new System.Drawing.Point(85, 30);
            this.picboxUMLOGO.Name = "picboxUMLOGO";
            this.picboxUMLOGO.Size = new System.Drawing.Size(138, 117);
            this.picboxUMLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUMLOGO.TabIndex = 2;
            this.picboxUMLOGO.TabStop = false;
            // 
            // picboxUSER
            // 
            this.picboxUSER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picboxUSER.Image = ((System.Drawing.Image)(resources.GetObject("picboxUSER.Image")));
            this.picboxUSER.Location = new System.Drawing.Point(308, 165);
            this.picboxUSER.Name = "picboxUSER";
            this.picboxUSER.Size = new System.Drawing.Size(25, 21);
            this.picboxUSER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUSER.TabIndex = 9;
            this.picboxUSER.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(339, 166);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(339, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // picboxPASS
            // 
            this.picboxPASS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picboxPASS.Image = ((System.Drawing.Image)(resources.GetObject("picboxPASS.Image")));
            this.picboxPASS.Location = new System.Drawing.Point(308, 216);
            this.picboxPASS.Name = "picboxPASS";
            this.picboxPASS.Size = new System.Drawing.Size(25, 20);
            this.picboxPASS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPASS.TabIndex = 8;
            this.picboxPASS.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(354, 104);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(210, 26);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login to your account";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLogin.BackColor = System.Drawing.Color.Maroon;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(418, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 53);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsername.Location = new System.Drawing.Point(339, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPassword.Location = new System.Drawing.Point(339, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "PASSWORD";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picboxPASS);
            this.Controls.Add(this.picboxUSER);
            this.Controls.Add(this.panelColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.panelColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUMLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUSER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPASS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.PictureBox picboxUMLOGO;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.PictureBox picboxUSER;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picboxPASS;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}
