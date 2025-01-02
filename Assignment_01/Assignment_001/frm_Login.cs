using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_001
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successful", "WELCOME");

                frm_Add_New_Student ANS = new frm_Add_New_Student();
                ANS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed, Enter Correct Username/Password.", "Failure");
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
