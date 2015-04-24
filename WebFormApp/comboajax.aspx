<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="comboajax.aspx.cs" Inherits="WebFormApp.comboajax" EnableViewState="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Combo com ajax</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo">
            <asp:Label ID="lblAutor" Text="Autor" runat="server"></asp:Label><br />
            <asp:DropDownList ID="cmbAutor" runat="server"></asp:DropDownList>

            <br /><br />

            <asp:Label ID="lblLivros" Text="Livros" runat="server"></asp:Label><br />
            <asp:DropDownList ID="cmbLivros" runat="server"></asp:DropDownList>
        </div>

        <div id="menssagem"></div>
    </form>
    <script type="text/javascript" src="assets/js/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="assets/js/webformapp.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            InicializaComponentes();
        });
    </script>
</body>
</html>
