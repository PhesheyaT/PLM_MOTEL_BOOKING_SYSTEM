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
    public partial class ROOMS : Form
    {
        public ROOMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SINGLE_ROOMS S = new SINGLE_ROOMS();
            S.Show();
            this.Hide();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DOUBLE_ROOMS h = new DOUBLE_ROOMS();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OTHER_ROOMS h = new OTHER_ROOMS();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADD_NEW_ROOMS h = new ADD_NEW_ROOMS();
            h.Show();
            this.Hide();
        }
    }
}
