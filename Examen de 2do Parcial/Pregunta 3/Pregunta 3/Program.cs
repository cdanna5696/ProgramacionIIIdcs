using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Licoreria Cerveza = new Licoreria("Cerveza", 10);
            Licoreria Ron = new Licoreria("Ron", 85);
            Licoreria Wisky = new Licoreria("Wisky", 120);
            Licoreria CocaCola  = new Licoreria("Coca Cola", 12);

            Compuesto CajadeCerveza = new Compuesto("Caja de Cerveza", 145);
            CajadeCerveza.ingresarbebida(Cerveza);
            CajadeCerveza.ingresarbebida(CocaCola);

            Compuesto ComboCarnavalero = new Compuesto("ComboCarnavalero", 90);
            ComboCarnavalero.ingresarbebida(Ron);
            Console.WriteLine("El precio del Ron por uniad es: " + Ron.getPrecio());
            ComboCarnavalero.ingresarbebida(CocaCola);
            Console.WriteLine("El precio de la Coca Cola por uniad es: " + CocaCola.getPrecio());
            ComboCarnavalero.ingresarbebida(Wisky);
            Console.WriteLine("El precio del Wisky por uniad es: " + Wisky.getPrecio());


            Console.WriteLine("El precio de la caja de cerveza es: " + CajadeCerveza.getPrecio());
            Console.WriteLine("El precio del Combo es: " + ComboCarnavalero.getPrecio());
            
            Console.ReadKey();
        }
    }
}
