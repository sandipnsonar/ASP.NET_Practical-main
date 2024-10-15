<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
 
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="TextBox8"  ErrorMessage="Plz Enter Name"></asp:RequiredFieldValidator>
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;         
        <asp:TextBox ID="TextBox10" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Confirm Password&nbsp;&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToCompare="TextBox11" ControlToValidate="TextBox10" 
        ErrorMessage="should be same" ValueToCompare="18"></asp:CompareValidator>
        <br />
&nbsp;<br />
        <br />
        Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:CompareValidator ID="CompareValidator2" runat="server" 
        ControlToValidate="TextBox12" ErrorMessage="Should be greater than 18" 
        Operator="GreaterThan" ValueToCompare="18" Type="Integer"></asp:CompareValidator>
        <br />
        <br />
        Salary&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="TextBox13" ErrorMessage="Should be between 10k to 50k" MaximumValue="50000" 
        MinimumValue="10000" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TextBox6" ErrorMessage="Invalid Email" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        
        <asp:TextBox ID="TextBox9" runat="server" Height="44px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g1" Text="Male" />
&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="Female" />
        <br />
        <br />
        Language Known&nbsp;&nbsp;&nbsp;         <asp:CheckBox ID="CheckBox1" runat="server" Text="Marathi" />
&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Hindi" />
        <br />
        <br />
        Favorite Color&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
        </asp:ListBox>
    
 
        <br />
        <br />
        Custom Validation</div>
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ClientValidationFunction="CustomValidator1_ServerValidate" ErrorMessage="Shoud be divisible by 5" 
        ControlToValidate="TextBox7" 
        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    </form>
</body>
</html>
