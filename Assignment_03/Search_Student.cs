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


namespace Assignment
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Patil;Initial Catalog=Assignment_1System_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_Dob.Text = "01-01-1999";
            cb_Course.SelectedIndex = -1;
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Detail obj = new frm_Add_Student_Detail();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to logout", "Waraning", MessageBoxButtons.YesNo);
            frm_login obj = new frm_login();
            obj.Show();
            this.Hide();
        }

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome" + Shared_content.Uname;
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

      
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * from Student_Details Where Roll_No = @RNo";

            cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if(Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                dtp_Dob.Text = (Dr["DOB"].ToString());
                cb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

            }
            else
            {
                MessageBox.Show("Invalid Roll Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Fields();
        }

    }
}
