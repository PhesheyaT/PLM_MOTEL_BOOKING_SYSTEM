using M2_PLM_MOTEL.DataSet1TableAdapters;
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
    public partial class ADD_NEW_ROOMS : Form
    {
        public ADD_NEW_ROOMS()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rn = textBox.Text;
                string prc = textBox3.Text;

                if (comboBox1.SelectedValue.ToString() == "" || comboBox2.SelectedValue.ToString() == "" || textBox3.Text == "" || textBox.Text == "")
                {
                    MessageBox.Show("Please fill in all the missing details , and try again.");
                    return;
                }
                else if (!(int.TryParse(rn, out Int32 x)))
                {
                    MessageBox.Show("Room number must only cotain digits");
                    textBox.Focus();
                    return;
                }
                else if (!(int.TryParse(prc, out Int32 y)))
                {
                    MessageBox.Show("Room price must only cotain digits");
                    textBox3.Focus();
                    return;
                }

                roomTableAdapter1.InsertQuery(int.Parse(textBox.Text), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), int.Parse(textBox3.Text));
                MessageBox.Show("New room succesfully addad .");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            ROOMS h = new ROOMS();
            h.Show();
            this.Hide();
        }

        private void ADD_NEW_ROOMS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter1.Fill(this.dataSet1.Room);

        }
    }
}
