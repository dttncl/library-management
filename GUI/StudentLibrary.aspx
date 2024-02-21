<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLibrary.aspx.cs" Inherits="LibraryManagement.GUI.StudentLibrary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <h1>Student Library</h1>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <h3>Welcome, <asp:Label ID="LabelStudentName" runat="server" Text="Label"></asp:Label>
                        </h3>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td>Available Books</td>
                                <td>&nbsp;</td>
                                <td>Borrowed Books</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList ID="DropDownListAvailBooks" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListAvailBooks_SelectedIndexChanged">
                                    </asp:DropDownList>
                                &nbsp;by
                                    <asp:Label ID="LabelABAuthor" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="ButtonBorrow" runat="server" Text="Borrow Book" Width="127px" OnClick="ButtonBorrow_Click" />
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownListBorrowBooks" runat="server" AutoPostBack="True" EnableTheming="True" OnSelectedIndexChanged="DropDownListBorrowBooks_SelectedIndexChanged">
                                    </asp:DropDownList>
                                &nbsp;by
                                    <asp:Label ID="LabelBBAuthor" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="ButtonReturn" runat="server" Text="Return Book" Width="127px" OnClick="ButtonReturn_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Calendar ID="CalendarBorrow" runat="server" OnSelectionChanged="CalendarBorrow_SelectionChanged"></asp:Calendar>
                                </td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    <asp:Calendar ID="CalendarReturn" runat="server"></asp:Calendar>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
