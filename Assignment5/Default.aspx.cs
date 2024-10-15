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
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            int num = int.Parse(args.Value);
            args.IsValid = ((num % 5) == 0);
        }
        catch (Exception ex)
        {
            args.IsValid = false;
           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Name :- " + TextBox8.Text;
        Label1.Visible = true;
Label2.Text = "Password :- " + TextBox10.Text;
Label2. Visible = true;
Label3.Text = "Confirm Password :- " + TextBox11.Text;
Label3.Visible = true;
Label4.Text = "Age :- " + TextBox12.Text;
Label4.Visible = true;
Label5.Text = "Salary :- " + TextBox13.Text;
Label5.Visible = true;
Label6.Text = "Email :- " + TextBox6.Text;
Label6.Visible = true;
Label7.Text = "Address :- " + TextBox9.Text;
Label7.Visible = true;
if (RadioButton1.Checked)
{
Label8.Text = " Gender :- Male";
Label8.Visible = true;
}
else
{
Label8.Text = " Gender :- Female";
Label8.Visible = true;
}
if (CheckBox1.Checked)
{
Label9.Visible = true;
Label9.Text = "Known Language :- " + CheckBox1.Text;
}
if (CheckBox2.Checked)
{
Label9.Visible = true;
Label9.Text += "," + CheckBox2.Text;
}
string msg = "";
foreach (ListItem li in ListBox1.Items)
{
    if (li.Selected == true)
    {
        msg += "<BR>" + li.Text + " is selected.";
    }
}
Label10.Text = msg;
 }
}
