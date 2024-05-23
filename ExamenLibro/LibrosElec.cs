using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenLibro
{
    public class LibrosElec : Libros
    {
        public string Formato { get; set; }
        public string TamArchivo { get; set; }

        public LibrosElec()
        {
            Formato = string.Empty;
            TamArchivo = string.Empty; 
        }
    }
}
