<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table border =2>
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
    <HeaderTemplate >
<tr ><td style ="background-color:Lime ;">ROLL NO</td>
<td style ="background-color:Lime ;">NAME</td></tr>
</HeaderTemplate>
<ItemTemplate >
<tr><td><%#Eval("rno") %></td>
<td><%#Eval("name") %></td></tr></ItemTemplate>
<AlternatingItemTemplate >
<tr><td style ="background-color :Gray ;"><%#Eval("rno") %></td>
<td style ="background-color :Gray;"><%#Eval("name")%> </td></tr>
</AlternatingItemTemplate>
    </asp:Repeater>
    </table>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
