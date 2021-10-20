<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormProjectAssignments.aspx.cs" Inherits="Prj_PracticeMidterm.GUI.WebFormProjectAssignments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" Font-Size="Large" style="z-index: 1; left: 593px; top: 39px; position: absolute; height: 31px; width: 344px" Text="Student-Project Assignment Form"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:DropDownList ID="DropDownProject" runat="server" style="z-index: 1; left: 878px; top: 99px; position: absolute; width: 172px">
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownStudent" runat="server" style="z-index: 1; left: 397px; top: 97px; position: absolute; width: 172px" OnSelectedIndexChanged="DropDownStudent_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" style="z-index: 1; left: 906px; top: 73px; position: absolute" Text="Select Project"></asp:Label>    
        <asp:Label ID="Label3" runat="server" Font-Size="Medium" style="z-index: 1; left: 393px; top: 73px; position: absolute" Text="Select Student"></asp:Label>

    </form>
</body>
</html>
