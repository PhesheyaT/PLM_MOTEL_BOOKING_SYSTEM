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
    public partial class STAFF_HOME : Form
    {
        public void fillTxtBox()
        {
           
        }
        public STAFF_HOME()
        {
            InitializeComponent();
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            dataGridView1.Refresh();
        }

        private void addSfbutton_Click(object sender, EventArgs e)
        {
            ADD_NEW_STAFF S = new ADD_NEW_STAFF();
            S.Show();
            this.Hide();
        }

        private void rfrshbutton_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            dataGridView1.Refresh();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void srchtextBox_TextChanged(object sender, EventArgs e)
        {
            this.staffTableAdapter.FillBySearchStaff(this.dataSet1.Staff , srchtextBox.Text);

        }

        private void STAFF_HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            // TODO: This line of code loads data into the 'dataSet11.Staff' table. You can move, or remove it, as needed.
            

        }

        private void updSfbutton_Click(object sender, EventArgs e)
        {
            UPDATE_STAFF U = new UPDATE_STAFF ();
            U.setUpdate(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text , textBox6.Text);
            U.Show();
            
            this.Hide();
        }  

        private void deleteButton_Click(object sender, EventArgs e)
        {
            staffTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
            dataGridView1.Refresh();

            STAFF_HOME S = new STAFF_HOME();
            S.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
