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
    public partial class UC_Header : UserControl
    {
        public UC_Header()
        {
            InitializeComponent();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            UC.AddUser Obj = new UC.AddUser();
/*
            frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(Obj);
            Obj.Show();
*/
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            UC.UC_Update Obj = new UC.UC_Update();

            /*
             * frm_Main_Form.pnl_Container.Controls.Clear();
            frm_Main_Form.pnl_Container.Controls.Add(Obj);
            Obj.Show();
            */
        }
    }
}
