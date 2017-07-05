using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
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
}