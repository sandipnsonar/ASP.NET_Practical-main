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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;//Set Value to The Session
        Label1.Text = Session["Count"].ToString(); //Get Value from the Sesion
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (HiddenField1.Value != null)
        {
            try
            {
                int val = Convert.ToInt32(HiddenField1.Value) + 1;
                HiddenField1.Value = val.ToString();
                Label2.Text = val.ToString();
            }
            catch (Exception exc)
            {
                Response.Write(exc);
            }
        }
    }
}
