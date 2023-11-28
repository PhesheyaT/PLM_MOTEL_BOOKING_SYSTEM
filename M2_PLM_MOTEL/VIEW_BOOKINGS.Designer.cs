
namespace M2_PLM_MOTEL
{
    partial class VIEW_BOOKINGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_BOOKINGS));
            this.label1 = new System.Windows.Forms.Label();
            this.srchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new M2_PLM_MOTEL.DataSet1();
            this.bckButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.bookingsTableAdapter = new M2_PLM_MOTEL.DataSet1TableAdapters.BookingsTableAdapter();
            this.bookingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEARCH BOOKINGS :";
            // 
            // srchtextBox
            // 
            this.srchtextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.srchtextBox.Location = new System.Drawing.Point(297, 20);
            this.srchtextBox.Name = "srchtextBox";
            this.srchtextBox.Size = new System.Drawing.Size(211, 20);
            this.srchtextBox.TabIndex = 11;
            this.srchtextBox.UseWaitCursor = true;
            this.srchtextBox.TextChanged += new System.EventHandler(this.srchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.checkInDataGridViewTextBoxColumn,
            this.checkOutDataGridViewTextBoxColumn,
            this.payIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 348);
            this.dataGridView1.TabIndex = 12;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(781, 23);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(75, 23);
            this.bckButton.TabIndex = 15;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 548);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 27;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteButton.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Navy;
            this.deleteButton.Location = new System.Drawing.Point(260, 525);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 65);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = " DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // bookingsBindingSource1
            // 
            this.bookingsBindingSource1.DataMember = "Bookings";
            this.bookingsBindingSource1.DataSource = this.dataSet1;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // checkInDataGridViewTextBoxColumn
            // 
            this.checkInDataGridViewTextBoxColumn.DataPropertyName = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.HeaderText = "CheckIn";
            this.checkInDataGridViewTextBoxColumn.Name = "checkInDataGridViewTextBoxColumn";
            // 
            // checkOutDataGridViewTextBoxColumn
            // 
            this.checkOutDataGridViewTextBoxColumn.DataPropertyName = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.HeaderText = "CheckOut";
            this.checkOutDataGridViewTextBoxColumn.Name = "checkOutDataGridViewTextBoxColumn";
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "PayID";
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            // 
            // VIEW_BOOKINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srchtextBox);
            this.Controls.Add(this.label1);
            this.Name = "VIEW_BOOKINGS";
            this.Text = "VIEW_BOOKINGS";
            this.Load += new System.EventHandler(this.VIEW_BOOKINGS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bckButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteButton;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DataSet1TableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookingsBindingSource1;
    }
}