﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class startpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}