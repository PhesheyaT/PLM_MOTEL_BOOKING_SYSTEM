using M2_PLM_MOTEL.DataSet1TableAdapters;
using M2_PLM_MOTEL.ist3bdDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace M2_PLM_MOTEL
{
    public partial class CONFIRM_PAYMENTS : Form
    {
        public CONFIRM_PAYMENTS()
        {
            InitializeComponent();
        }

        double nOd;
        public void cfPay(int cID, string cName, int rNo, decimal amm, string checkIn, double nod)
        {
            IDtextBox3.Text = cID.ToString();
            nametextBox1.Text = cName.ToString();
            textBox1.Text = rNo.ToString();
            textBox3.Text = amm.ToString();
            textBox2.Text = checkIn.ToString();
            nOd = nod;
        }


        string cOut;

        private void bckButton_Click(object sender, EventArgs e)
        {
            BOOKING h = new BOOKING();
            h.Show();
            this.Hide();
        }

        private void CONFIRM_PAYMENTS_Load(object sender, EventArgs e)
        {

        } 

        double pID;
        //get last payment ID
        public double getPayID()
        {
           
            DataSet1.PaymentsDataTable pd = new DataSet1.PaymentsDataTable();
            paymentsTableAdapter1.Fill(pd);
            
            foreach (DataRow row in pd.Rows)
            {
                pID = row.Field<int>("PayID"); 
                pID = Convert.ToDouble(pID);
            }

            return pID;
        }
        string checkOut, lastPaymentID;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem.ToString() == "" || textBox1.Text == "" || IDtextBox3.Text == "" || textBox3.Text == "" || nametextBox1.Text == "")
                {
                    MessageBox.Show("Please fill in all the missing details , and try again.");
                    return;
                }
                else if(comboBox1.SelectedItem.ToString() == "EFT")
                {
                    string w = comboBox1.SelectedItem.ToString();
                    paymentsTableAdapter1.InsertQuery(int.Parse(IDtextBox3.Text), int.Parse(textBox1.Text), w, DateTime.Now, Convert.ToDecimal(textBox3.Text));
                    MessageBox.Show("Payment successfull.");
                    cOut = (Convert.ToDateTime(textBox2.Text).AddDays(nOd)).ToString();
                    checkOut = cOut.Substring(0, 10);
                    lastPaymentID = getPayID().ToString();
                 
                    bookingsTableAdapter1.InsertBooking(int.Parse(IDtextBox3.Text) , int.Parse(textBox1.Text) , Convert.ToDateTime(textBox2.Text) , Convert.ToDateTime(checkOut ), lastPaymentID);
                    MessageBox.Show("Room booked successfully.");
                    PAYMENTS P = new PAYMENTS();
                    P.Show();
                }
                else if(comboBox1.SelectedItem.ToString() == "CASH")
                {
                    string w = comboBox1.SelectedItem.ToString();
                    paymentsTableAdapter1.InsertQuery(int.Parse(IDtextBox3.Text), int.Parse(textBox1.Text), w, DateTime.Now, Convert.ToDecimal(textBox3.Text));
                    MessageBox.Show("Payment successfull.");
                    cOut = (Convert.ToDateTime(textBox2.Text).AddDays(nOd)).ToString();
                    checkOut = cOut.Substring(0, 10);
                    lastPaymentID = getPayID().ToString();

                    bookingsTableAdapter1.InsertBooking(int.Parse(IDtextBox3.Text), int.Parse(textBox1.Text), Convert.ToDateTime(textBox2.Text), Convert.ToDateTime(checkOut), lastPaymentID);
                    MessageBox.Show("Room booked successfully.");
                    PAYMENTS P = new PAYMENTS();
                    P.Show();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
