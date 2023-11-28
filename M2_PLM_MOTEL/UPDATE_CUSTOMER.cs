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
    public partial class UPDATE_CUSTOMER : Form
    {
        public UPDATE_CUSTOMER()
        {
            InitializeComponent();
        }

        public void setUpdate(int cID , string cNm , string em , string gen , string pass , string phn)
        {
            IDtextBox3.Text = cID.ToString();
            NametextBox2.Text = cNm;
            emtextBox1.Text = em;
            textBox1.Text = gen;
            PasstextBox6.Text = pass;
            CPasstextBox4.Text = pass;
            phntextBox.Text = phn;
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            CUSTOMER_HOME h = new CUSTOMER_HOME();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string phn = phntextBox.Text.Trim();
            string em = emtextBox1.Text.Trim();


            string fp = PasstextBox6.Text; string sp = PasstextBox6.Text;

            if (emtextBox1.Text == "" || PasstextBox6.Text == "" || CPasstextBox4.Text == "" || phntextBox.Text == "" || NametextBox2.Text == "" || IDtextBox3.Text == "")
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
                CPasstextBox4.Focus();
                return;
            }
            try
            {
                var v = customerTableAdapter1.GetDataByID(int.Parse(IDtextBox3.Text));

                if (v.Rows.Count == 0)
                {
                    MessageBox.Show("This staff member is not registered at PLM , Register staff");
                    ADD_NEW_STAFF s = new ADD_NEW_STAFF();
                    s.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    customerTableAdapter1.UpdateQuery(emtextBox1.Text,PasstextBox6.Text , phntextBox.Text , NametextBox2.Text , textBox1.Text, int.Parse(IDtextBox3.Text), int.Parse(IDtextBox3.Text)) ;
                    MessageBox.Show("Old Cudtomer Updated successfully");
                    CUSTOMER_HOME C = new CUSTOMER_HOME(); C.Show();this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void UPDATE_CUSTOMER_Load(object sender, EventArgs e)
        {

        }
    }
}
