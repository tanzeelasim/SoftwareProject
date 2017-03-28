using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;


public partial class user : System.Web.UI.Page
{
    SqlConnection dbConnection = new SqlConnection(@"Data source=192.168.43.85\MSSQLSERVER,1433;Network Library=DBMSSOCN;Initial Catalog=proverb;User ID=computer;Password=123456789");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void go_Click(object sender, EventArgs e)
    {



        SqlCommand cmd = new SqlCommand("INSERT INTO users(username, email_address)VALUES(@user_name,@emailid)", dbConnection);
        cmd.Parameters.Add("@user_name", System.Data.SqlDbType.VarChar);
        cmd.Parameters["@user_name"].Value = username.Text;
        cmd.Parameters.Add("@emailid", System.Data.SqlDbType.VarChar);
        cmd.Parameters["@emailid"].Value = email.Text;
        string uname = username.Text;
        string emailadd = email.Text;
     
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        if (dbConnection.State != ConnectionState.Open)
            dbConnection.Open();

        da.Fill(dt);
        dbConnection.Close();

    
        SqlConnection dbConnection1 = new SqlConnection(@"Data source=192.168.43.85\MSSQLSERVER,1433;Network Library=DBMSSOCN;Initial Catalog=proverb;User ID=computer;Password=123456789");

        var cmd1 = new SqlCommand("select id from users where username=@user_name and email_address=@emailid",dbConnection1);
        //SqlCommand cmd2 = new SqlCommand(cmd1, dbConnection1);
        cmd1.Parameters.Add("@user_name", System.Data.SqlDbType.VarChar);

        cmd1.Parameters["@user_name"].Value = uname;
        cmd1.Parameters.Add("@emailid", System.Data.SqlDbType.VarChar);

        cmd1.Parameters["@emailid"].Value = emailadd;
        SqlDataAdapter db = new SqlDataAdapter(cmd1);
        var proverbDS = new DataSet();

        if (dbConnection1.State != ConnectionState.Open)
            dbConnection1.Open();

        db.Fill(proverbDS);

        dbConnection1.Close();

        if (proverbDS.Tables.Count > 0)
        {
            if (proverbDS.Tables[0].Rows.Count > 0)
            {

                id.Text = proverbDS.Tables[0].Rows[0]["id"].ToString();
            }
        }
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("mainmenu.aspx");
      
    }
}
