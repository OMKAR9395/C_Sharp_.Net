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

       

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, Lflag = true;

            if(tb_Employee_Name.Text != "")
            {
                Result += tb_Employee_Name.Text + " is from Department ";
                lbl_Name_Error.Visible = false;

            }
            else
            {
                lbl_Name_Error.Text = "Enter Employee Name";
                lbl_Name_Error.Visible = true;
                Flag = false;
            }
            if(cmb_Employee_Department.Text!="")
            {
                Result += cmb_Employee_Department.Text;
                lbl_Department_Error.Visible = false;
            }
            else
            {
                lbl_Department_Error.Text = "Select Employee Department";
                lbl_Department_Error.Visible = true;
                Flag = false;
            }
            if(rb_Male.Checked==true)
            {
                Result += ", is " + rb_Male.Text + " and He Knows ";
                lbl_Gender_Error.Visible = false;

            }
            else if(rb_Female.Checked==true)
            {
                Result += ", is " + rb_Female.Text + " and she Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Gender";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }
            if(cb_Marathi.Checked==true)
            {
                Result += cb_Marathi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;

            }
            if(cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;
            }
            if(cb_English.Checked==true)
            {
                Result += cb_English.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;
            }
            if(cb_French.Checked==true)
            {
                Result += cb_French.Text + ", ";
                lbl_Lang_Error.Visible = false;
                Lflag = false;
            }
            if(Lflag == true)
            {
                lbl_Lang_Error.Text = "Select Known Language";
                lbl_Lang_Error.Visible = true;
                Flag = false;
            }
            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobbies_Error.Visible = false;
                Result += " And Has Hobbies as ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }

                        Cnt--;
                    }
                }

            }
            else
            {
                lbl_Hobbies_Error.Visible = true;
                Flag = false;
            }

            if (Flag == false)
            {
                //MessageBox.Show("Incomplte Data","Fill Required Details",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_Output_Display.Visible = false;
            }
            else
            {
                lbl_Output_Display.Text = Result;
                lbl_Output_Display.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_French.Checked = false;
            cb_English.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Output_Display.Visible = false;
        }
    }
}
