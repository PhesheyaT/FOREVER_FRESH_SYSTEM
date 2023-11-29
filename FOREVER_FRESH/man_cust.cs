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
    public partial class man_cust : Form
    {
        public man_cust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager_home m = new manager_home();
            m.Show();
            this.Hide();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            add_cust a = new add_cust();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_c u = new update_c();
            u.set_vals(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            u.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
            MessageBox.Show("Customer deleted");
            man_cust m = new man_cust();
            m.Show();
            this.Hide();
        }

        private void man_cust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst7DataSet.Customer);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupWst7DataSet.Customer);
            textBox8.Hide();
            textBox9.Hide();

        }
    }
}
