<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabcomdatatable.aspx.cs" Inherits="WebFormApp.tabcomdatatable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="conteudo" runat="server"></div>

        <br /><br />

        <div id="divLivros2" runat="server"></div>

        <br /><br />

        <div id="divLivros3" runat="server">
            <asp:GridView ID="tabLivros3" runat="server">
                <Columns>
                    <asp:BoundField DataField="Titulo" HeaderText="Título" />
                    <asp:BoundField DataField="NumPaginas" HeaderText="Páginas" />
                    <asp:BoundField DataField="Ano" HeaderText="Ano" />
                    <asp:BoundField DataField="Editora" HeaderText="Editora" />
                    <asp:BoundField DataField="Preco" HeaderText="Preço" DataFormatString="{0:N}" />
                    <asp:HyperLinkField DataNavigateUrlFields="CodLivro" Text="Editar" DataNavigateUrlFormatString="editalivro.aspx?id={0}" />

                </Columns>
            </asp:GridView>
            
            <%--Opções de DataFormatString--%>
            <%--https://msdn.microsoft.com/pt-br/library/system.web.ui.webcontrols.boundfield.dataformatstring(v=vs.110).aspx--%>
        </div>

        <div id="menssagem" runat="server"></div>
    </form>
</body>
</html>
