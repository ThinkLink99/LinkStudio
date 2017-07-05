using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    Label LoginLabel;
    Label RegisterLabel;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.IsInRole("User"))
        {
            Master.FindControl("MemberBar").Visible = true;
            Master.FindControl("LoginBar").Visible = false;
        }
        else
        {
            Master.FindControl("MemberBar").Visible = false;
            Master.FindControl("LoginBar").Visible = true;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string connectString = "Server=tcp:roguedatabase.database.windows.net,1433;Initial Catalog=rogueDB;Persist Security Info=False;User ID=treyhall;Password=web.56066;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        FormsAuthentication.Initialize();

        // Create our connection and command objects
        SqlConnection conn =
         new SqlConnection(connectString);
        SqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT Roles FROM UserData WHERE Username=@username " +
         "AND Password=@password";

        // Fill our parameters
        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = Username.Value;
        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = Password.Value; // Or "sha1"
        //cmd.Parameters.Add("@password", SqlDbType.NVarChar, 128).Value = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Value, "md5"); // Or "sha1"

        // Execute the command
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            // Create a new ticket used for authentication
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
               1, // Ticket version
               Username.Value, // Username associated with ticket
               DateTime.Now, // Date/time issued
               DateTime.Now.AddMinutes(30), // Date/time to expire
               true, // "true" for a persistent user cookie
               reader.GetString(0), // User-data, in this case the roles
               FormsAuthentication.FormsCookiePath);// Path cookie valid for

            // Encrypt the cookie using the machine key for secure transport
            string hash = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(
               FormsAuthentication.FormsCookieName, // Name of auth cookie
               hash); // Hashed ticket

            // Set the cookie's expiration time to the tickets expiration time
            if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;

            // Add the cookie to the list for outgoing response
            Response.Cookies.Add(cookie);

            // Redirect to requested URL, or homepage if no previous page
            // requested
            string returnUrl = Request.QueryString["ReturnUrl"];
            if (returnUrl == null) returnUrl = "/";

            // Don't call FormsAuthentication.RedirectFromLoginPage since it
            // could
            // replace the authentication ticket (cookie) we just added
            Response.Redirect(returnUrl);
        }
        else
        {
            // Never tell the user if just the username is password is incorrect.
            // That just gives them a place to start, once they've found one or
            // the other is correct!
            ErrorLabel.Text = "Username / password incorrect. Please try again.";
            ErrorLabel.Visible = true;
        }

        reader.Close();
        conn.Close();
    }
}