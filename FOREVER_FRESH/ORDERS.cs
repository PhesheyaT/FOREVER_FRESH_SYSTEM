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
    public partial class ORDERS : Form
    {
        public ORDERS()
        {
            InitializeComponent();
        }

        

        private void ORDERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst7DataSet.Order_Line' table. You can move, or remove it, as needed.
            this.order_LineTableAdapter.Fill(this.groupWst7DataSet.Order_Line);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Order_Line' table. You can move, or remove it, as needed.
            this.order_LineTableAdapter.Fill(this.groupWst7DataSet.Order_Line);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Product_Invoice1' table. You can move, or remove it, as needed.
            this.product_Invoice1TableAdapter.Fill(this.groupWst7DataSet.Product_Invoice1);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.groupWst7DataSet.Product);
            // TODO: This line of code loads data into the 'groupWst7DataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.groupWst7DataSet.ORDERS);
            // TODO: This line of code loads data into the 'groupWst7DataSet.Food_Receipt' table. You can move, or remove it, as needed.
            this.food_ReceiptTableAdapter.Fill(this.groupWst7DataSet.Food_Receipt);
            // TODO: This line of code loads data into the 'groupWst7DataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.groupWst7DataSet.ORDERS);
            // TODO: This line of code loads data into the 'groupWst7DataSet1.Product' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'groupWst7DataSet.Product_Invoice1' table. You can move, or remove it, as needed.
            this.product_Invoice1TableAdapter.Fill(this.groupWst7DataSet.Product_Invoice1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal orderTotal = 0;

            try
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    var cell1Value = dataGridView2.Rows[i].Cells[1].Value;
                    var cell3Value = dataGridView2.Rows[i].Cells[3].Value;

                    if (cell1Value != null && cell3Value != null)
                    {
                        if (decimal.TryParse(cell1Value.ToString(), out decimal cell1Decimal) &&
                          decimal.TryParse(cell3Value.ToString(), out decimal cell3Decimal))
                        {
                            orderTotal += cell1Decimal * cell3Decimal;
                        }

                        else
                        {
                            throw new FormatException($"Invalid numeric format in row {i + 1}.");
                        }
                    }
                }

                ordertextBox7.Text = orderTotal.ToString("0.00");

                decimal vatAmount = orderTotal - (orderTotal / 1.15m);
                vattextBox.Text = vatAmount.ToString("0.00");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ordertextBox7.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ordertextBox7.Text = "0";
            }
        }
        private void CalculateChange()
        {
            decimal orderTotal = decimal.Parse(ordertextBox7.Text);
            decimal amountPaid;

            if (decimal.TryParse(amtextBox8.Text, out amountPaid))
            {
                decimal change = amountPaid - orderTotal;


                if (change < 0)
                {
                    MessageBox.Show("Amount received cannot be less than total order amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    changetextBox5.Text = string.Empty;
                }
                else
                {
                    changetextBox5.Text = change.ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("Invalid numeric format in amount paid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                changetextBox5.Text = string.Empty;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                DataRow dr;
                dr = groupWst7DataSet.Product_Invoice1.NewRow();
                for (int i = 0; i < dr.ItemArray.Length; i++)
                {
                    dr[i] = dataGridView1.CurrentRow.Cells[i].Value;
                }
                groupWst7DataSet.Product_Invoice1.Rows.Add(dr);
            }
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

            return last_order + 1;
        }

        private int get_order()
        {
            int last_order = 0;
            DataTable dt = new DataTable();
            oRDERSTableAdapter.Fill(groupWst7DataSet.ORDERS);
            dt = groupWst7DataSet.ORDERS;

            foreach (DataRow dr in dt.Rows)
            {
                last_order = dr.Field<int>("OrderNumber");
            }

            return last_order + 1;
        }

        private int get_recpt()
        {
            int rcp = 0;
            DataTable dt = new DataTable();
            food_ReceiptTableAdapter.Fill(groupWst7DataSet.Food_Receipt);
            dt = groupWst7DataSet.Food_Receipt;

            foreach (DataRow dr in dt.Rows)
            {
                rcp = dr.Field<int>("recipt_no");
            }

            return rcp + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int m = get_last_order();
            int n = get_order();
            int o = get_recpt();

            int x = m;
            int lr = n;
            int l = o;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Order for an amount of " + ordertextBox7.Text, "Order Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    decimal orderTotal;
                    string orderNumber = Guid.NewGuid().ToString();
                    if (decimal.TryParse(ordertextBox7.Text, System.Globalization.NumberStyles.Currency, null, out orderTotal))
                    {

                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {
                            DataGridViewRow row = dataGridView2.Rows[i];
                            int Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            string Product_Name = dataGridView2.Rows[i].Cells[0].Value != null ? dataGridView2.Rows[i].Cells[0].Value.ToString() : string.Empty;
                            string Description = dataGridView2.Rows[i].Cells[2].Value != null ? dataGridView2.Rows[i].Cells[2].Value.ToString() : string.Empty;

                            order_LineTableAdapter.InsertQuery(x,Quantity, DateTime.Now, Product_Name, Description, Decimal.Parse(ordertextBox7.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(vattextBox.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(amtextBox8.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(changetextBox5.Text,System.Globalization.NumberStyles.Currency));
                            food_ReceiptTableAdapter.Insert(lr, Decimal.Parse(ordertextBox7.Text, System.Globalization.NumberStyles.Currency), DateTime.Now, Decimal.Parse(vattextBox.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(amtextBox8.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(changetextBox5.Text, System.Globalization.NumberStyles.Currency),comboBox1.SelectedItem.ToString());
                            oRDERSTableAdapter.InsertQuery(lr, Quantity, DateTime.Now, Product_Name, Description, Decimal.Parse(ordertextBox7.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(vattextBox.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(amtextBox8.Text, System.Globalization.NumberStyles.Currency), Decimal.Parse(changetextBox5.Text, System.Globalization.NumberStyles.Currency), l);
                            order_LineTableAdapter.Fill(groupWst7DataSet.Order_Line);
                            oRDERSTableAdapter.Fill(groupWst7DataSet.ORDERS);
                        }
                        dataGridView2.DataSource = null;
                        dataGridView2.Refresh();
                        Reciept r = new Reciept(x.ToString() , (l-1).ToString());
                        r.Show();
                        this.Close();this.Hide();
                    }
                    else
                    {
                        throw new FormatException("Invalid numeric format in the order total.");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                    ordertextBox7.Text = "0";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred: " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productTableAdapter.FillBySRCH(groupWst7DataSet.Product, textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
