using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenLibro
{
    public class Revistas : Libros
    {
        public int Volumen { get; set; }
        public int  NuEjemp {get; set;}

        public Revistas()
        {
            Volumen = 0;
            NuEjemp = 0;
        }
    }
}
