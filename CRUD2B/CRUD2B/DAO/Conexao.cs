using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //adicionamos o mysql
using System.Windows.Forms;

namespace CRUD2B.DAO
{
    public class Conexao
    {
        //Propriedades para conectar ao banco
        string conecta = "SERVER=localhost; DATABASE=pessoas; UID=root; PWD='Suporte99'";

        protected MySqlConnection conexao = null;

        //Método para conectar ao banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw erro;
            }
        }

        //Método para fechar a conexão
        public void fecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw erro;
            }
        }
    }
}
