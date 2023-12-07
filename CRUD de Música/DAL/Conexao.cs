using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_de_Música.DAL
{
    class Conexao
    {
        string conecta = "SERVER=localhost; DATABASE=pessoas; UID=root; PWD=071187";

        protected MySqlConnection conexao = null;
        
        public void AbrirConexao()
        {
            conexao = new.MySqlConnection(conecta);
        }
        public void FecharConexao()
        {

        }
    }
}
