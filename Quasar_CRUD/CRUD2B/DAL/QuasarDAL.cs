using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using Quasar_CRUD.Model;
using System.Data;
using System.Windows.Forms;

namespace Quasar_CRUD.DAL
{
    public class QuasarDAL : Conexao
    {
        MySqlCommand comando = null;

        //Método para Excluir
        public void Excluir(Quasar quasar)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM quasar WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", quasar.Id);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //Método para Alterar
        public void Alterar(Quasar quasar)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE quasar SET nome = @nome, descoberta = @descoberta," +
                    "red = @red, massa = @massa, lumi = @lumi, gala = @gala WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", quasar.Id);
                comando.Parameters.AddWithValue("@nome", quasar.Nome);
                comando.Parameters.AddWithValue("@descoberta", DateTime.Parse(quasar.Descoberta).ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@red", quasar.Red);
                comando.Parameters.AddWithValue("@massa", quasar.Massa);
                comando.Parameters.AddWithValue("@lumi", quasar.Lumi);
                comando.Parameters.AddWithValue("@gala", quasar.Gala);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //Método para salvar
        public void Salvar(Quasar quasar)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO quasar (nome, descoberta, red, massa, " +
                    "lumi, gala) VALUES (@nome, @descoberta, @red, @massa, @lumi, @gala)", conexao);

                comando.Parameters.AddWithValue("@nome", quasar.Nome);
                comando.Parameters.AddWithValue("@descoberta", DateTime.Parse(quasar.Descoberta).ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@red", quasar.Red);
                comando.Parameters.AddWithValue("@massa", quasar.Massa);
                comando.Parameters.AddWithValue("@lumi", quasar.Lumi);
                comando.Parameters.AddWithValue("@gala", quasar.Gala);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método para Listar os dados
        public DataTable Listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT * FROM quasar ORDER BY nome", conexao);
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message, "Erro ao conectar com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao listar os dados DAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
