using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Detail obj = new frm_Add_Student_Detail();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.MdiParent = this;
            obj.Show();
            

        }

        private void viewStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.MdiParent = this;
            obj.Show();
           
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_login obj = new frm_login();
                obj.Show();
                this.Hide();
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_content.Uname;
        }

        private void updateStudentToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_UpdateStudentDetails obj = new frm_UpdateStudentDetails();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCourseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course obj = new frm_Add_Course();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
