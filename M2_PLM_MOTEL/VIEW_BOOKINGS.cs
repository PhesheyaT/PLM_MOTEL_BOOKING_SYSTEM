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
    public partial class VIEW_BOOKINGS : Form
    {
        public VIEW_BOOKINGS()
        {
            InitializeComponent();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            CUSTOMER_HOME h = new CUSTOMER_HOME();
            h.Show();
            this.Hide();
        }

        private void srchtextBox_TextChanged(object sender, EventArgs e)
        {
            this.bookingsTableAdapter.FillBySrch(dataSet1.Bookings, srchtextBox.Text);
        }

        private void VIEW_BOOKINGS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.dataSet1.Bookings);
            // TODO: This line of code loads data into the 'dataSet1.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.dataSet1.Bookings);

        }

        private void bookingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bookingsTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
            dataGridView1.Refresh();

            VIEW_BOOKINGS VB = new VIEW_BOOKINGS();
            VB.Show();
        }
    }
}
