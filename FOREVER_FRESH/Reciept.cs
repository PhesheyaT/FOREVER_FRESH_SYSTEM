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
    public partial class Reciept : Form
    {
        public Reciept(String s , String rn)
        {
            InitializeComponent();
            orderlabel10.Text = s;
            label2.Text = rn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reciept printed successfully");
            this.Hide();
            ORDERS o = new ORDERS();
            o.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }

        private void orderlabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
