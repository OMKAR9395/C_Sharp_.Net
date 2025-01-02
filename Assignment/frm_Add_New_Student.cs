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
    public partial class frm_Add_Student_Detail : Form
    {
        public frm_Add_Student_Detail()
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
        void Clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_Dob.Text = "01-01-1999";
            cb_Course.SelectedIndex = -1;
        }

        

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)||(e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        int Auto_Incr()
        {
            int ID = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Max(Roll_No) From Student_Details";

            ID = Convert.ToInt32(Cmd.ExecuteScalar());

            Con_Close();

            return (ID + 1);
        }
        private void frm_Add_Student_Detail_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values (@RNo, @Nm, @MNo, @Dob, @Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cb_Course.Text;

                Cmd.ExecuteNonQuery();
                 
                MessageBox.Show("Record Saved Successfully...");
                Clear_Fields();
            }
            else
            {
                MessageBox.Show("Incomplete Data");
            }

            Con_Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
        }

    
    }
}
