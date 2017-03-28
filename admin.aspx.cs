using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void login_Click(object sender,EventArgs e)
    { 
        //if (login.adminname=="maheen"&& login.adminpassword=="tanzeel")
        //System.Web.Security.FormsAuthentication.RedirectFromLoginPage(login.adminname,login.RememberMeSet);
        Response.Redirect("adminview.aspx");
    }
    protected void adminname_TextChanged(object sender, EventArgs e)
    {
    }
    protected void adminpassword_TextChanged(object sender, EventArgs e)
    {

    }
}