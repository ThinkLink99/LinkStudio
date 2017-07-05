using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class register : System.Web.UI.Page
{
    int counter;
    SqlConnection conn;
    SqlCommand com;
    string connectString = "Server=tcp:roguedatabase.database.windows.net,1433;Initial Catalog=rogueDB;Persist Security Info=False;User ID=treyhall;Password=web.56066;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection(connectString))
        {
            string command = "INSERT INTO UserData VALUES ('" + txtScreen.Text + "', '" + txtUser.Text + "', '" + txtPass.Text + "', '" + txtFirst.Text + "', '" + txtLast.Text + "')";
            com = new SqlCommand(command, conn);
            conn.Open();

            com.Connection = conn;
            try
            {
                com.ExecuteNonQuery();

                txtFirst.Text = string.Empty;
                txtLast.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtScreen.Text = string.Empty;

                counter++;
            }
            catch { }

            conn.Close();
        }
    }
}