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
    public partial class add_new_product : Form
    {
        public add_new_product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reordertextBox4.Text==""|| proidtextBox9.Text==""||namtextBox8.Text==""||richTextBox1.Text==""||costtextBox7.Text==""||quantitytextBox3.Text==""||saletextBox6.Text=="")
            {
                MessageBox.Show("Please fill in all details.");
            }
            else if (!(int.TryParse(proidtextBox9.Text, out Int32 y)))
            {
                MessageBox.Show("Product type must only contain digits.");
                proidtextBox9.Focus();
                return;
            }
            else if (!(int.TryParse(reordertextBox4.Text, out Int32 r)))
            {
                MessageBox.Show("Order level must be in digits.");
                reordertextBox4.Focus();
                return;
            }
            else if (!(int.TryParse(quantitytextBox3.Text, out Int32 s)))
            {
                MessageBox.Show("Quantity must be in digits.");
                quantitytextBox3.Focus();
                return;
            }
            else if (comboBox1.Text.Trim().Equals("--select archieve--"))
            {
                MessageBox.Show("Select archieve to continue.");
                comboBox1.Focus();
                return;
            }
            else
            {
                productTableAdapter1.InsertQuery(int.Parse(proidtextBox9.Text), namtextBox8.Text, Convert.ToDecimal(saletextBox6.Text), richTextBox1.Text, int.Parse(reordertextBox4.Text),int.Parse(quantitytextBox3.Text),comboBox1.Text, Convert.ToDecimal(costtextBox7.Text));
                MessageBox.Show("Product inserted.");
                manage_products m = new manage_products();
                m.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manage_products m = new manage_products();
            m.Show();
            this.Hide();
        }

        private void add_new_product_Load(object sender, EventArgs e)
        {

        }
    }
}
