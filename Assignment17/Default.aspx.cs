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
        // Initializes a new instance of the System.Data.DataTable class with the specified table name.  
            DataTable tempTable = new DataTable();  
           // Add columns in DataTable  
            tempTable.Columns.Add("ID");  
           tempTable.Columns.Add("NAME");  
           // Add New Row in dataTable  
         DataRow newrow = tempTable.NewRow();  
          newrow[0] = 0;  
           newrow[1] = "Avinash";  
           tempTable.Rows.Add(newrow);  
          // Add Another New Row in dataTable  
            newrow = tempTable.NewRow();  
            newrow[0] = 1;  
           newrow[1] = "Kavita";  
           tempTable.Rows.Add(newrow);  
           //Now table is ready  
           Response.Write("Original Table"+"<br>");  
            
        for (int i = 0; i < tempTable.Rows.Count; i++)  
            {
                Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString()+"<br>");  
            }  
            // if you want edit data from DataTable  
        Response.Write("Modified Table" + "<br>");  
            for (int i = 0; i < tempTable.Rows.Count; i++)  
           {  
          if (tempTable.Rows[i][1].ToString() == "Kavita")  
                {  
                    tempTable.Rows[i][1] = "Ganesh";  
               }
          Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString() + "<br>");  
            }  
           // if you want delete row from DataTable  
            Response.Write("After Deleting row from Table" + "<br>");  
            for (int i = 0; i < tempTable.Rows.Count; i++)  
           {
               if (tempTable.Rows[i][1].ToString() == "Ganesh")  
              {  
	                    tempTable.Rows[i].Delete();  
                }  
	            }  
           for (int i = 0; i < tempTable.Rows.Count; i++)  
           {
               Response.Write(tempTable.Rows[i][0].ToString() + "--->" + tempTable.Rows[i][1].ToString() + "<br>");  
           }  

    }
}
