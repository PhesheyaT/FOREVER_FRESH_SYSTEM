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
    public partial class manager_home : Form
    {
        public manager_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_products m = new manage_products();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order_history oh = new order_history(true);
            oh.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            man_staff ms = new man_staff();
            ms.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            man_cust m = new man_cust();
            m.Show();
            this.Hide();
        }
    }
}
