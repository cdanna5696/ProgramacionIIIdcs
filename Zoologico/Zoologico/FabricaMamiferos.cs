using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FabricaMamiferos : FabricaAbstracta
    {
        public Ave getAve(string Tipo)
        {
            throw new NotImplementedException();
        }

        public Mamifero getMamifero(string Tipo, string nombre, int temperatura, int npatas)
        {
            switch (Tipo)
            {
                case "Leon":
                    return new Leon(nombre, temperatura, npatas);
                case "Oso":
                    return new Oso(nombre, temperatura, npatas);
                case "Mono":
                    return new Mono(nombre, temperatura, npatas);

                default:
                    return null;
            }
        }

        public Mamifero getMamifero(string Tipo)
        {
            throw new NotImplementedException();
        }

        public Pez getPez(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
