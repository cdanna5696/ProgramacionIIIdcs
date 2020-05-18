using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    class Memorandum : ClassDocumento;
    {
        public Memorandum(int fecha, string asunto, string para)
        {
            Fecha = fecha;
            Asunto = asunto;
            Para = para; 
        }
        protected int Fecha;
        protected string Asunto;
        protected string Para;
        public override string ToString()
        {
            return (Fecha + " " + Asunto + " " + Para + " ");
        }
    }
}
