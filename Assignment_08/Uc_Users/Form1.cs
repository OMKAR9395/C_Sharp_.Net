using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uc_Users
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            frm_Main_Form Obj = new frm_Main_Form();
            Obj.Show();
            this.Hide();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Name.Text = "OMKAR";

            tb_Password.Focus();
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shared_Class.Bind_ComboBox(cmb_User_Name, "Username", "Select Distinct(Username) From Login where User_Role = '" + cmb_User_Role.Text + "' ");

        }
    }
}
