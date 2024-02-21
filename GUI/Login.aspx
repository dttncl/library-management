<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryManagement.GUI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 102px;
        }
        .auto-style3 {
            width: 102px;
            height: 69px;
        }
        .auto-style4 {
            height: 69px;
        }
        .auto-style7 {
            width: 102px;
            height: 38px;
        }
        .auto-style8 {
            height: 38px;
        }
        .auto-style9 {
            width: 102px;
            height: 39px;
        }
        .auto-style10 {
            height: 39px;
        }
        .auto-style11 {
            width: 102px;
            height: 80px;
        }
        .auto-style12 {
            height: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style11">
                        <h1></h1>
                    </td>
                    <td class="auto-style12">
                        <h1>Library Management </h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <h2><strong>Login</strong></h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>ID: <asp:TextBox ID="TextBoxID" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">Password:
                        <asp:TextBox ID="TextBoxPassword" runat="server" Width="260px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:RadioButtonList ID="RadioButtonListUser" runat="server">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonLogin" runat="server" Height="39px" OnClick="ButtonLogin_Click" Text="Login &gt;&gt;" Width="151px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
