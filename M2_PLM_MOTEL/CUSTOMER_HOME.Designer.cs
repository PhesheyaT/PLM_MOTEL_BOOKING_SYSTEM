
namespace M2_PLM_MOTEL
{
    partial class CUSTOMER_HOME
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSTOMER_HOME));
            this.label1 = new System.Windows.Forms.Label();
            this.srchTextBox = new System.Windows.Forms.TextBox();
            this.custDataGridView = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new M2_PLM_MOTEL.DataSet1();
            this.addCustButton = new System.Windows.Forms.Button();
            this.updtButton = new System.Windows.Forms.Button();
            this.rfrshButton = new System.Windows.Forms.Button();
            this.vbkngButton = new System.Windows.Forms.Button();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.custEmTextBox = new System.Windows.Forms.TextBox();
            this.custPassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bckButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new M2_PLM_MOTEL.DataSet1TableAdapters.CustomerTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH CUSTOMER :";
            // 
            // srchTextBox
            // 
            this.srchTextBox.BackColor = System.Drawing.Color.PowderBlue;
            this.srchTextBox.Location = new System.Drawing.Point(277, 31);
            this.srchTextBox.Name = "srchTextBox";
            this.srchTextBox.Size = new System.Drawing.Size(156, 20);
            this.srchTextBox.TabIndex = 1;
            this.srchTextBox.Text = "search";
            this.srchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.srchTextBox.UseWaitCursor = true;
            this.srchTextBox.TextChanged += new System.EventHandler(this.srchTextBox_TextChanged);
            // 
            // custDataGridView
            // 
            this.custDataGridView.AllowUserToAddRows = false;
            this.custDataGridView.AutoGenerateColumns = false;
            this.custDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.custDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.custDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.Name,
            this.Email,
            this.Gender,
            this.Phone});
            this.custDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDataGridView.DataSource = this.customerBindingSource;
            this.custDataGridView.GridColor = System.Drawing.Color.PowderBlue;
            this.custDataGridView.Location = new System.Drawing.Point(23, 74);
            this.custDataGridView.Name = "custDataGridView";
            this.custDataGridView.ReadOnly = true;
            this.custDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custDataGridView.Size = new System.Drawing.Size(591, 274);
            this.custDataGridView.StandardTab = true;
            this.custDataGridView.TabIndex = 2;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addCustButton
            // 
            this.addCustButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addCustButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustButton.ForeColor = System.Drawing.Color.Navy;
            this.addCustButton.Location = new System.Drawing.Point(142, 368);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(95, 71);
            this.addCustButton.TabIndex = 3;
            this.addCustButton.Text = "ADD NEW";
            this.addCustButton.UseVisualStyleBackColor = false;
            this.addCustButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updtButton
            // 
            this.updtButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updtButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtButton.ForeColor = System.Drawing.Color.Navy;
            this.updtButton.Location = new System.Drawing.Point(396, 368);
            this.updtButton.Name = "updtButton";
            this.updtButton.Size = new System.Drawing.Size(89, 71);
            this.updtButton.TabIndex = 4;
            this.updtButton.Text = "UPDATE OLD";
            this.updtButton.UseVisualStyleBackColor = false;
            this.updtButton.Click += new System.EventHandler(this.updtButton_Click);
            // 
            // rfrshButton
            // 
            this.rfrshButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rfrshButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfrshButton.ForeColor = System.Drawing.Color.Navy;
            this.rfrshButton.Location = new System.Drawing.Point(23, 367);
            this.rfrshButton.Name = "rfrshButton";
            this.rfrshButton.Size = new System.Drawing.Size(91, 72);
            this.rfrshButton.TabIndex = 5;
            this.rfrshButton.Text = "REFRESH";
            this.rfrshButton.UseVisualStyleBackColor = false;
            this.rfrshButton.Click += new System.EventHandler(this.rfrshButton_Click);
            // 
            // vbkngButton
            // 
            this.vbkngButton.BackColor = System.Drawing.Color.SteelBlue;
            this.vbkngButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbkngButton.ForeColor = System.Drawing.Color.Navy;
            this.vbkngButton.Location = new System.Drawing.Point(513, 367);
            this.vbkngButton.Name = "vbkngButton";
            this.vbkngButton.Size = new System.Drawing.Size(92, 71);
            this.vbkngButton.TabIndex = 6;
            this.vbkngButton.Text = "VIEW BOOKINGS";
            this.vbkngButton.UseVisualStyleBackColor = false;
            this.vbkngButton.Click += new System.EventHandler(this.vbkngButton_Click);
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustID", true));
            this.custIDTextBox.Location = new System.Drawing.Point(620, 104);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.Size = new System.Drawing.Size(168, 20);
            this.custIDTextBox.TabIndex = 7;
            // 
            // custEmTextBox
            // 
            this.custEmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.custEmTextBox.Location = new System.Drawing.Point(620, 172);
            this.custEmTextBox.Name = "custEmTextBox";
            this.custEmTextBox.Size = new System.Drawing.Size(168, 20);
            this.custEmTextBox.TabIndex = 8;
            // 
            // custPassTextBox
            // 
            this.custPassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.custPassTextBox.Location = new System.Drawing.Point(620, 240);
            this.custPassTextBox.Name = "custPassTextBox";
            this.custPassTextBox.Size = new System.Drawing.Size(168, 20);
            this.custPassTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CUSTOMER ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CUSTOMER EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CUSTOMER PHONE";
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(702, 12);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(75, 23);
            this.bckButton.TabIndex = 13;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CUSTOMER NAME";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.textBox1.Location = new System.Drawing.Point(620, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Gender", true));
            this.textBox2.Location = new System.Drawing.Point(620, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Password", true));
            this.textBox3.Location = new System.Drawing.Point(620, 434);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "PASSWORD";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Navy;
            this.deleteButton.Location = new System.Drawing.Point(277, 368);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 71);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CUSTOMER_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custPassTextBox);
            this.Controls.Add(this.custEmTextBox);
            this.Controls.Add(this.custIDTextBox);
            this.Controls.Add(this.vbkngButton);
            this.Controls.Add(this.rfrshButton);
            this.Controls.Add(this.updtButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.custDataGridView);
            this.Controls.Add(this.srchTextBox);
            //this.Name = "CUSTOMER_HOME";
            this.Text = "CUSTOMER_HOME";
            this.Load += new System.EventHandler(this.CUSTOMER_HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srchTextBox;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Button updtButton;
        private System.Windows.Forms.Button rfrshButton;
        private System.Windows.Forms.Button vbkngButton;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox custEmTextBox;
        private System.Windows.Forms.TextBox custPassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button bckButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView custDataGridView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}