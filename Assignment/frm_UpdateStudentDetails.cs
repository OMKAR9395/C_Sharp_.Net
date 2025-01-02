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
    public partial class frm_UpdateStudentDetails : Form
    {
        public frm_UpdateStudentDetails()
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
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Control_Enable()
        {
            tb_Name.Enabled = true;
            dtp_Dob.Enabled = true;
            cb_Course.Enabled = true;
            tb_Roll_No.Enabled = true;
        }
        void Control_Disable()
        {
            tb_Name.Enabled = false;
            dtp_Dob.Enabled = false;
            cb_Course.Enabled = false;
            tb_Roll_No.Enabled = false;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cb_Course.SelectedIndex = -1;
            dtp_Dob.Text = "01/06/2007";
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if(tb_Name.Text!="" && tb_Mobile_No.Text != "" && cb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Update Student_Details Set Name = @Nm ,Dob = @Dob, Mobile_No = @MobNo, Course = @Course Where Roll_No =@RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_Dob.Value.Date;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Update Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Control_Disable();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void frm_UpdateStudentDetails_Load(object sender, EventArgs e)
        {

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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            Clear_Controls();
            Control_Disable();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Student_Details where Roll_No = " + tb_Roll_No.Text + "", Con);
                var obj = cmd.ExecuteReader();

                if(obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    dtp_Dob.Text = obj["Dob"].ToString();
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                    cb_Course.Text = Convert.ToString(obj["Course"].ToString());

                    Control_Enable();
                }
                else
                {
                    MessageBox.Show("Invalid Roll No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();

                }

            }
            else
            {
                MessageBox.Show("First Fill The Roll_NO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con.Close();

        }
    }
}
