using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class ConnectionFactory
    {
        public static IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "string de conexão aqui";
            conexao.Open();

            return conexao;
        }
    }
    }
}
