﻿namespace M2_PLM_MOTEL
{
    partial class CONFIRM_PAYMENTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONFIRM_PAYMENTS));
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IDtextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bckButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ist3bdDataSet1 = new M2_PLM_MOTEL.ist3bdDataSet1();
            this.paymentsTableAdapter1 = new M2_PLM_MOTEL.DataSet1TableAdapters.PaymentsTableAdapter();
            this.bookingsTableAdapter1 = new M2_PLM_MOTEL.DataSet1TableAdapters.BookingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ist3bdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "CONFIRM BOOKING PAYMENT";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(360, 136);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(159, 20);
            this.nametextBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "NAME :";
            // 
            // IDtextBox3
            // 
            this.IDtextBox3.Location = new System.Drawing.Point(360, 92);
            this.IDtextBox3.Name = "IDtextBox3";
            this.IDtextBox3.Size = new System.Drawing.Size(159, 20);
            this.IDtextBox3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "CUSTOMER ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "ROOM NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "PAYMENT TYPE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "AMOUNT :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 346);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(273, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 52;
            this.button1.Text = "CONFIRM PAYMENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(692, 41);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(75, 23);
            this.bckButton.TabIndex = 53;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CASH",
            "EFT"});
            this.comboBox1.Location = new System.Drawing.Point(360, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "CHECK IN :";
            // 
            // ist3bdDataSet1
            // 
            this.ist3bdDataSet1.DataSetName = "ist3bdDataSet1";
            this.ist3bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter1
            // 
            this.paymentsTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingsTableAdapter1
            // 
            this.bookingsTableAdapter1.ClearBeforeFill = true;
            // 
            // CONFIRM_PAYMENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtextBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label1);
            this.Name = "CONFIRM_PAYMENTS";
            this.Text = "CONFIRM_PAYMENTS";
            this.Load += new System.EventHandler(this.CONFIRM_PAYMENTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ist3bdDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDtextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bckButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1TableAdapters.PaymentsTableAdapter paymentsTableAdapter1;
        private DataSet1TableAdapters.BookingsTableAdapter bookingsTableAdapter1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private ist3bdDataSet1 ist3bdDataSet1;
    }
}