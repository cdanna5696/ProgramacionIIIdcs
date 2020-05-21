using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FaricaPez : FabricaAbstracta
    {
        public Pez getPez(string Tipo, string nombre, double longitud)
        {
            switch (Tipo)
            {
                case "Pacu":
                    return new Pacu(nombre, longitud);
                case "Sabalo":
                    return new Sabalo(nombre, longitud);
                default:
                    return null;
            }
        }
        public Ave getAve(string Tipo)
        {
            throw new NotImplementedException();
        }

        public Mamifero getMamifero(string Tipo)
        {
            throw new NotImplementedException();
        }

        public Pez getPez(string Tipo)
        {
            throw new NotImplementedException();
        }
    }
}
