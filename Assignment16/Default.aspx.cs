using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{

    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=I:\\2021-22\\Subjects\\CA-305(B) Microsoft .Net Technologies\\CA-LAB-XII (B) Lab on Microsoft .Net Technologies\\Assignment16\\App_Data\\Database.mdf;Integrated Security=True;User Instance=True");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            getdata();
    }
    void getdata()
    {
        SqlCommand cmd = new SqlCommand("select * from student", con);
        con.Open();
        dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd1 = new SqlCommand("insert into student values(" + Convert
.ToInt32(TextBox1.Text) + ",'" + TextBox2.Text + "'," + Convert
.ToInt32(TextBox3.Text) + ")", con);
        con.Open();
        cmd1.ExecuteNonQuery();
        con.Close();
        getdata();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd2 = new SqlCommand("Update student set name='" + TextBox2.Text + "',mark=" +
Convert.ToInt32(TextBox3.Text) + "where rno=" + Convert.ToInt32(TextBox1.Text), con);
        con.Open();
        cmd2.ExecuteNonQuery();
        con.Close();
        getdata();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd3 = new SqlCommand("Delete from student Where rno=" +
Convert.ToInt32(TextBox1.Text), con);
        con.Open();
        cmd3.ExecuteNonQuery();
        con.Close();
        getdata();
    }
}
