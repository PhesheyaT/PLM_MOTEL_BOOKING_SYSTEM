
namespace M2_PLM_MOTEL
{
    partial class ADD_NEW_CUSTOMER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_NEW_CUSTOMER));
            this.bckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.passtextBox2 = new System.Windows.Forms.TextBox();
            this.passtextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phntextBox4 = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new M2_PLM_MOTEL.DataSet1TableAdapters.CustomerTableAdapter();
            this.dataSet1 = new M2_PLM_MOTEL.DataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emtextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gendertextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bckButton
            // 
            this.bckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bckButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckButton.ForeColor = System.Drawing.Color.Navy;
            this.bckButton.Location = new System.Drawing.Point(713, 12);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(75, 23);
            this.bckButton.TabIndex = 14;
            this.bckButton.Text = "BACK";
            this.bckButton.UseVisualStyleBackColor = false;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(259, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADD NEW CUSTOMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "EMAIL ADDRESS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "PASSWORD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "CONFIRM PASSWORD :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(244, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADD NEW CUSTOMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(344, 87);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(159, 20);
            this.nametextBox1.TabIndex = 22;
            // 
            // passtextBox2
            // 
            this.passtextBox2.Location = new System.Drawing.Point(344, 224);
            this.passtextBox2.Name = "passtextBox2";
            this.passtextBox2.Size = new System.Drawing.Size(159, 20);
            this.passtextBox2.TabIndex = 23;
            // 
            // passtextBox3
            // 
            this.passtextBox3.Location = new System.Drawing.Point(344, 269);
            this.passtextBox3.Name = "passtextBox3";
            this.passtextBox3.Size = new System.Drawing.Size(159, 20);
            this.passtextBox3.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "PHONE NUMBER :";
            // 
            // phntextBox4
            // 
            this.phntextBox4.Location = new System.Drawing.Point(344, 316);
            this.phntextBox4.Name = "phntextBox4";
            this.phntextBox4.Size = new System.Drawing.Size(159, 20);
            this.phntextBox4.TabIndex = 26;
            this.phntextBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            // 
            // emtextBox1
            // 
            this.emtextBox1.Location = new System.Drawing.Point(344, 135);
            this.emtextBox1.Name = "emtextBox1";
            this.emtextBox1.Size = new System.Drawing.Size(159, 20);
            this.emtextBox1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "GENDER :";
            // 
            // gendertextBox
            // 
            this.gendertextBox.Location = new System.Drawing.Point(344, 179);
            this.gendertextBox.Name = "gendertextBox";
            this.gendertextBox.Size = new System.Drawing.Size(159, 20);
            this.gendertextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "NAME :";
            // 
            // ADD_NEW_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gendertextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emtextBox1);
            this.Controls.Add(this.phntextBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passtextBox3);
            this.Controls.Add(this.passtextBox2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bckButton);
            this.Name = "ADD_NEW_CUSTOMER";
            this.Text = "ADD_NEW_CUSTOMER";
            this.Load += new System.EventHandler(this.ADD_NEW_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.TextBox passtextBox2;
        private System.Windows.Forms.TextBox passtextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phntextBox4;
        private DataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.TextBox emtextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gendertextBox;
        private System.Windows.Forms.Label label6;
    }
}