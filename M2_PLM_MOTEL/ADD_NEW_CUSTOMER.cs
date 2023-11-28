using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2_PLM_MOTEL
{
    public partial class ADD_NEW_CUSTOMER : Form
    {
        public ADD_NEW_CUSTOMER()
        {
            InitializeComponent();
        }     
       
        private void bckButton_Click(object sender, EventArgs e)
        {

            CUSTOMER_HOME h = new CUSTOMER_HOME();
            h.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phn = phntextBox4.Text.Trim();
           

            string fp = passtextBox2.Text; string sp = passtextBox3.Text;

            if (nametextBox1.Text == "" || passtextBox2.Text == "" || passtextBox3.Text==""|| phntextBox4.Text == "" || nametextBox1.Text == "" || gendertextBox.Text == "")
            {
                MessageBox.Show("Please fill in all the missing details , and try again.");
                return;
            }
            else if((phntextBox4.Text.ToString()).Length != 10)
            {
                MessageBox.Show("Invalid cell phone details. Phune number must have 10 digits only");
                phntextBox4.Focus();
                return;
            }
            else if (!(phn[0].Equals('0')))
            {
                MessageBox.Show("Invalid cell phone details. Phune number must start with zero");
                phntextBox4.Focus();
                return;
            } 
            else if (!(int.TryParse(phn, out Int32 x)))
            {
                MessageBox.Show("Phone number must only cotain digits");
                phntextBox4.Focus();
                return;
            }
            else if (!(fp == sp))
            {
                MessageBox.Show("Passwords do not match , validate passwords and try again.");
                passtextBox3.Focus();
                return;
            }
            try
            {
                var c = customerTableAdapter.GetDataByEmPass(nametextBox1.Text, passtextBox3.Text);
        
                if (c.Rows.Count > 0)
                {
                    MessageBox.Show("This customer already exist , try using unique details");
                    return;
                }
                else
                {
                    customerTableAdapter.InsertQuery(emtextBox1.Text , passtextBox2.Text , phntextBox4.Text , nametextBox1.Text , gendertextBox.Text);
                    MessageBox.Show("New customer Inserted successfully");
                    CUSTOMER_HOME C = new CUSTOMER_HOME(); C.Show(); this.Hide();
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
             
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ADD_NEW_CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}
