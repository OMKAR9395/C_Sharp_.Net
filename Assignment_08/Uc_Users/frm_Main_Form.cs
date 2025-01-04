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
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            UC.AddUser Obj = new UC.AddUser();

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            UserControl UCH = new UserControl();

            pnl_Header.Controls.Clear();
            pnl_Header.Controls.Add(UCH);
            UCH.Show();
        }
    }
}
