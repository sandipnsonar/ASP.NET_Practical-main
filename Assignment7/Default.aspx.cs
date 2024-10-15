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
using System.Collections;
using System.Collections.Generic;
public partial class _Default : System.Web.UI.Page 
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=I:\\2021-22\\Subjects\\CA-305(B) Microsoft .Net Technologies\\CA-LAB-XII (B) Lab on Microsoft .Net Technologies\\Assignment7\\App_Data\\Database.mdf;Integrated Security=True;User Instance=True");   
        DataTable ds = new DataTable();
        SqlDataAdapter sde = new SqlDataAdapter("select * from student", con);
        sde.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        
        ArrayList list = new ArrayList();
        list.Add("AAAA");
        list.Add("BBBB");
        list.Add("CCCC");
        GridView2.DataSource =list;
        GridView2.DataBind();


        Hashtable hashItems = new Hashtable();
        hashItems.Add("4","GGGG");
        hashItems.Add("5","HHHH");
        hashItems.Add("6","IIII");
        hashItems.Add("7","JJJJ");
        GridView3.DataSource = hashItems;
        GridView3.DataBind();
    }

}
