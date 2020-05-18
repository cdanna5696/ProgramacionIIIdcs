using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    class Circular : ClassDocumento
    {
        public Circular(string de, int fecha, string para, string asunto)
        {
            De = de;
            Fecha = fecha;
            Para = para;
            Asunto = asunto;
        }
        protected string De;
        protected int Fecha;
        protected string Para;
        protected string Asunto;
        public override string ToString()
        {
            return (De + " " + Fecha + " " + Fecha + " " + Asunto + " ");
        }

    }
}
