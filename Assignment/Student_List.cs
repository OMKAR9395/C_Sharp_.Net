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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }



        

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment_1System_DBDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.assignment_1System_DBDataSet3.Student_Details);
          


        }

 
    }
}
