using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_de_Libros
{
    class Libro
    {
        public string NombredelLibro { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñodePublicacion { get; set; }
        
        public Libro (string nombredellibro, string autor, string editorial, int añodepublicacion)
        {
            NombredelLibro = nombredellibro;
            Autor = autor;
            Editorial = editorial;
            AñodePublicacion = añodepublicacion;
        }
        public override string ToString()
        {
            return (NombredelLibro + " " + Autor + " " + Editorial + " " + AñodePublicacion + " ");
        }
    }
}
