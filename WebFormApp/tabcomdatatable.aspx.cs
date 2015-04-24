using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormApp.Classes;

namespace WebFormApp
{
    public partial class tabcomdatatable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = Conexao.Instance;

            try
            {
                // recuperando os dados do banco de dados
                SqlCommand cmd = new SqlCommand("Select * from Livro", cnn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable livros = new DataTable();
                ad.Fill(livros);

                // Renderizando uma tabela da forma mais simples e direta possível
                conteudo.InnerHtml = this.RenderizaGridLivros1(livros);
                divLivros2.InnerHtml = this.RenderizaGridLivros2(livros);

                tabLivros3.AutoGenerateColumns = false;
                tabLivros3.DataSource = livros;
                tabLivros3.DataBind();
            }
            catch (Exception ex)
            {
                menssagem.InnerHtml = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        private string RenderizaGridLivros1(DataTable livros)
        {
            // criando um GridView para visualizar as informações
            GridView tabLivros = new GridView();
            tabLivros.ID = "tabLivros";
            tabLivros.DataSource = livros;
            tabLivros.DataBind();

            StringWriter ms = new StringWriter();
            HtmlTextWriter htmlTW = new HtmlTextWriter(ms);

            tabLivros.RenderControl(htmlTW);
            return ms.ToString();
        }

        private string RenderizaGridLivros2(DataTable livros)
        {
            // criando um GridView para visualizar as informações
            GridView tabLivros = new GridView();
            tabLivros.ID = "tabLivros2";
            tabLivros.DataSource = livros;

            tabLivros.AutoGenerateColumns = false;

            BoundField colTitulo = new BoundField();
            colTitulo.DataField = "Titulo";
            colTitulo.HeaderText = "Livro";

            BoundField colPaginas = new BoundField();
            colPaginas.DataField = "NumPaginas";
            colPaginas.HeaderText = "Nº páginas";

            tabLivros.Columns.Add(colTitulo);
            tabLivros.Columns.Add(colPaginas);
            tabLivros.DataBind();

            StringWriter ms = new StringWriter();
            HtmlTextWriter htmlTW = new HtmlTextWriter(ms);

            tabLivros.RenderControl(htmlTW);
            return ms.ToString();
        }
    }
}