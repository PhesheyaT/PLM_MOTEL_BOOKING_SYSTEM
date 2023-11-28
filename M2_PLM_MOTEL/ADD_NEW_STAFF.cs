using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace M2_PLM_MOTEL
{
    public partial class ADD_NEW_STAFF : Form
    {
        public ADD_NEW_STAFF()
        {
            InitializeComponent();
        }

        private void AAD_NEW_STAFF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);

        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            STAFF_HOME h = new STAFF_HOME();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phn = phntextBox.Text.Trim();
            string em = emtextBox1.Text.Trim();


            string fp = passtextBox.Text; string sp = cnfrmPasstextBox.Text;

            if (emtextBox1.Text == "" || passtextBox.Text == "" || cnfrmPasstextBox.Text == "" || phntextBox.Text == "" || jobTtextBox.Text == "")
            {
                MessageBox.Show("Please fill in all the missing details , and try again.");
                return;
            }
            else if ((phntextBox.Text.ToString()).Length != 10)
            {
                MessageBox.Show("Invalid cell phone details. Phune number must have 10 digits only");
                phntextBox.Focus();
                return;
            }
            else if (!(phn[0].Equals('0')))
            {
                MessageBox.Show("Invalid cell phone details. Phune number must start with zero");
                phntextBox.Focus();
                return;
            }
            else if (em.Count(f => (f == '.')) != 1 || (em.Count(f => (f == '@')) != 1))
            {

                MessageBox.Show("Invalid email adress. Check email ");
                phntextBox.Focus();
                return;
            }
            else if (!(int.TryParse(phn, out Int32 x)))
            {
                MessageBox.Show("Phone number must only cotain digits");
                phntextBox.Focus();
                return;
            }
            else if (!(fp == sp))
            {
                MessageBox.Show("Passwords do not match , validate passwords and try again.");
                passtextBox.Focus();
                return;
            }
            try
            {
                var S = staffTableAdapter.GetDataByEmPass(emtextBox1.Text, passtextBox.Text);

                if (S.Rows.Count > 0)
                {
                    MessageBox.Show("The staff member with this email and password already exist , try using unique details");
                    return;
                }
                else
                {
                    staffTableAdapter.InsertQuery(nmetextBox.Text, emtextBox1.Text, phntextBox.Text, jobTtextBox.Text, passtextBox.Text);
                    MessageBox.Show("New staff Inserted successfully");
                    STAFF_HOME C = new STAFF_HOME(); C.Show(); this.Hide();
                }

                STAFF_HOME SM = new STAFF_HOME();
                SM.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       
    }
}
