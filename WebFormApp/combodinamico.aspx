<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="combodinamico.aspx.cs" Inherits="WebFormApp.combodinamico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo">
            <asp:Label ID="lblAutor" Text="Autor" runat="server"></asp:Label><br />
            <asp:DropDownList ID="cmbAutor" runat="server" AutoPostBack="true"></asp:DropDownList>

            <br /><br />

            <asp:Label ID="lblLivros" Text="Livros" runat="server"></asp:Label><br />
            <asp:DropDownList ID="cmbLivros" runat="server"></asp:DropDownList>
        </div>


        <div id="menssagem" runat="server"></div>
    </form>
</body>
</html>
