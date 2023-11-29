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
    public partial class order_line : Form
    {
        public order_line()
        {
            InitializeComponent();
        }

        private void order_LineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_LineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst7DataSet);

        }

        private void order_line_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.Order_Line' table. You can move, or remove it, as needed.
            this.order_LineTableAdapter.Fill(this.groupWst7DataSet.Order_Line);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private int get_last_order()
        {
            int last_order = 0;
            DataTable dt = new DataTable();
            order_LineTableAdapter.Fill(groupWst7DataSet.Order_Line);
            dt = groupWst7DataSet.Order_Line;

            foreach (DataRow dr in dt.Rows)
            {
                last_order = dr.Field<int>("OrderNumber");
            }

            return last_order;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_LineTableAdapter.DeleteQuery(int.Parse(ordernotextBox1.Text));
            /*try
            {
                order_LineTableAdapter.UpdateQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            MessageBox.Show("Order Completed.");

            order_line h = new order_line();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            order_LineTableAdapter.FillBySRCH(groupWst7DataSet.Order_Line, textBox1.Text);
        }
    }
}
