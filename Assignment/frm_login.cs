using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;


namespace Assignment
{
    public partial class frm_login : Form
    {
        public frm_login()
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
        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_password.Enabled = true;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            btn_submit.Enabled = true;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select count(*) From Login Where Username = @unm And Password = @Pwd";

            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_username.Text;
            Cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = tb_password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Success","Welcome ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Shared_content.Uname = tb_username.Text;
                frm_Main obj = new frm_Main();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed","Re-Enter Details",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                lbl_Error.Text = "Incorrect Username or Password!!!";
                lbl_Error.ForeColor = Color.OrangeRed;
            }
            tb_username.Clear();
            tb_password.Clear();
            tb_password.Enabled = false;
            btn_submit.Enabled = false;
            Con_Close();

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
