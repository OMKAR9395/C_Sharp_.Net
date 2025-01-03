using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Check_Box_Check_List_Box
{
    public partial class frm_Group_Box_Check_Box : Form
    {
        public frm_Group_Box_Check_Box()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void only_text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void frm_Group_Box_Check_Box_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = " ";
            bool flag = false;

            if (tb_Employee_Name.Text != " ")
            {
                Result = tb_Employee_Name.Text;

                if (cmb_Employee_Department.Text != " ")
                {
                    Result += " From " + cmb_Employee_Department.Text + " is ";

                    if (rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Candidate Prefers Shift Timing ";
                    }
                    else if (rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Candidate Prefers Shift Timing ";
                    }
                    else
                    {
                        MessageBox.Show(" Select Gender Of Employee ");
                    }


                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if (rb_night.Checked == true)
                    {
                        Result += rb_night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Timing");
                        flag = true;
                    }
                }

                else
                {
                    MessageBox.Show("Select Employee Department");
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Enter Employee Name");
                flag = true;
            }
            if (flag == false)
            {
                tb_Output.Text = Result;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_Output.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_night.Checked = false;

            tb_Employee_Name.Focus();
        }
    }
}
