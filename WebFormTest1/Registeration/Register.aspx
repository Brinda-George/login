<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormTest1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <table style="border: 1px solid black">
            <tr>
                <td colspan="2"><b>User Registration</b></td>
            </tr>
            <tr>
                <td>User Name: </td>    
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameValidator" runat="server" ErrorMessage="User Name Required" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>    
            </tr>
            <tr>
                <td>Password: </td>    
                <td><asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>    
            </tr>
            <tr>
                <td>Confirm Password: </td>
                <td><asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ConfirmPasswordValidator" runat="server" ErrorMessage="Confirm Password" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="PasswordCompareValidator" runat="server" ErrorMessage="Password should match" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" Display="Dynamic"></asp:CompareValidator>
                </td>
           </tr>
            <tr>
                <td>Email: </td>    
                <td><asp:TextBox ID="txtEmail" runat="server" ControlToValidate="txtEmail"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ErrorMessage="Email Required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="Invalid Email" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">></asp:RegularExpressionValidator>
                </td>    
            </tr>
            <tr>
                <td></td>    
                <td><asp:Button ID="btnRegister" runat="server" Text="Register" onclick="btnRegister_Click"/></td>    
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>    
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" runat="server" />
                </td>    
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
