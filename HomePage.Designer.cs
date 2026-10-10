namespace QuiteAtticFilmsEsoft
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.groupBoxClientInfo = new System.Windows.Forms.GroupBox();
            this.btnClientViewMore = new System.Windows.Forms.Button();
            this.pictureBoxClientIcon = new System.Windows.Forms.PictureBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.groupBoxStaffInfo = new System.Windows.Forms.GroupBox();
            this.btnStaffViewMore = new System.Windows.Forms.Button();
            this.pictureBoxStaffIcon = new System.Windows.Forms.PictureBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.groupBoxProduction = new System.Windows.Forms.GroupBox();
            this.btnProductionViewMore = new System.Windows.Forms.Button();
            this.pictureBoxProduction = new System.Windows.Forms.PictureBox();
            this.lblProduction = new System.Windows.Forms.Label();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.btnPropertiesViewMore = new System.Windows.Forms.Button();
            this.pictureBoxPropertiesIcon = new System.Windows.Forms.PictureBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.groupBoxLocationInfo = new System.Windows.Forms.GroupBox();
            this.btnLocationViewMore = new System.Windows.Forms.Button();
            this.pictureBoxLocationIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPaymentInfo = new System.Windows.Forms.GroupBox();
            this.btnPaymentViewMore = new System.Windows.Forms.Button();
            this.pictureBoxPaymentIcon = new System.Windows.Forms.PictureBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.groupBoxClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientIcon)).BeginInit();
            this.groupBoxStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaffIcon)).BeginInit();
            this.groupBoxProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduction)).BeginInit();
            this.groupBoxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertiesIcon)).BeginInit();
            this.groupBoxLocationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocationIcon)).BeginInit();
            this.groupBoxPaymentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaymentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainImage.Image")));
            this.pictureBoxMainImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(1074, 380);
            this.pictureBoxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainImage.TabIndex = 0;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // groupBoxClientInfo
            // 
            this.groupBoxClientInfo.Controls.Add(this.btnClientViewMore);
            this.groupBoxClientInfo.Controls.Add(this.pictureBoxClientIcon);
            this.groupBoxClientInfo.Controls.Add(this.lblClient);
            this.groupBoxClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClientInfo.Location = new System.Drawing.Point(40, 406);
            this.groupBoxClientInfo.Name = "groupBoxClientInfo";
            this.groupBoxClientInfo.Size = new System.Drawing.Size(250, 238);
            this.groupBoxClientInfo.TabIndex = 1;
            this.groupBoxClientInfo.TabStop = false;
            this.groupBoxClientInfo.Text = "Client Info";
            // 
            // btnClientViewMore
            // 
            this.btnClientViewMore.BackColor = System.Drawing.Color.Green;
            this.btnClientViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientViewMore.ForeColor = System.Drawing.Color.White;
            this.btnClientViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnClientViewMore.Name = "btnClientViewMore";
            this.btnClientViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnClientViewMore.TabIndex = 2;
            this.btnClientViewMore.Text = "View More";
            this.btnClientViewMore.UseVisualStyleBackColor = false;
            this.btnClientViewMore.Click += new System.EventHandler(this.btnClientViewMore_Click);
            // 
            // pictureBoxClientIcon
            // 
            this.pictureBoxClientIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClientIcon.Image")));
            this.pictureBoxClientIcon.Location = new System.Drawing.Point(57, 59);
            this.pictureBoxClientIcon.Name = "pictureBoxClientIcon";
            this.pictureBoxClientIcon.Size = new System.Drawing.Size(115, 108);
            this.pictureBoxClientIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClientIcon.TabIndex = 1;
            this.pictureBoxClientIcon.TabStop = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.Green;
            this.lblClient.Location = new System.Drawing.Point(77, 18);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(77, 27);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // groupBoxStaffInfo
            // 
            this.groupBoxStaffInfo.Controls.Add(this.btnStaffViewMore);
            this.groupBoxStaffInfo.Controls.Add(this.pictureBoxStaffIcon);
            this.groupBoxStaffInfo.Controls.Add(this.lblStaff);
            this.groupBoxStaffInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaffInfo.Location = new System.Drawing.Point(406, 406);
            this.groupBoxStaffInfo.Name = "groupBoxStaffInfo";
            this.groupBoxStaffInfo.Size = new System.Drawing.Size(250, 238);
            this.groupBoxStaffInfo.TabIndex = 3;
            this.groupBoxStaffInfo.TabStop = false;
            this.groupBoxStaffInfo.Text = "Staff Info";
            // 
            // btnStaffViewMore
            // 
            this.btnStaffViewMore.BackColor = System.Drawing.Color.Red;
            this.btnStaffViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffViewMore.ForeColor = System.Drawing.Color.White;
            this.btnStaffViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnStaffViewMore.Name = "btnStaffViewMore";
            this.btnStaffViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnStaffViewMore.TabIndex = 2;
            this.btnStaffViewMore.Text = "View More";
            this.btnStaffViewMore.UseVisualStyleBackColor = false;
            this.btnStaffViewMore.Click += new System.EventHandler(this.btnStaffViewMore_Click);
            // 
            // pictureBoxStaffIcon
            // 
            this.pictureBoxStaffIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStaffIcon.Image")));
            this.pictureBoxStaffIcon.Location = new System.Drawing.Point(57, 59);
            this.pictureBoxStaffIcon.Name = "pictureBoxStaffIcon";
            this.pictureBoxStaffIcon.Size = new System.Drawing.Size(115, 108);
            this.pictureBoxStaffIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStaffIcon.TabIndex = 1;
            this.pictureBoxStaffIcon.TabStop = false;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.Red;
            this.lblStaff.Location = new System.Drawing.Point(77, 18);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(65, 27);
            this.lblStaff.TabIndex = 0;
            this.lblStaff.Text = "Staff";
            // 
            // groupBoxProduction
            // 
            this.groupBoxProduction.Controls.Add(this.btnProductionViewMore);
            this.groupBoxProduction.Controls.Add(this.pictureBoxProduction);
            this.groupBoxProduction.Controls.Add(this.lblProduction);
            this.groupBoxProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduction.Location = new System.Drawing.Point(777, 406);
            this.groupBoxProduction.Name = "groupBoxProduction";
            this.groupBoxProduction.Size = new System.Drawing.Size(250, 238);
            this.groupBoxProduction.TabIndex = 3;
            this.groupBoxProduction.TabStop = false;
            this.groupBoxProduction.Text = "Production Info";
            // 
            // btnProductionViewMore
            // 
            this.btnProductionViewMore.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProductionViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionViewMore.ForeColor = System.Drawing.Color.White;
            this.btnProductionViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnProductionViewMore.Name = "btnProductionViewMore";
            this.btnProductionViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnProductionViewMore.TabIndex = 2;
            this.btnProductionViewMore.Text = "View More";
            this.btnProductionViewMore.UseVisualStyleBackColor = false;
            this.btnProductionViewMore.Click += new System.EventHandler(this.btnProductionViewMore_Click);
            // 
            // pictureBoxProduction
            // 
            this.pictureBoxProduction.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProduction.Image")));
            this.pictureBoxProduction.Location = new System.Drawing.Point(57, 59);
            this.pictureBoxProduction.Name = "pictureBoxProduction";
            this.pictureBoxProduction.Size = new System.Drawing.Size(115, 108);
            this.pictureBoxProduction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduction.TabIndex = 1;
            this.pictureBoxProduction.TabStop = false;
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduction.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblProduction.Location = new System.Drawing.Point(52, 18);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(135, 27);
            this.lblProduction.TabIndex = 0;
            this.lblProduction.Text = "Production";
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.btnPropertiesViewMore);
            this.groupBoxProperties.Controls.Add(this.pictureBoxPropertiesIcon);
            this.groupBoxProperties.Controls.Add(this.lblProperties);
            this.groupBoxProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProperties.Location = new System.Drawing.Point(40, 676);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(250, 238);
            this.groupBoxProperties.TabIndex = 3;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Properties Info";
            // 
            // btnPropertiesViewMore
            // 
            this.btnPropertiesViewMore.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPropertiesViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertiesViewMore.ForeColor = System.Drawing.Color.White;
            this.btnPropertiesViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnPropertiesViewMore.Name = "btnPropertiesViewMore";
            this.btnPropertiesViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnPropertiesViewMore.TabIndex = 2;
            this.btnPropertiesViewMore.Text = "View More";
            this.btnPropertiesViewMore.UseVisualStyleBackColor = false;
            this.btnPropertiesViewMore.Click += new System.EventHandler(this.btnPropertiesViewMore_Click);
            // 
            // pictureBoxPropertiesIcon
            // 
            this.pictureBoxPropertiesIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPropertiesIcon.Image")));
            this.pictureBoxPropertiesIcon.Location = new System.Drawing.Point(68, 59);
            this.pictureBoxPropertiesIcon.Name = "pictureBoxPropertiesIcon";
            this.pictureBoxPropertiesIcon.Size = new System.Drawing.Size(104, 108);
            this.pictureBoxPropertiesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPropertiesIcon.TabIndex = 1;
            this.pictureBoxPropertiesIcon.TabStop = false;
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblProperties.Location = new System.Drawing.Point(63, 28);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(129, 27);
            this.lblProperties.TabIndex = 0;
            this.lblProperties.Text = "Properties";
            // 
            // groupBoxLocationInfo
            // 
            this.groupBoxLocationInfo.Controls.Add(this.btnLocationViewMore);
            this.groupBoxLocationInfo.Controls.Add(this.pictureBoxLocationIcon);
            this.groupBoxLocationInfo.Controls.Add(this.label4);
            this.groupBoxLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocationInfo.Location = new System.Drawing.Point(406, 676);
            this.groupBoxLocationInfo.Name = "groupBoxLocationInfo";
            this.groupBoxLocationInfo.Size = new System.Drawing.Size(250, 238);
            this.groupBoxLocationInfo.TabIndex = 3;
            this.groupBoxLocationInfo.TabStop = false;
            this.groupBoxLocationInfo.Text = "Location Info";
            // 
            // btnLocationViewMore
            // 
            this.btnLocationViewMore.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLocationViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationViewMore.ForeColor = System.Drawing.Color.White;
            this.btnLocationViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnLocationViewMore.Name = "btnLocationViewMore";
            this.btnLocationViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnLocationViewMore.TabIndex = 2;
            this.btnLocationViewMore.Text = "View More";
            this.btnLocationViewMore.UseVisualStyleBackColor = false;
            this.btnLocationViewMore.Click += new System.EventHandler(this.btnLocationViewMore_Click);
            // 
            // pictureBoxLocationIcon
            // 
            this.pictureBoxLocationIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocationIcon.Image")));
            this.pictureBoxLocationIcon.Location = new System.Drawing.Point(40, 76);
            this.pictureBoxLocationIcon.Name = "pictureBoxLocationIcon";
            this.pictureBoxLocationIcon.Size = new System.Drawing.Size(146, 91);
            this.pictureBoxLocationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocationIcon.TabIndex = 1;
            this.pictureBoxLocationIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(62, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            // 
            // groupBoxPaymentInfo
            // 
            this.groupBoxPaymentInfo.Controls.Add(this.btnPaymentViewMore);
            this.groupBoxPaymentInfo.Controls.Add(this.pictureBoxPaymentIcon);
            this.groupBoxPaymentInfo.Controls.Add(this.lblPayment);
            this.groupBoxPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPaymentInfo.Location = new System.Drawing.Point(777, 676);
            this.groupBoxPaymentInfo.Name = "groupBoxPaymentInfo";
            this.groupBoxPaymentInfo.Size = new System.Drawing.Size(250, 238);
            this.groupBoxPaymentInfo.TabIndex = 3;
            this.groupBoxPaymentInfo.TabStop = false;
            this.groupBoxPaymentInfo.Text = "Payment Info";
            // 
            // btnPaymentViewMore
            // 
            this.btnPaymentViewMore.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPaymentViewMore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentViewMore.ForeColor = System.Drawing.Color.White;
            this.btnPaymentViewMore.Location = new System.Drawing.Point(40, 173);
            this.btnPaymentViewMore.Name = "btnPaymentViewMore";
            this.btnPaymentViewMore.Size = new System.Drawing.Size(157, 50);
            this.btnPaymentViewMore.TabIndex = 2;
            this.btnPaymentViewMore.Text = "View More";
            this.btnPaymentViewMore.UseVisualStyleBackColor = false;
            this.btnPaymentViewMore.Click += new System.EventHandler(this.btnPaymentViewMore_Click);
            // 
            // pictureBoxPaymentIcon
            // 
            this.pictureBoxPaymentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPaymentIcon.Image")));
            this.pictureBoxPaymentIcon.Location = new System.Drawing.Point(50, 76);
            this.pictureBoxPaymentIcon.Name = "pictureBoxPaymentIcon";
            this.pictureBoxPaymentIcon.Size = new System.Drawing.Size(137, 91);
            this.pictureBoxPaymentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPaymentIcon.TabIndex = 1;
            this.pictureBoxPaymentIcon.TabStop = false;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPayment.Location = new System.Drawing.Point(63, 28);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(109, 27);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(40, 944);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.Location = new System.Drawing.Point(961, 952);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(66, 20);
            this.linkLabelLogout.TabIndex = 5;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 998);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxPaymentInfo);
            this.Controls.Add(this.groupBoxLocationInfo);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxProduction);
            this.Controls.Add(this.groupBoxStaffInfo);
            this.Controls.Add(this.groupBoxClientInfo);
            this.Controls.Add(this.pictureBoxMainImage);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.groupBoxClientInfo.ResumeLayout(false);
            this.groupBoxClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientIcon)).EndInit();
            this.groupBoxStaffInfo.ResumeLayout(false);
            this.groupBoxStaffInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStaffIcon)).EndInit();
            this.groupBoxProduction.ResumeLayout(false);
            this.groupBoxProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduction)).EndInit();
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropertiesIcon)).EndInit();
            this.groupBoxLocationInfo.ResumeLayout(false);
            this.groupBoxLocationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocationIcon)).EndInit();
            this.groupBoxPaymentInfo.ResumeLayout(false);
            this.groupBoxPaymentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaymentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.GroupBox groupBoxClientInfo;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox groupBoxStaffInfo;
        private System.Windows.Forms.Button btnStaffViewMore;
        private System.Windows.Forms.PictureBox pictureBoxStaffIcon;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnClientViewMore;
        private System.Windows.Forms.PictureBox pictureBoxClientIcon;
        private System.Windows.Forms.GroupBox groupBoxProduction;
        private System.Windows.Forms.Button btnProductionViewMore;
        private System.Windows.Forms.PictureBox pictureBoxProduction;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Button btnPropertiesViewMore;
        private System.Windows.Forms.PictureBox pictureBoxPropertiesIcon;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.GroupBox groupBoxLocationInfo;
        private System.Windows.Forms.Button btnLocationViewMore;
        private System.Windows.Forms.PictureBox pictureBoxLocationIcon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPaymentInfo;
        private System.Windows.Forms.Button btnPaymentViewMore;
        private System.Windows.Forms.PictureBox pictureBoxPaymentIcon;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}