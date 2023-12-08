using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using CRUD_de_Música.Model;
using System.Data;
using System.Windows.Forms;

namespace CRUD_de_Música.DAL
{
    public class MusicaDAL : Conexao
    {
        MySqlCommand comando = null;

        //Método para Excluir
        public void Excluir(Musica musica)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM musica WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", musica.Id);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        //Método para Alterar
        public void Alterar(Musica musica)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE musica SET titulo = @titulo, lancamento = @lancamento," +
                    "isrc = @isrc, autor = @autor, interprete = @interprete, produtor = @produtor," +
                    "editora = @editora, genero = @genero WHERE id = @id", conexao);

                comando.Parameters.AddWithValue("@id", musica.Id);
                comando.Parameters.AddWithValue("@titulo", musica.Titulo);
                comando.Parameters.AddWithValue("@lancamento", musica.Lancamento);
                comando.Parameters.AddWithValue("@isrc", musica.ISRC);
                comando.Parameters.AddWithValue("@autor", musica.Autor);
                comando.Parameters.AddWithValue("@interprete", musica.Interprete);
                comando.Parameters.AddWithValue("@produtor", musica.Produtor);
                comando.Parameters.AddWithValue("@editora", musica.Editora);
                comando.Parameters.AddWithValue("@genero", musica.Genero);

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
        public void Salvar(Musica musica)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO musica (titulo, lancamento, isrc, autor, " +
                    "interprete, produtor, editora, genero) VALUES (@titulo, @lancamento, " +
                    "@isrc, @autor, @interprete, @produtor, @editora, @genero)", conexao);

                comando.Parameters.AddWithValue("@titulo", musica.Titulo);
                comando.Parameters.AddWithValue("@lancamento", DateTime.Parse(musica.Lancamento).ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@isrc", musica.ISRC);
                comando.Parameters.AddWithValue("@autor", musica.Autor);
                comando.Parameters.AddWithValue("@interprete", musica.Interprete);
                comando.Parameters.AddWithValue("@produtor", musica.Produtor);
                comando.Parameters.AddWithValue("@editora", musica.Editora);
                comando.Parameters.AddWithValue("@genero", musica.Genero);

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
                comando = new MySqlCommand("SELECT * FROM musica ORDER BY titulo", conexao);
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
