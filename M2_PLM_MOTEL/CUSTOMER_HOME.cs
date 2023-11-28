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
using System.Security.Cryptography;

namespace M2_PLM_MOTEL
{
    public partial class CUSTOMER_HOME : Form
    {
        public CUSTOMER_HOME()
        {
            InitializeComponent();
            this.customerTableAdapter.Fill(dataSet1.Customer);
        }

        SqlConnection con = new SqlConnection("Data Source = 146.230.177.46\\istn3; Initial Catalog = ist3bd; User ID = ist3bd; Password=8grix6");

        int cID;
        string cNm, em, gen, pass, phn;
       

        private void srchTextBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string querry = "";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            customerTableAdapter.FillBySearch(dataSet1.Customer , srchTextBox.Text);

            //FiLLING  TEXTBOXES 
            DataSet1.CustomerDataTable DT = new DataSet1.CustomerDataTable();
            customerTableAdapter.Fill(DT);
            foreach(DataRow row in dt.Rows)
            {
                custIDTextBox.Text = row.Field<int>("CustID").ToString();
            }
            
            custDataGridView.Refresh();

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_NEW_CUSTOMER ad = new ADD_NEW_CUSTOMER();
            ad.Show();
            this.Hide();
        }

        private void rfrshButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(dataSet1.Customer);
           
            custDataGridView.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            customerTableAdapter.DeleteQuery(int.Parse(custIDTextBox.Text));
            custDataGridView.Refresh();

            CUSTOMER_HOME CH = new CUSTOMER_HOME();
            CH.Show();

        }

        private void CUSTOMER_HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void updtButton_Click(object sender, EventArgs e)
        {
            UPDATE_CUSTOMER y = new UPDATE_CUSTOMER();
            y.setUpdate(int.Parse(custIDTextBox.Text) , custPassTextBox.Text, custEmTextBox.Text, textBox2.Text, textBox3.Text , textBox1.Text);
            y.Show();
            this.Hide();

        }
        //int ccID = int.Parse(custIDTextBox.Text);
        //string cNm = custPassTextBox.Text;
        //string em = custEmTextBox.Text;
        //string gen = textBox2.Text;
        //string pass = passtextBox.Text;
        //string phn = textBox1.Text;

        private void vbkngButton_Click(object sender, EventArgs e)
        {
            VIEW_BOOKINGS VB = new VIEW_BOOKINGS();
            VB.Show();
            this.Hide();
        }

        
    }
}
