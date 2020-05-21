using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    class FabricaAve : FabricaAbstracta
    {
        public Ave getAve(string Tipo, string nombre, double peso, int tamañoalas)
        {
            switch (Tipo)
            {
                case "Lora":
                    return new Loro(nombre, peso, tamañoalas);
                case "Aguila":
                    return new Agula(nombre, peso, tamañoalas);
                case "Condor":
                    return new Condor(nombre, peso, tamañoalas);

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

        public Pez getPez(string Tipo, string nombre, double longitud)
        {
            throw new NotImplementedException();
        }
    }
}
