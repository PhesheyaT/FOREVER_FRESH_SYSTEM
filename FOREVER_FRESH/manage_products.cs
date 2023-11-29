using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREVER_FRESH
{
    public partial class manage_products : Form
    {
        public manage_products()
        {
            InitializeComponent();
        }

       

        private void manage_products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.groupWst7DataSet.Product);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.groupWst7DataSet.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager_home m = new manager_home();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_new_product a = new add_new_product();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_prod up = new update_prod();
            up.set_field(idtextBox1.Text, proidtextBox9.Text, namtextBox8.Text, costtextBox7.Text, saletextBox6.Text, richTextBox1.Text, reordertextBox4.Text, quantitytextBox3.Text, archievedtextBox2.Text);
            up.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productTableAdapter.DeleteQuery(int.Parse(idtextBox1.Text));
            MessageBox.Show("Product deleted");
            manage_products m = new manage_products();
            m.Show();
            this.Hide();
        }

        private void srchtextBox1_TextChanged(object sender, EventArgs e)
        {
            productTableAdapter.FillBySRCH(groupWst7DataSet.Product, idtextBox1.Text);
            
        }
    }
}
