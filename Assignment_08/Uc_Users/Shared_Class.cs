using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace Uc_Users
{
    internal class Shared_Class
    {
        public static int UserRole = 0;
        public static string UserName = "Dummmy";

        public static SqlConnection Con = new SqlConnection(@"Data Source=Patil;Initial Catalog=Assignment_1System_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public static void Bind_ComboBox(ComboBox FCmb, string Column, String Query)
        {
            Con_Open();

            FCmb.Items.Clear();

            SqlCommand Cmd = new SqlCommand(Query, Con);

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                FCmb.Items.Add(obj.GetString(obj.GetOrdinal(Column)));
            }

            obj.Dispose();
            Con_Close();
        }

    }
}
