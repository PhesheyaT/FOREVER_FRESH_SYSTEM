using FOREVER_FRESH.GroupWst7DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOREVER_FRESH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            emlabel2.Hide();
            passlabel6.Hide();  
        }
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst7;Persist Security Info=True;User ID=GroupWst7;Password=wds2h");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                emlabel2.Show();
                passlabel6.Show();
            }
            else if (textBox1.Text == "")
            {
                emlabel2.Show();
                passlabel6.Hide();
            }
            else if (textBox2.Text == "")
            {
                emlabel2.Hide();
                passlabel6.Show();
            }
            else
            {

                try
                {
                    con.Open();
                    string querry = "SELECT * FROM Employee WHERE Email_Address = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Home m = new Home();
                        m.Show();
                        this.Hide();
                    }
                    else if (textBox1.Text.Equals("Manager") && textBox2.Text.Equals("******"))
                    {
                        manager_home mh = new manager_home();
                        mh.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login error, Please confirm your details.");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            emlabel2.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passlabel6.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
