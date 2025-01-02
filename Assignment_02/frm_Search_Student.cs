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

namespace Assignment_001
{
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01/06/2010";
        }
        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd1.Dispose();

                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Roll_No) from Student_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Students_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_No = @RNo ", Con);

            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mob_No.Text = (Dr["Mobile_No"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                dtp_DOB.Text = Dr["DOB"].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No");
                tb_Roll_No.Clear();
            }

            Con_Close();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();

        }
    }
}
