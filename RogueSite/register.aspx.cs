using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class register : System.Web.UI.Page
{
    int counter = 0;
    SqlConnection conn;
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        bool userExists = false;
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=E:\ROGUEASP\ROGUEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        using (SqlConnection conn = new SqlConnection(connectString))
        {
            conn.Open();

            SqlCommand com = new SqlCommand();

            com.Connection = conn; //Pass the connection object to Command
                                   //com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
                                   //com.CommandText = "selectUser"; //Stored Procedure Name

            //com.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUser.Text;
            //SqlDataReader reader = com.ExecuteReader();
            //if(reader.Read().ToString() != null)
            //{
            //    userExists = true;
            //    Label1.Text = "Sorry, this user already exists.";
            //}
            //reader.Close();
            //if (userExists == false)
            //{

            //}
            try
            {
                com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
                com.CommandText = "spInsertUser"; //Stored Procedure Name

                com.Parameters.Add("@FName", SqlDbType.NVarChar).Value = txtFirst.Text;
                com.Parameters.Add("@LName", SqlDbType.NVarChar).Value = txtLast.Text;
                com.Parameters.Add("@SName", SqlDbType.NVarChar).Value = txtScreen.Text;
                com.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUser.Text;
                com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPass.Text;

                com.ExecuteNonQuery();

                txtFirst.Text = string.Empty;
                txtLast.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtScreen.Text = string.Empty;
            }
            catch { }
            
            conn.Close();
        }        
    }
}