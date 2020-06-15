using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Final_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;



            ClienteSincrono x = ClienteSincrono.getInstancia();

            do
            {

                Console.WriteLine("1. Ingreso del Atleta");
                Console.WriteLine("2. Salida del Atleta");
                Console.WriteLine("3. Mostrar"); 
                Console.WriteLine("7. Salir");

                opcion = int.Parse(Console.ReadLine());
                string f;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1. Introduzca el Nombre");
                        string nombre = Console.ReadLine();
                       

                        Console.WriteLine("2. Introduzca su Sexo");
                        string sexo = Console.ReadLine();

                        Console.WriteLine("3. Introduzca su Edad");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("4. Introduzca su Peso");
                        string peso = Console.ReadLine();
                        Console.WriteLine("5. Introduzca su altura");
                        string altura = Console.ReadLine();
                        break;
                }
            } while (opcion != 5);
        }
    }
}

