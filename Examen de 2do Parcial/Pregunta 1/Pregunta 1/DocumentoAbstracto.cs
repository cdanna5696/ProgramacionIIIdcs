using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    interface Documentoabstract
    {
        Carta getCarta(int fecha, string origen, string asunto);
        Circular getCircular(string de, int fecha, string para, string asunto );
        Memorandum getMemorandum(int fecha, string asunto, string para);
        
    }
}
