namespace QuiteAtticFilmsEsoft
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.lblQuiteAtticFilms = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.btnLoginNow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxLogoNoName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoNoName)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainImage.Image")));
            this.pictureBoxMainImage.Location = new System.Drawing.Point(-93, -102);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(767, 709);
            this.pictureBoxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainImage.TabIndex = 0;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // lblQuiteAtticFilms
            // 
            this.lblQuiteAtticFilms.AutoSize = true;
            this.lblQuiteAtticFilms.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiteAtticFilms.Location = new System.Drawing.Point(582, 141);
            this.lblQuiteAtticFilms.Name = "lblQuiteAtticFilms";
            this.lblQuiteAtticFilms.Size = new System.Drawing.Size(381, 47);
            this.lblQuiteAtticFilms.TabIndex = 1;
            this.lblQuiteAtticFilms.Text = "Quite Attic Films";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(559, 188);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(421, 23);
            this.lblMotto.TabIndex = 2;
            this.lblMotto.Text = "Elevating Stories, Empowering Visionaries";
            // 
            // btnLoginNow
            // 
            this.btnLoginNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginNow.Location = new System.Drawing.Point(626, 280);
            this.btnLoginNow.Name = "btnLoginNow";
            this.btnLoginNow.Size = new System.Drawing.Size(278, 48);
            this.btnLoginNow.TabIndex = 3;
            this.btnLoginNow.Text = "Login Now!";
            this.btnLoginNow.UseVisualStyleBackColor = true;
            this.btnLoginNow.Click += new System.EventHandler(this.btnLoginNow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(934, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxLogoNoName
            // 
            this.pictureBoxLogoNoName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoNoName.Image")));
            this.pictureBoxLogoNoName.Location = new System.Drawing.Point(934, 440);
            this.pictureBoxLogoNoName.Name = "pictureBoxLogoNoName";
            this.pictureBoxLogoNoName.Size = new System.Drawing.Size(88, 87);
            this.pictureBoxLogoNoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoNoName.TabIndex = 5;
            this.pictureBoxLogoNoName.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 528);
            this.Controls.Add(this.pictureBoxLogoNoName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoginNow);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblQuiteAtticFilms);
            this.Controls.Add(this.pictureBoxMainImage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoNoName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainImage;
        private System.Windows.Forms.Label lblQuiteAtticFilms;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.Button btnLoginNow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBoxLogoNoName;
    }
}

