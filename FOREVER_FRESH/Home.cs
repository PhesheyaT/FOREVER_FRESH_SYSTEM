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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORDERS o = new ORDERS();
            o.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order_line o = new order_line();
            o.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order_history o = new order_history();
            o.Show();
            this.Hide();
        }
    }
}
