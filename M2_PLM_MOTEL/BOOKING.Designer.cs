namespace M2_PLM_MOTEL
{
    partial class BOOKING
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOOKING));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.srchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoomComboBox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ist3bdDataSet = new M2_PLM_MOTEL.ist3bdDataSet();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numOfDayatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bckButton = new System.Windows.Forms.Button();
            this.roomTableAdapter1 = new M2_PLM_MOTEL.DataSet1TableAdapters.RoomTableAdapter();
            this.customerTableAdapter1 = new M2_PLM_MOTEL.DataSet1TableAdapters.CustomerTableAdapter();
            this.bookingsTableAdapter1 = new M2_PLM_MOTEL.DataSet1TableAdapters.BookingsTableAdapter();
            this.dataSet1 = new M2_PLM_MOTEL.DataSet1();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new M2_PLM_MOTEL.ist3bdDataSetTableAdapters.RoomTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist3bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.srchTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(87, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 238);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(375, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 22);
            this.button2.TabIndex = 32;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 31;
            this.button1.Text = "CONTINUE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 14);
            this.label10.TabIndex = 30;
            this.label10.Text = "Phone number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 29;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Customer ID :";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox4.Location = new System.Drawing.Point(375, 183);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox3.Location = new System.Drawing.Point(375, 89);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox2.Location = new System.Drawing.Point(45, 183);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox1.Location = new System.Drawing.Point(45, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 19;
            // 
            // srchTextBox
            // 
            this.srchTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.srchTextBox.ForeColor = System.Drawing.Color.Blue;
            this.srchTextBox.Location = new System.Drawing.Point(171, 15);
            this.srchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.srchTextBox.Name = "srchTextBox";
            this.srchTextBox.Size = new System.Drawing.Size(187, 20);
            this.srchTextBox.TabIndex = 18;
            this.srchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.srchTextBox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "SEARCH CUSTOMER :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(310, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "SEARCH CUSTOMER TO BOOK";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.RoomComboBox);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.totalTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numOfDayatextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(87, 371);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 280);
            this.panel2.TabIndex = 17;
            // 
            // RoomComboBox
            // 
            this.RoomComboBox.DataSource = this.roomBindingSource1;
            this.RoomComboBox.DisplayMember = "RoomNo";
            this.RoomComboBox.FormattingEnabled = true;
            this.RoomComboBox.Location = new System.Drawing.Point(294, 150);
            this.RoomComboBox.Name = "RoomComboBox";
            this.RoomComboBox.Size = new System.Drawing.Size(152, 21);
            this.RoomComboBox.TabIndex = 43;
            this.RoomComboBox.ValueMember = "RoomNo";
            this.RoomComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomComboBox_SelectedIndexChanged_1);
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataMember = "Room";
            this.roomBindingSource1.DataSource = this.ist3bdDataSet;
            // 
            // ist3bdDataSet
            // 
            this.ist3bdDataSet.DataSetName = "ist3bdDataSet";
            this.ist3bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 91);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 42;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(495, 196);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 41;
            this.button3.Text = "BOOK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "DESIRED CHECK IN DATE";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.Cyan;
            this.totalTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.totalTextBox.Location = new System.Drawing.Point(520, 104);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(133, 20);
            this.totalTextBox.TabIndex = 38;
            this.totalTextBox.Text = "R0";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "TOTAL COST :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "choose your desired room";
            // 
            // numOfDayatextBox
            // 
            this.numOfDayatextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.numOfDayatextBox.Location = new System.Drawing.Point(294, 53);
            this.numOfDayatextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOfDayatextBox.Name = "numOfDayatextBox";
            this.numOfDayatextBox.Size = new System.Drawing.Size(151, 20);
            this.numOfDayatextBox.TabIndex = 34;
            this.numOfDayatextBox.TextChanged += new System.EventHandler(this.numOfDayatextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Number of days to stay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(310, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "MAKE A BOOKING";
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(848, 25);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(57, 19);
            this.bckButton.TabIndex = 33;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // roomTableAdapter1
            // 
            this.roomTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // bookingsTableAdapter1
            // 
            this.bookingsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dataSet1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox5.Location = new System.Drawing.Point(45, 58);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 20);
            this.textBox5.TabIndex = 44;
            // 
            // BOOKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(983, 750);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BOOKING";
            this.Text = "BOOKING";
            this.Load += new System.EventHandler(this.BOOKING_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist3bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srchTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numOfDayatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bckButton;
        private DataSet1TableAdapters.RoomTableAdapter roomTableAdapter1;
        private DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        //private DataSet1TableAdapters.Room1TableAdapter room1TableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private DataSet1TableAdapters.BookingsTableAdapter bookingsTableAdapter1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox RoomComboBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private ist3bdDataSet ist3bdDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private ist3bdDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
    }
}