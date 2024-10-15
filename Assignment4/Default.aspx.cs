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
        bind1();
        bind2();
    }
    public void bind1()
    {
        ListItem l1 = new ListItem("India");
        ListItem l2 = new ListItem("US");
        ListItem l3 = new ListItem("Japan");
        DropDownList1.Items.Add(l1);
        DropDownList1.Items.Add(l2);
        DropDownList1.Items.Add(l3);
    }

    public void bind2()
    {
        ListItem l1 = new ListItem("India");
        ListItem l2 = new ListItem("US");
        ListItem l3 = new ListItem("Japan");
        DropDownList2.Items.Add(l1);
        DropDownList2.Items.Add(l2);
        DropDownList2.Items.Add(l3);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
