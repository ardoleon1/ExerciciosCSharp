using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD2B.Model;
using CRUD2B.DAO;
using System.Data;
using System.Windows.Forms;

namespace CRUD2B.BLL
{
    public class PessoaBLL
    {
        PessoaDAO pessoaDAO = new PessoaDAO();

        //Método prara salvar
        public void Salvar(Pessoa pessoa)
        {
            try
            {
                pessoaDAO.Salvar(pessoa);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw erro;
            }
        }

        //Método para Listar
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pessoaDAO.Listar();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
