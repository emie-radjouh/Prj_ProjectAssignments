<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="Prj_PracticeMidterm.GUI.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 68px;
            left: 62px;
            z-index: 1;
        }
        .auto-style2 {
            width: 915px;
            height: 290px;
            position: absolute;
            top: 228px;
            left: 340px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 94px;
            left: 729px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <body style="background-color:#CBDBE5;"></body>
        <div>
        </div>
        <asp:Label ID="lblWelcome" runat="server" CssClass="auto-style1" Font-Size="XX-Large" Text="Welcome," Font-Italic="True"></asp:Label>
        <asp:GridView ID="gridViewProjects" runat="server" CssClass="auto-style2" OnSelectedIndexChanged="gridViewProjects_SelectedIndexChanged" Font-Size="Large" ForeColor="Black" >
            
            <FooterStyle BackColor="#3333CC" />
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Font-Size="XX-Large" Text="Projects"></asp:Label>
    </form>
</body>
</html>
