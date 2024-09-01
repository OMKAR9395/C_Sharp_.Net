using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure want to logout","warning",MessageBoxButtons.YesNo);
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void btn_add_new_srudent_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Detail obj = new frm_Add_Student_Detail();
            obj.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment_1System_DBDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.assignment_1System_DBDataSet3.Student_Details);
            lbl_Username.Text = "Welcome " + Shared_content.Uname;


        }
    }
}
