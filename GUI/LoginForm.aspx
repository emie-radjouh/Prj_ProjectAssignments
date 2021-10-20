<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Prj_PracticeMidterm.GUI.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 107px;
        }
        .auto-style3 {
            height: 62px;
        }
        .auto-style4 {
            height: 67px;
        }
        .auto-style5 {
            height: 68px;
        }
        .auto-style6 {
            height: 113px;
        }
        .auto-style7 {
            position: absolute;
            top: 15px;
            left: 567px;
            z-index: 1;
        }
        .auto-style8 {
            height: 62px;
            text-align: center;
        }
        .auto-style10 {
            position: absolute;
            top: 138px;
            left: 746px;
            z-index: 1;
            margin-bottom: 6px;
        }
        .auto-style11 {
            position: absolute;
            top: 231px;
            left: 747px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 327px;
            left: 761px;
            z-index: 1;
            bottom: 418px;
        }
        .auto-style13 {
            position: absolute;
            top: 418px;
            left: 759px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 326px;
            left: 956px;
            z-index: 1;
            width: 315px;
            height: 31px;
        }
        .auto-style15 {
            position: absolute;
            top: 417px;
            left: 957px;
            z-index: 1;
            height: 31px;
            width: 315px;
        }
        .auto-style17 {
            position: absolute;
            top: 562px;
            left: 1209px;
            z-index: 1;
            height: 47px;
            width: 181px;
            right: 53px;
        }
        .auto-style19 {
            position: absolute;
            top: 61px;
            left: 13px;
            z-index: 1;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <body style="background-color:#CBDBE5;"></body>
                                          
        <div class="auto-style8">
            <asp:Label ID="lblSchoolName" runat="server" CssClass="auto-style7" Font-Size="XX-Large" Text="Saint Michel Technology Institution" Font-Italic="True"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:RadioButton ID="rbTeacher" runat="server" CssClass="auto-style10" Font-Size="X-Large" Text="Teacher" OnCheckedChanged="rbTeacher_CheckedChanged" GroupName="Identification" />
                    <asp:RadioButton ID="rbStudent" runat="server" CssClass="auto-style11" Font-Size="X-Large" Text="Student" GroupName="Identification" />
                    <asp:TextBox ID="txtID" runat="server" CssClass="auto-style14" OnTextChanged="txtID_TextChanged" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style15" Font-Size="Medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblID" runat="server" CssClass="auto-style12" Font-Size="X-Large" Text="Identification:"></asp:Label>
                    <asp:Image ID="Image1" runat="server" Height="510" Width="510" CssClass="auto-style19" ImageUrl="~/Image/TechLogoWithoutBackground-modified.png" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" CssClass="auto-style13" Font-Size="X-Large" Text="Password:"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="btnLogin" runat="server" BackColor="#3399FF" CssClass="auto-style17" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Login" OnClick="btnLogin_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
