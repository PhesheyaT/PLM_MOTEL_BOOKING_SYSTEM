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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M2_PLM_MOTEL
{
    public partial class UPDATE_STAFF : Form
    {
        public UPDATE_STAFF()
        {
            InitializeComponent();
        }


      
        SqlConnection cn = new SqlConnection("Data Source = 146.230.177.46\\istn3; Initial Catalog = ist3bd; User ID = ist3bd; Password=8grix6");

        public void setUpdate(int cID, string cNm, string em, string gen,  string phn , string pass)
        {
            IDtextBox3.Text = cID.ToString();
            NametextBox2.Text = cNm;
            emtextBox1.Text = em;
            JTtextBox1.Text = gen;
            PasstextBox6.Text = pass;
            CPasstextBox4.Text = pass;
            phntextBox.Text = phn;
        }

        private void bckButton_Click(object sender, EventArgs e)
        {

            STAFF_HOME h = new STAFF_HOME();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phn = phntextBox.Text.Trim();
            string em = emtextBox1.Text.Trim();


            string fp = PasstextBox6.Text; string sp = PasstextBox6.Text;

            if (emtextBox1.Text == "" || PasstextBox6.Text == "" || CPasstextBox4.Text == "" || phntextBox.Text == "" || NametextBox2.Text=="" || IDtextBox3.Text=="" || JTtextBox1.Text=="")
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
                var c = staffTableAdapter1.GetDataByID(int.Parse(IDtextBox3.Text));

                if (c.Rows.Count == 0)
                {
                    MessageBox.Show("This staff member is not registered at PLM , Register staff");
                    ADD_NEW_STAFF s = new ADD_NEW_STAFF();
                    s.Show();
                    return;
                }
                else
                {
                    staffTableAdapter1.UpdateQueryByID(NametextBox2.Text , emtextBox1.Text , phntextBox.Text , JTtextBox1.Text , PasstextBox6.Text , int.Parse(IDtextBox3.Text), int.Parse(IDtextBox3.Text));
                    MessageBox.Show("Old Staff Updated successfully");
                    STAFF_HOME C = new STAFF_HOME(); C.Show(); this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
