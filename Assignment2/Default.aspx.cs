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
    protected void Page_PreInit(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "PreInit";
    }
    protected void Page_Init(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "Init";
    }
    protected void Page_InitComplete(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "InitComplete";
    }
    protected override void OnPreLoad(EventArgs e)
    {
        //Work and It will assign the values to label.  
        //If the page is post back, then label contrl values will be loaded from view state.  
        //E.g: If you string str = Label1.Text, then str will contain viewstate values.  
        Label1.Text = Label1.Text + "<br/>" + "PreLoad";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "Load";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "btnSubmit_Click";
    }
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "LoadComplete";
    }
    protected override void OnPreRender(EventArgs e)
    {
        //Work and It will assign the values to label.  
        Label1.Text = Label1.Text + "<br/>" + "PreRender";
    }
    protected override void OnSaveStateComplete(EventArgs e)
    {
        //Work and It will assign the values to label.  
        //But "SaveStateComplete" values will not be available during post back. i.e. View state.  
        Label1.Text = Label1.Text + "<br/>" + "SaveStateComplete";
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //Work and it will not effect label contrl, view stae and post back data.  
        Label1.Text = Label1.Text + "<br/>" + "UnLoad";
    }
    
}
