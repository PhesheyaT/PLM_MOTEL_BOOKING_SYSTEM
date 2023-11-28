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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Bookings' table. You can move, or remove it, as needed.
            this.bookingsTableAdapter.Fill(this.dataSet1.Bookings);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bookingsTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
            dataGridView1.Refresh();
        }
    }
}
