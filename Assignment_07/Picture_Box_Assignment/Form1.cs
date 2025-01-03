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

namespace Picture_Box_Assignment
{
    public partial class frm_Add_Image : Form
    {
        public frm_Add_Image()
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
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Image_ID.Clear();
            tb_Image_Description.Clear();
            pb_Image.Image = null;
        }

     

        private void frm_Add_Image_Load(object sender, EventArgs e)
        {
            tb_Image_ID.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_Search_Image Obj = new frm_Search_Image();
            Obj.Show();
            this.Hide();
        }

    

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Image_ID.Text != "" && tb_Image_Description.Text != "" && pb_Image.Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Image_List Values (@ID, @Image, @Img_Details) ", Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Image_ID.Text;
                cmd.Parameters.Add("@Img_Details", SqlDbType.NVarChar).Value = tb_Image_Description.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Con_Close();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Show_Image_Click(object sender, EventArgs e)
        {
            frm_Show_Image Obj = new frm_Show_Image();
            Obj.Show();
            this.Hide();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
