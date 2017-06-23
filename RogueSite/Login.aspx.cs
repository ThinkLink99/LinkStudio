using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    Label LoginLabel;
    Label RegisterLabel;
    protected void Page_Load(object sender, EventArgs e)
    {
        LoginLabel = (Label)Master.FindControl("lblLogin");
        RegisterLabel = (Label)Master.FindControl("lblRegister");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string username = "";
        string password = "";
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=E:\ROGUEASP\ROGUEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        using (SqlConnection conn = new SqlConnection(connectString))
        {
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn; //Pass the connection object to Command
            com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
            com.CommandText = "selectUser"; //Stored Procedure Name

            com.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUser.Text;

            using (SqlDataReader oReader = com.ExecuteReader())
            {
                while (oReader.Read())
                {
                    username = oReader["Username"].ToString();
                    password = oReader["Password"].ToString();
                }

                conn.Close();
            }
            if(txtPass.Text == password)
            {
                LoginLabel.Visible = false;
                RegisterLabel.Visible = false;
            }
            txtPass.Text = string.Empty;
            //txtUser.Text = string.Empty;
        }
    }
}