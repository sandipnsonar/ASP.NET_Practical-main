﻿using System;
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
        if (!this.IsPostBack)
        {
            ProfileCommon pc = this.Profile.GetProfile(Profile.UserName);

            if (pc != null)
            {
                this.TextBox1.Text = pc.Name;
                this.TextBox2.Text = pc.Class;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ProfileCommon pc = this.Profile.GetProfile(Profile.UserName);

        if (pc != null)
        {
            pc.Name = this.TextBox1.Text;
            pc.Class= this.TextBox2.Text;
           pc.Save();
        }
    }
}
