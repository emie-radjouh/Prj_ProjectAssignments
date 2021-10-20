<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherForm.aspx.cs" Inherits="Prj_PracticeMidterm.GUI.TeacherForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style5 {
            position: absolute;
            top: 90px;
            left: 482px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 90px;
            left: 1003px;
            z-index: 1;
            width: 116px;
        }
        .auto-style7 {
            position: absolute;
            top: 138px;
            left: 389px;
            z-index: 1;
            height: 35px;
            width: 280px;
            right: 896px;
        }
        .auto-style8 {
            position: absolute;
            top: 137px;
            left: 909px;
            z-index: 1;
            width: 280px;
            height: 35px;
        }
        .auto-style9 {
            width: 423px;
            height: 163px;
            position: absolute;
            top: 284px;
            left: 838px;
            z-index: 1;
            margin-top: 0px;
        }
        .auto-style10 {
            width: 423px;
            height: 163px;
            position: absolute;
            top: 284px;
            left: 364px;
            z-index: 1;
            margin-top: 0px;
        }
        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            position: absolute;
            top: 542px;
            left: 518px;
            z-index: 1;
            width: 139px;
        }
        .auto-style14 {
            position: absolute;
            top: 543px;
            left: 749px;
            z-index: 1;
            width: 139px;
            height: 30px;
        }
        .auto-style15 {
            height: 298px;
        }
        .auto-style16 {
            position: absolute;
            top: 38px;
            left: 1171px;
            z-index: 1;
            margin-top: 0px;
        }
        .auto-style17 {
            position: absolute;
            top: 207px;
            left: 1026px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 209px;
            left: 540px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 198px;
            left: 88px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 483px;
            left: 91px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 543px;
            left: 975px;
            right: 635px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <body style="background-color:#CBDBE5;"></body>
        <div>
        </div>
        <p>
            <asp:Button ID="Button3" runat="server" CssClass="auto-style14" Text="List Projects" OnClick="Button3_Click" />
            <asp:Label ID="lblWelcome" runat="server" CssClass="auto-style16" Font-Italic="True" Font-Size="XX-Large" Text="Welcome,"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Students" Font-Size="Large"></asp:Label>
        <p>
            <asp:DropDownList ID="DropListStudents" runat="server" CssClass="auto-style7" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="Projects" Font-Size="Large"></asp:Label>
            <asp:GridView ID="gridViewStudents" runat="server" CssClass="auto-style9">
            </asp:GridView>
        </p>
        <asp:DropDownList ID="DropListProjects" runat="server" CssClass="auto-style8">
        </asp:DropDownList>
        <p>
            <asp:Button ID="btnAssignProjects" runat="server" CssClass="auto-style12" height="29px" Text="Assign Projects" OnClick="btnAssign_Click" />
            <asp:Calendar ID="calendarAssigned" runat="server" style="position: relative"></asp:Calendar>
        </p>
        <asp:GridView ID="gridViewProjects" runat="server" CssClass="auto-style10">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" CssClass="auto-style17" Text="Students"></asp:Label>
&nbsp;<asp:Label ID="Label6" runat="server" CssClass="auto-style21" Text="Assigned Date"></asp:Label>
        <asp:Label ID="Label7" runat="server" CssClass="auto-style22" Text="Submitted Date"></asp:Label>
        <asp:Button ID="btnListStudents" runat="server" CssClass="auto-style23" OnClick="btnListStudents_Click" Text="List Students" />
        <table class="auto-style11">
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label5" runat="server" CssClass="auto-style20" Text="Projects"></asp:Label>
                    <asp:Calendar ID="calendarSubmit" runat="server" style="position: relative"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
