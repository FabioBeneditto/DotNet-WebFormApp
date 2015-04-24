<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li>
                <asp:HyperLink ID="lnkTabComDataTable" Text="Tabela com DataTable" NavigateUrl="tabcomdatatable.aspx" runat="server"></asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="lnkComboDataTable" Text="Combobox com ViewState" NavigateUrl="combodinamico.aspx" runat="server"></asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="likComboMulti" Text="Combobox Ajax" NavigateUrl="comboajax.aspx" runat="server"></asp:HyperLink>
            </li>
        </ul>
        
    </div>
    </form>
</body>
</html>
