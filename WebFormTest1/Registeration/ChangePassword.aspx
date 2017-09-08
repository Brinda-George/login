﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="WebFormTest1.Registeration.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <table style="border: 1px solid black">
                <tr>
                    <td colspan="2"><b>Change Password</b></td>
                </tr>
                <tr id="trCurrentPassword" runat="server">
                        <td>Current Password: </td>
                        <td><asp:TextBox ID="txtCurrentPassword" TextMode="Password" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorCurrentPassword" runat="server" ErrorMessage="Current Password required" Text="*" ControlToValidate="txtCurrentPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                <tr>
                    <td>New Password: </td>
                    <td><asp:TextBox ID="txtNewPassword" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPassword" runat="server" ErrorMessage="New Password Required" ControlToValidate="txtNewPassword"></asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td>Confirm New Password: </td>
                    <td><asp:TextBox ID="txtConfirmNewPassword" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmNewPassword" runat="server" ErrorMessage="Confirm Password" ControlToValidate="txtConfirmNewPassword" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ErrorMessage="Password must match" ControlToValidate="txtConfirmNewPassword" ControlToCompare="txtNewPassword" Display="Dynamic"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        &nbsp;<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" Width="70px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
