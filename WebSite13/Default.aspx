<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 23px;
            width: 165px;
        }
        .style4
        {
            height: 23px;
            width: 363px;
        }
        .style5
        {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style3">
                name <span class="style5">*</span></td>
            <td class="style4">
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
&nbsp;&nbsp; 1.)
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txt_name" ErrorMessage="Enter Name" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp; 2.)
            </td>
        </tr>
        <tr>
            <td class="style3">
                Age</td>
            <td class="style4">
                <asp:TextBox ID="txt_age" runat="server" style="margin-left: 0px"></asp:TextBox>
&nbsp; &nbsp;</td>
            <td class="style2">
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="txt_age" ErrorMessage="Age between 18-45" ForeColor="Red" 
                    MaximumValue="45" MinimumValue="18"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                email</td>
            <td class="style4">
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txt_email" ErrorMessage="email format" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style3">
                date of birth</td>
            <td class="style4">
                <asp:TextBox ID="txt_DOB" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="txt_DOB" ErrorMessage="Date format not correct" 
                    ForeColor="Red" Operator="DataTypeCheck" Type="Date" ValidationGroup="a"></asp:CompareValidator>
&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style3">
                city</td>
            <td class="style4">
                <asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
            <td class="style4">
                <asp:Button ID="But_Reg" runat="server" onclick="But_Reg_Click" Text="register" 
                    ValidationGroup="a" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ValidationGroup="a" />
            </td>
            <td class="style2">
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txt_DOB" ErrorMessage="Age and dob does not match" 
                    ForeColor="Red" onservervalidate="CustomValidator1_ServerValidate" 
                    ValidationGroup="a"></asp:CustomValidator>
            </td>
        </tr>
    </table>
    <div>
    
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
