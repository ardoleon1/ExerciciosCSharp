using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quasar_CRUD.Model;
using Quasar_CRUD.DAL;
using System.Data;
using System.Windows.Forms;

namespace Quasar_CRUD.BLL
{
    public class QuasarBLL
    {
        QuasarDAL quasarDAL = new QuasarDAL();
        
        //Método para Excluir
        public void Excluir(Quasar quasar)
        {
            try
            {
                quasarDAL.Excluir(quasar);
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
                quasarDAL.Alterar(quasar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //Método prara Salvar
        public void Salvar(Quasar quasar)
        {
            try
            {
                quasarDAL.Salvar(quasar);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        //Método para Listar
        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = quasarDAL.Listar();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
