using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Quasar_CRUD.DAL
{
    public class Conexao
    {
        string conecta = "SERVER=localhost; DATABASE=quasars; UID=root; PWD= ";

        protected MySqlConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message, "Erro ao conectar com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
