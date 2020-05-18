using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    abstract class ClassDocumento : Documentoabstract
    {
        public Carta Getcarta(int fecha, string origen, string anuncio)
        {
            throw new NotImplementedException();
        }
        public Circular GetCircular(string de, int fecha, string para, string asunto)
        {
            throw new NotImplementedException();
        }
        public Memorandum GetMemorandum (int fecha, string asunto,string para)
        {
            throw new NotImplementedException();
        }
    }
}
