using M2_PLM_MOTEL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M2_PLM_MOTEL
{
    public partial class BOOKING : Form
    {
        public BOOKING()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = 146.230.177.46\\istn3; Initial Catalog = ist3bd; User ID = ist3bd; Password=8grix6");


        private void BOOKING_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist3bdDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.ist3bdDataSet.Room);
            panel2.Visible = false;
            monthCalendar1.MinDate = DateTime.Now;

            List<string> RoomDetList = new List<string>();

            DataSet1.RoomDataTable dt = new DataSet1.RoomDataTable();
            roomTableAdapter1.FillBy(dt);

            foreach (DataRow dr in dt)
            {
                List<string> list = new List<string>();
                list.Add(dr["RoomNo"].ToString());
                list.Add(dr["RoomPrice"].ToString());

                RoomDetList.Add(list.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

            try
            {
                if (srchTextBox.Text == "")
                {
                    MessageBox.Show("Please search for customer to continue.");
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    DialogResult dr = MessageBox.Show("This customer does not exist. Do you wish to add Him/Her ?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ADD_NEW_CUSTOMER AC = new ADD_NEW_CUSTOMER();
                        AC.Show();
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
            catch
            {

            }
        }
        string cIN;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            monthCalendar1.MinDate = DateTime.Now;
            string s = monthCalendar1.SelectionStart.ToString();
            s = s.Substring(0, 10);
            cIN = s;
            textBox5.Text =  Convert.ToDateTime(cIN).ToShortDateString();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //    string em = srchTextBox.Text.Trim();
                //    DataSet1.CustomerDataTable DT = new DataSet1.CustomerDataTable();
                //    customerTableAdapter1.FillByEM(DT, em);
                //    if (srchTextBox.Text == "")
                //    {
                //        MessageBox.Show("Please enter customer email to continue.");
                //    }
                //    if (DT.Rows.Count < 1)
                //    {
                //        DialogResult dl = MessageBox.Show("This customer does not exist. Do you wish to add Him/Her ?", "", MessageBoxButtons.YesNo);
                //        if (dl == DialogResult.Yes)
                //        {
                //            ADD_NEW_CUSTOMER AC = new ADD_NEW_CUSTOMER();
                //            AC.Show();
                //        }

                //    }
               
                if (srchTextBox.Text == "")
                {
                    MessageBox.Show("Please enter customer email to continue.");
                }
                DataSet1.CustomerDataTable d = new DataSet1.CustomerDataTable();
                customerTableAdapter1.Fill(d);
                string email = srchTextBox.Text;

                foreach (DataRow dr in d.Rows)
                {
                    string e1 = dr.Field<string>("Email");

                    if (email.Equals(e1))
                    {
                        textBox1.Text = dr.Field<int>("CustID").ToString();
                        textBox3.Text = dr.Field<string>("Name");
                        textBox2.Text = dr.Field<string>("Gender");
                        textBox4.Text = dr.Field<string>("Phone");
                    }

                }

            }
            catch
            {

            }
        }
        string cNm , price;
        int cID;

        public void getCost()
        {
            try
            {
                double price = 0;
                con.Open();
                string query = "select RoomPrice from Room Where RoomNo = '" + RoomComboBox.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                con.Close();

                price = Convert.ToDouble(dt.Rows[0][0].ToString());
              
                double s = Convert.ToDouble(price) * Convert.ToDouble(numOfDayatextBox.Text);
                string total = "R" + s.ToString();
                totalTextBox.Text = total.ToString();
            }
            catch
            {

            }
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void numOfDayatextBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("First specify the customer to book a room. Search using email.");
                srchTextBox.Focus();
            }
        }
 
        DateTime cOut; bool value;

        public bool isInBetween(int rommNo, DateTime CI, DateTime CO)
        {
            cOut = Convert.ToDateTime((Convert.ToDateTime(textBox5.Text).AddDays(Convert.ToDouble(numOfDayatextBox.Text))));
            DataSet1.BookingsDataTable bdt = new DataSet1.BookingsDataTable();
            bookingsTableAdapter1.FillByCheckDB(bdt, int.Parse(RoomComboBox.Text), Convert.ToDateTime(CI), Convert.ToDateTime(CO));

            if (bdt.Rows.Count > 0)
            {

                value = true;
            }
            else if (bdt.Rows.Count == 0)
            {

                value = false;
            }
            return value;
        }

        public bool isDoubleBooked(int roomNo, DateTime ci, DateTime co)
        {
            if (isInBetween(roomNo, ci, co) == true)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void RoomComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (numOfDayatextBox.Text == "")
            {
                MessageBox.Show("First specify the number days you will stay.");
                numOfDayatextBox.Focus();
            }
            getCost();

        }

        // CHECK DOUBLE BOOKING USING DIFFERENT METHOD

        public void checkDoubleBooking (int roomNo , DateTime ci , DateTime co)
        {
           
            DataSet1.BookingsDataTable dt = new DataSet1.BookingsDataTable();
            bookingsTableAdapter1.FillByCheckDB(dt, roomNo, ci, co);
        

            if (dt.Rows.Count != 0 )
            {
                MessageBox.Show("Double booking ");
            }
            else
            {
                CONFIRM_PAYMENTS c = new CONFIRM_PAYMENTS();
                c.cfPay(int.Parse(textBox1.Text), textBox3.Text, int.Parse(RoomComboBox.Text), Convert.ToDecimal(totalTextBox.Text.Substring(1)), textBox5.Text, Convert.ToDouble(numOfDayatextBox.Text));
                c.Show();
            }
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime checkIn = Convert.ToDateTime(textBox5.Text);

                int rn = Convert.ToInt32(RoomComboBox.SelectedValue);
                cOut = Convert.ToDateTime(textBox5.Text.ToString()).AddDays(int.Parse(numOfDayatextBox.Text));

                ////// DataSet1.BookingsDataTable dt = new DataSet1.BookingsDataTable();
                ////// bookingsTableAdapter1.FillByCheckDB(dt, rn, checkIn, cOut);


                isInBetween(int.Parse(RoomComboBox.Text), checkIn, Convert.ToDateTime(cOut));

                if (isInBetween(int.Parse(RoomComboBox.Text), checkIn, Convert.ToDateTime(cOut)) == true)
                {
                    MessageBox.Show("Double booking , for selected ROOM choose different CheckIn DATE. '\n' For selected DATE choose a different ROOM.");
                }
                else
                {
                    CONFIRM_PAYMENTS c = new CONFIRM_PAYMENTS();
                    c.cfPay(int.Parse(textBox1.Text), textBox3.Text, int.Parse(RoomComboBox.Text), Convert.ToDecimal(totalTextBox.Text.Substring(1)), textBox5.Text, Convert.ToDouble(numOfDayatextBox.Text));
                    c.Show();
                }

                //////checkDoubleBooking(rn, checkIn, cOut);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Double booking , for selected ROOM choose different CheckIn DATE. '\n' For selected DATE choose a different ROOM.");
            }

            
        }
    }
}
