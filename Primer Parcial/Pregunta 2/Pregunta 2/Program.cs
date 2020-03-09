using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    class Program
    {
        public Program(int Mesa, string Eleccion, string Ciudad, int MAS, int CC, int Juntos, int Crecer)
        {
            this.Mesa = Mesa;
            this.Eleccion = Eleccion;
            this.Ciudad = Ciudad;
            this.MAS = MAS;
            this.CC = CC;
            this.Juntos = Juntos;
            this.Crecer = Crecer;
        }
        public int Mesa { get; set; }
        public string Eleccion { get; set; }
        public string Ciudad { get; set; }
        public int MAS { get; set; }
        public int CC { get; set; }
        public int Juntos { get; set; }
        public int Crecer { get; set; }
    }
}
