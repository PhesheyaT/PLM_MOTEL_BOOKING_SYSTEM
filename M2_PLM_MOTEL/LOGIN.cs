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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = 146.230.177.46\\istn3; Initial Catalog = ist3bd; User ID = ist3bd; Password=8grix6");

        private void cancelButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string querry = "SELECT * FROM customer WHERE Email = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "' ";
            //SqlCommand cmd = new SqlCommand(querry, con);

            DataTable dt = new DataTable();
            customerTableAdapter1.FillBy(dataSet1.Customer, textBox1.Text, textBox2.Text);
            dt = dataSet1.Customer;
            //int c = int.Parse(customerTableAdapter.GetLogInBy(textBox1.Text, textBox2.Text).ToString());

            try
            {
                if (dt.Rows.Count > 0)
                {
                    Home m = new Home();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login error, Please confirm your details.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //con.Close();

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
