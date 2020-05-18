using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    class Carta : ClassDocumento
    {
        public Carta(int fecha, string origen, string asunto)
        {
            Fecha = fecha;
            Origen = origen;
            Asunto = asunto;       
        }
        protected int Fecha;
        protected string Origen;
        protected string Asunto;
        public override string ToString()
        {
            return (Fecha + " " + Origen + " " + Asunto + " ");
        }
    }
}
