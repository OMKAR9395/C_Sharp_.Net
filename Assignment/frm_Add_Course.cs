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
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=Patil;Initial Catalog=Assignment_1System_DB;Integrated Security=True");
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
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
        void Clear_Controls()
        {
            tb_Course_Name.Clear();
            Auto_Incr();
        }
        int Auto_Incr()
        {
            Con_Open();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();
            if(Cnt>0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select max(Course_ID) from Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt++;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();
            return Cnt;
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if(tb_Course_ID.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Course_Details values (@Cid,@Cnm)";

                Cmd.Parameters.Add("Cid", SqlDbType.Int).Value = tb_Course_ID.Text;
                Cmd.Parameters.Add("Cnm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Course Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("First Mention The Course Name !!!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Con_Close();
            Clear_Controls();
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            tb_Course_ID.Text = Convert.ToString(Auto_Incr());
        }
    }
}
