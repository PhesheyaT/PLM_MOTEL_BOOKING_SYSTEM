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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAYMENTS P = new PAYMENTS();
            P.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CUSTOMER_HOME C = new CUSTOMER_HOME();
            C.Show();
            this.Hide();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            BOOKING B = new BOOKING();
            B.Show();
            this.Hide();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            STAFF_HOME S = new STAFF_HOME();
            S.Show();
            this.Hide();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            ROOMS R = new ROOMS();
            R.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            LOGIN R = new LOGIN();
            R.Show();
            this.Hide();
        }
    }
}
