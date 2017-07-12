using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
public partial class MasterPages_MasterPage : System.Web.UI.MasterPage
{
    string connectString = "Server=tcp:roguedatabase.database.windows.net,1433;Initial Catalog=rogueDB;Persist Security Info=False;User ID=treyhall;Password=web.56066;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.IsInRole("User"))
        {
            lblProfile.Text = Page.User.Identity.Name;

            MemberBar.Visible = true;
            LoginBar.Visible = false;
            pnlForums.Visible = true;
        }
        else
        {
            MemberBar.Visible = false;
            LoginBar.Visible = true;
            pnlForums.Visible = false;
        }
        if (Page.User.IsInRole("Manager"))
        {
            pnlManagers.Visible = true;
        }
        else
        {
            pnlManagers.Visible = false;
        }
        if (Page.User.IsInRole("Administrator"))
        {
            pnlAdmins.Visible = true;
        }
        else
        {
            pnlAdmins.Visible = false;
        }
    }
}