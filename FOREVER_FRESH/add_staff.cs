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
    public partial class add_staff : Form
    {
        public add_staff()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String phn = phonetextBox5.Text.Trim();
            String em = emtextBox4.Text.Trim();
            String fp = passtextBox9.Text.Trim();
            String sp = cpasstextBox11.Text.Trim();
            try
            {
                if (nametextBox2.Text==""||idtextBox1.Text==""||lnametextBox3.Text==""||emtextBox4.Text==""||passtextBox9.Text==""||towntextBox6.Text==""||passtextBox9.Text==""||cpasstextBox11.Text=="")
                {
                    MessageBox.Show("Please fill in all the details.");
                    return;
                }
                else if ((phonetextBox5.Text.ToString()).Length != 10)
                {
                    MessageBox.Show("Invalid cell phone details. Phune number must have 10 digits only.");
                    phonetextBox5.Focus();
                    return;
                }
                else if ((idtextBox1.Text.Trim().ToString()).Length != 13)
                {
                    MessageBox.Show("Invalid details. Id number must be 13 digits.");
                    phonetextBox5.Focus();
                    return;
                }
                else if (!(phn[0].Equals('0')))
                {
                    MessageBox.Show("Invalid cell phone details. Phune number must start with zero.");
                    phonetextBox5.Focus();
                    return;
                }
                else if (!(long.TryParse(idtextBox1.Text, out long y)))
                {
                    MessageBox.Show("Id number must only contain digits.");
                    phonetextBox5.Focus();
                    return;
                }
                else if (!(int.TryParse(phn, out Int32 x)))
                {
                    MessageBox.Show("Phone number must only cotain digits.");
                    phonetextBox5.Focus();
                    return;
                }
                else if (em.Count(f => (f == '.')) < 1 || (em.Count(f => (f == '@')) < 1))
                {

                    MessageBox.Show("Invalid email adress. Check email and try again. ");
                    emtextBox4.Focus();
                    return;
                }
                else if (!(fp == sp))
                {
                    MessageBox.Show("Passwords do not match , validate passwords and try again.");
                    cpasstextBox11.Focus();
                    return;
                }
                else if (comboBox1.Text.Trim().Equals("--select archieve--"))
                {
                    MessageBox.Show("Select archieve to continue.");
                    cpasstextBox11.Focus();
                    return;
                }
                else
                {
                    employeeTableAdapter.InsertQuery(idtextBox1.Text,nametextBox2.Text, lnametextBox3.Text, emtextBox4.Text, phonetextBox5.Text, towntextBox6.Text, cpasstextBox11.Text,Convert.ToBoolean(comboBox1.Text));
                    MessageBox.Show("Staff inserted.");
                    man_staff m = new man_staff();
                    m.Show();
                    this.Hide();

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void add_staff_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            man_staff m = new man_staff();
            m.Show();
            this.Hide();
        }
    }
}
