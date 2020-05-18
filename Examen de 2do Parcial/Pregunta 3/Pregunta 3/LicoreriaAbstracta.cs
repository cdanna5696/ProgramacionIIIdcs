using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    abstract class LicoreriaAbstracta
    {
        protected string nombre;
        public string getnombre()
        {
            return nombre;
        }
        public void setNombre(string n)
        {
            nombre = n;
        }
        public abstract double getPrecio();
    }
}
