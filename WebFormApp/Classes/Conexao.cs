using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WebFormApp.Classes
{
    public static class Conexao
    {
        private static readonly SqlConnection instance = new SqlConnection(StrConexao);

        private static string StrConexao
        {
            get { return @"Data Source=FABIO-MOBILE\SQLEXPRESS;Initial Catalog=Livraria;User Id=SA;Password=1234"; }
        }

        /// <summary>
        /// Retorna um objeto do tipo SqlConnection contendo a conexão com o banco de dados
        /// </summary>
        public static SqlConnection Instance
        {
            get
            {
                if (instance.State == ConnectionState.Closed)
                {
                    instance.Open();
                }

                return instance;
            }
        }
    }
}