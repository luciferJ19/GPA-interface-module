using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection c = new SqlConnection("Data Source=LAPTOP-IFP8PL57; Initial Catalogue=gpaDB; User Id=LAPTOP-IFP8PL57/chaitanya;");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Btnsubmitt_Click(object sender, EventArgs e)
    {
        c.Open();
        SqlCommand cmd = new SqlCommand("insert into Studentdetails values('"+name.Text+"','"+streamID.Text+"','"+studentID.Text+"','"+seatNumber.Text+"','"+creditsem1.Text+"','"+cgsem1.Text+"','"+gpasem1.Text+"','"+creditsem2.Text+"','"+cgsem2.Text+"','"+gpasem2.Text+"','"+creditsem3.Text+"','"+cgsem3.Text+"','"+gpasem3.Text+"','"+creditsem4.Text+"','"+cgsem4.Text+"','"+gpasem4.Text+"','"+creditsem5.Text+"','"+cgsem5.Text+"','"+gpasem5.Text+"','"+creditsem6.Text+"','"+cgsem6.Text+"','"+gpasem6.Text+"')",c);
        cmd.ExecuteNonQuery();
        lblMessage.Text ="Record Submitted Successfully";
        c.Close();

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}