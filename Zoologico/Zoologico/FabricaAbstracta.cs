using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    interface FabricaAbstracta
    {
        Mamifero getMamifero(string Tipo);
        Ave getAve(string Tipo);
        Pez getPez(string Tipo, string nombre, double longitud);
    }
}
