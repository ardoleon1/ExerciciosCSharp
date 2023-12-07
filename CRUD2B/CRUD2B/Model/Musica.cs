using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_de_Música.Model
{
    public class Musica
    {
        public int Id { get; set; }
        public string ISRC { get; set; }
        public string Lancamento { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Interprete { get; set; }
        public string Produtor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
    }
}
