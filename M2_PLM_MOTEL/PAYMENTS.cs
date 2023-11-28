using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M2_PLM_MOTEL
{
    public partial class PAYMENTS : Form
    {
        public PAYMENTS()
        {
            InitializeComponent();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PAYMENTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.dataSet1.Payments);
            // TODO: This line of code loads data into the 'dataSet1.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.dataSet1.Payments);

        }

        private void srchtextBox_TextChanged(object sender, EventArgs e)
        {
            this.paymentsTableAdapter.FillBySrch(dataSet1.Payments, srchtextBox.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByPayToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymentsTableAdapter.FillByPay(this.dataSet1.Payments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByPayToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.paymentsTableAdapter.FillByPay(this.dataSet1.Payments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            paymentsTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
            dataGridView1.Refresh();

            PAYMENTS P = new PAYMENTS();
            P.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                VIEW_BOOKINGS f = new VIEW_BOOKINGS();
                f.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
