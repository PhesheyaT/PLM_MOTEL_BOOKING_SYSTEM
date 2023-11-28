
namespace M2_PLM_MOTEL
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bookButton = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.custButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.bookButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.ForeColor = System.Drawing.Color.Navy;
            this.bookButton.Location = new System.Drawing.Point(66, 356);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(116, 76);
            this.bookButton.TabIndex = 0;
            this.bookButton.Text = "BOOKINGS";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // paymentsButton
            // 
            this.paymentsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.paymentsButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsButton.ForeColor = System.Drawing.Color.Navy;
            this.paymentsButton.Location = new System.Drawing.Point(201, 356);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Size = new System.Drawing.Size(106, 76);
            this.paymentsButton.TabIndex = 1;
            this.paymentsButton.Text = "VIEW PAYMENTS";
            this.paymentsButton.UseVisualStyleBackColor = false;
            this.paymentsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // roomButton
            // 
            this.roomButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.roomButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.roomButton.Location = new System.Drawing.Point(328, 356);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(111, 76);
            this.roomButton.TabIndex = 2;
            this.roomButton.Text = "VIEW ROOMS";
            this.roomButton.UseVisualStyleBackColor = false;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.staffButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.staffButton.Location = new System.Drawing.Point(466, 356);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(98, 76);
            this.staffButton.TabIndex = 3;
            this.staffButton.Text = "STAFF MENU";
            this.staffButton.UseVisualStyleBackColor = false;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // custButton
            // 
            this.custButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.custButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.custButton.Location = new System.Drawing.Point(600, 356);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(109, 76);
            this.custButton.TabIndex = 4;
            this.custButton.Text = "CUSTOMER MENU";
            this.custButton.UseVisualStyleBackColor = false;
            this.custButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(684, 24);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "LOG OUT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.custButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.roomButton);
            this.Controls.Add(this.paymentsButton);
            this.Controls.Add(this.bookButton);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button roomButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
    }
}