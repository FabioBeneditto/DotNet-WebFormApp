﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormApp.Classes;

namespace WebFormApp
{
    public partial class comboajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["acao"] == null)
            {
                this.CarregaAutores();

                cmbLivros.Items.Add(new ListItem("Selecione um autor", ""));
            }
            else
            {
                if (Request.Form["acao"] == "livros")
                {
                    Response.Clear();
                    Response.ContentType = "application/json; charset=utf-8";
                    Response.Write(this.CarregaLivros());
                    Response.End();
                }
            }
        }

        private void CarregaAutores()
        {
            SqlConnection cnn = Conexao.Instance;

            try
            {
                // recuperando os dados do banco de dados
                SqlCommand cmd = new SqlCommand("Select * from Autor order by Nome", cnn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable autores = new DataTable();
                ad.Fill(autores);

                // Configura quais os campos que serão utilizados como valor e descrição
                cmbAutor.DataValueField = "CodAutor";
                cmbAutor.DataTextField = "Nome";

                cmbAutor.DataSource = autores;
                cmbAutor.DataBind();
            }
            catch (Exception ex)
            {
                //menssagem.InnerHtml = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        private string CarregaLivros()
        {
            string json = "";
            SqlConnection cnn = Conexao.Instance;

            try
            {
                // recuperando os dados do banco de dados
                SqlCommand cmd = new SqlCommand("Select * from Livro where CodAutor = @CodAutor order by Titulo", cnn);
                cmd.Parameters.AddWithValue("@CodAutor", Convert.ToInt32(Request.Form["codautor"]));
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable livros = new DataTable();
                ad.Fill(livros);

                var lstLivros = livros.AsEnumerable().Select(
                    l => new {
                        Codigo = l.Field<int>("CodLivro"), 
                        Descricao = l.Field<string>("Titulo")   
                    });
                
                System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                json = serializer.Serialize(lstLivros);
            }
            catch (Exception ex)
            {
                //menssagem.InnerHtml = ex.Message;
            }
            finally
            {
                cnn.Close();
            }

            return json;
        }
    }
}