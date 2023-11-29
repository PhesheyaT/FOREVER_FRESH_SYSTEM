using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREVER_FRESH
{
    public partial class man_staff : Form
    {
        public man_staff()
        {
            InitializeComponent();
        }

    

        private void man_staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.groupWst7DataSet.Employee);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.groupWst7DataSet.Employee);
            employeeTableAdapter.Fill(groupWst7DataSet.Employee);
            passtextBox3.Hide();
            achievetextBox9.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager_home mh = new manager_home();
            mh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_staff u = new update_staff();
            u.set_fields(idtextBox2.Text, nametextBox4.Text, lnametextBox5.Text, emtextBox6.Text, phonetextBox7.Text, towntextBox8.Text, achievetextBox9.Text, passtextBox3.Text);
            u.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_staff a = new add_staff();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.DeleteQuery(idtextBox2.Text);
            MessageBox.Show("Staff Deleted");
            man_staff m = new man_staff();
            m.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            employeeTableAdapter.FillBySRCH(groupWst7DataSet.Employee, textBox1.Text);
        }

       
        private void phonetextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
