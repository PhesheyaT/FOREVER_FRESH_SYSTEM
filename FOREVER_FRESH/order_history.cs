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
    public partial class order_history : Form
    {
        public order_history()
        {
            InitializeComponent();
            panel1.Hide();
        }
        
        public order_history(Boolean b) {
            InitializeComponent();
            panel1.Show();
            button1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void order_history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.groupWst7DataSet.ORDERS);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            oRDERSTableAdapter.FillBySrch(groupWst7DataSet.ORDERS, textBox7.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             manager_home m = new manager_home();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("First select order to delete.");
            }
            else
            {
                try
                {
                    oRDERSTableAdapter.DeleteQuery(int.Parse(textBox1.Text));
                    MessageBox.Show("Order deleted.");
                    order_history o = new order_history(true);
                    o.Show();
                    this.Close();
   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
