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
    public partial class SINGLE_ROOMS : Form
    {
        public SINGLE_ROOMS()
        {
            InitializeComponent();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            ROOMS h = new ROOMS();
            h.Show();
            this.Hide();
        }
    }
}
