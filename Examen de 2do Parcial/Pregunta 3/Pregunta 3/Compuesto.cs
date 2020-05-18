using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Compuesto : LicoreriaAbstracta
    {
        List<LicoreriaAbstracta> bebida;
        double descuento;
        public Compuesto(string nombre, double descuento)
        {
            bebida = new List<LicoreriaAbstracta>();
            this.nombre = nombre;
            this.descuento = descuento; 
        }
        public void ingresarbebida(LicoreriaAbstracta p)
        {
            bebida.Add(p);
        }
        public double getDescuento()
        {
            return descuento;
        }
        public override double getPrecio()
        {
            double aux = 0;
            foreach (LicoreriaAbstracta elemento in bebida)
            {
                aux += elemento.getPrecio();
            }
            aux = aux - descuento;
            return aux;
        }
       
    }
}
