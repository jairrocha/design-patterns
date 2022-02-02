using System;
using System.Data;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = ConnectionFactory.GetConnection();
            IDbCommand command = conexao.CreateCommand();
            command.CommandText = " SELECT * FROM TB_USERS";
        }
    }
}
