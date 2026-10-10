namespace QuiteAtticFilmsEsoft
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.lblReadyToLoginAsAClient = new System.Windows.Forms.Label();
            this.groupBoxLoginDetails = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxLogoWithName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.groupBoxLoginDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWithName)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainImage.Image")));
            this.pictureBoxMainImage.Location = new System.Drawing.Point(0, 53);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(656, 478);
            this.pictureBoxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainImage.TabIndex = 0;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // lblReadyToLoginAsAClient
            // 
            this.lblReadyToLoginAsAClient.AutoSize = true;
            this.lblReadyToLoginAsAClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyToLoginAsAClient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblReadyToLoginAsAClient.Location = new System.Drawing.Point(642, 92);
            this.lblReadyToLoginAsAClient.Name = "lblReadyToLoginAsAClient";
            this.lblReadyToLoginAsAClient.Size = new System.Drawing.Size(451, 38);
            this.lblReadyToLoginAsAClient.TabIndex = 1;
            this.lblReadyToLoginAsAClient.Text = "Ready To Login As A Client";
            // 
            // groupBoxLoginDetails
            // 
            this.groupBoxLoginDetails.Controls.Add(this.btnLogin);
            this.groupBoxLoginDetails.Controls.Add(this.txtPassword);
            this.groupBoxLoginDetails.Controls.Add(this.txtUsername);
            this.groupBoxLoginDetails.Controls.Add(this.lblPassword);
            this.groupBoxLoginDetails.Controls.Add(this.lblUsername);
            this.groupBoxLoginDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginDetails.Location = new System.Drawing.Point(662, 152);
            this.groupBoxLoginDetails.Name = "groupBoxLoginDetails";
            this.groupBoxLoginDetails.Size = new System.Drawing.Size(428, 287);
            this.groupBoxLoginDetails.TabIndex = 2;
            this.groupBoxLoginDetails.TabStop = false;
            this.groupBoxLoginDetails.Text = "Login Details";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(82, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(139, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(139, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 28);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 27);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 27);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1073, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Location = new System.Drawing.Point(662, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Location = new System.Drawing.Point(1002, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 31);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBoxLogoWithName
            // 
            this.pictureBoxLogoWithName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoWithName.Image")));
            this.pictureBoxLogoWithName.Location = new System.Drawing.Point(1037, 510);
            this.pictureBoxLogoWithName.Name = "pictureBoxLogoWithName";
            this.pictureBoxLogoWithName.Size = new System.Drawing.Size(131, 103);
            this.pictureBoxLogoWithName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoWithName.TabIndex = 6;
            this.pictureBoxLogoWithName.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 616);
            this.Controls.Add(this.pictureBoxLogoWithName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxLoginDetails);
            this.Controls.Add(this.lblReadyToLoginAsAClient);
            this.Controls.Add(this.pictureBoxMainImage);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.groupBoxLoginDetails.ResumeLayout(false);
            this.groupBoxLoginDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoWithName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.Label lblReadyToLoginAsAClient;
        private System.Windows.Forms.GroupBox groupBoxLoginDetails;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBoxLogoWithName;
    }
}