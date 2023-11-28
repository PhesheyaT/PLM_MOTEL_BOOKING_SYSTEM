
namespace M2_PLM_MOTEL
{
    partial class PAYMENTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAYMENTS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new M2_PLM_MOTEL.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.srchtextBox = new System.Windows.Forms.TextBox();
            this.bckButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paymentsTableAdapter = new M2_PLM_MOTEL.DataSet1TableAdapters.PaymentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.Name,
            this.RoomNo,
            this.PayType,
            this.PayDate,
            this.Amount});
            this.dataGridView1.DataSource = this.paymentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH BOOKINGS :";
            // 
            // srchtextBox
            // 
            this.srchtextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.srchtextBox.Location = new System.Drawing.Point(344, 17);
            this.srchtextBox.Name = "srchtextBox";
            this.srchtextBox.Size = new System.Drawing.Size(211, 20);
            this.srchtextBox.TabIndex = 12;
            this.srchtextBox.UseWaitCursor = true;
            this.srchtextBox.TextChanged += new System.EventHandler(this.srchtextBox_TextChanged);
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(701, 19);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(75, 23);
            this.bckButton.TabIndex = 16;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Navy;
            this.deleteButton.Location = new System.Drawing.Point(278, 368);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 65);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = " DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "PayID", true));
            this.textBox1.Location = new System.Drawing.Point(12, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 25;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(521, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "VIEW BOOKINGS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            this.payIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
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
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "Room Number";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.HeaderText = "Pay Type";
            this.PayType.Name = "PayType";
            this.PayType.ReadOnly = true;
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            this.PayDate.HeaderText = "Pay Date";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PAYMENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.srchtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            //this.Name = "PAYMENTS";
            this.Text = "PAYMENTS";
            this.Load += new System.EventHandler(this.PAYMENTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srchtextBox;
        private System.Windows.Forms.Button bckButton;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private DataSet1TableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}