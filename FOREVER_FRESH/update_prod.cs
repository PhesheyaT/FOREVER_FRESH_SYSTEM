using FOREVER_FRESH.GroupWst7DataSetTableAdapters;
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
    public partial class update_prod : Form
    {
        public void set_field(String pid, String pt, String nm, String cst, String salp, String desc, String od_lv, String qnty, String arch)
        {
            textBox1.Text = pid;
            textBox2.Text = pt;
            textBox3.Text = nm;
            textBox4.Text = cst;
            textBox5.Text = salp;
            richTextBox1.Text = desc;
            textBox6.Text = od_lv;
            textBox7.Text = qnty;
            textBox8.Text = arch;

        }
        public update_prod()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_prod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || richTextBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Please fill in all details.");
            }
            else if (textBox8.Text.Length > 10)
            {
                MessageBox.Show("Archieved must be 10 digit or less ");
            }
            else
            {
                productTableAdapter1.UpdateQuery(int.Parse(textBox2.Text),textBox3.Text, Convert.ToDecimal(textBox5.Text), richTextBox1.Text, int.Parse(textBox6.Text), int.Parse(textBox7.Text), textBox8.Text, Convert.ToDecimal(textBox4.Text), int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                MessageBox.Show("Product updated.");
                manage_products m = new manage_products();
                m.Show();
                this.Hide();
            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            manage_products m = new manage_products();
            m.Show();
            this.Hide();
        }
    }
}
