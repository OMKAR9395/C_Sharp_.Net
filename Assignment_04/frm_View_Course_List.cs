using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frm_View_Course_List : Form
    {
        public frm_View_Course_List()
        {
            InitializeComponent();
        }

        private void frm_View_Course_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment_1System_DBDataSet4.Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this.assignment_1System_DBDataSet4.Course_Details);

        }
    }
}
