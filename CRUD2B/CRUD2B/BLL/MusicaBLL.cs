﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_de_Música.Model;
using CRUD_de_Música.DAL;
using System.Data;
using System.Windows.Forms;

namespace CRUD_de_Música.BLL
{
    public class MusicaBLL
    {
        MusicaDAL musicaDAL = new MusicaDAL();
        
        //Método para Excluir
        public void Excluir(Musica musica)
        {
            try
            {
                musicaDAL.Excluir(musica);
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
                musicaDAL.Alterar(musica);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        //Método prara Salvar
        public void Salvar(Musica musica)
        {
            try
            {
                musicaDAL.Salvar(musica);
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
                dt = musicaDAL.Listar();
                return dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
