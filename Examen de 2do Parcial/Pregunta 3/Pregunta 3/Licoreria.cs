using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Licoreria : LicoreriaAbstracta
    {
        double precio;
        string nombre; 
        public Licoreria(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public override double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double p)
        {
            precio = p;
        }
    }
}
