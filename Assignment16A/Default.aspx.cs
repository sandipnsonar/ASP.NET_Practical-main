using System;
using System.Configuration;

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
    SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=I:\\2021-22\\Subjects\\CA-305(B) Microsoft .Net Technologies\\CA-LAB-XII (B) Lab on Microsoft .Net Technologies\\Assignment16A\\App_Data\\Database.mdf;Integrated Security=True;User Instance=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            getdata();

    }
    void getdata()
    {
        DataTable ds = new DataTable();
        SqlDataAdapter sde = new SqlDataAdapter("select * from student", con);
        sde.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }

}


