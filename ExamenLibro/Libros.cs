using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenLibro
{
    public class Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public DateTime AnPublicacion { get; set;  }

        public Libros()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            AnPublicacion = DateTime.MinValue;
        }
    }
}
