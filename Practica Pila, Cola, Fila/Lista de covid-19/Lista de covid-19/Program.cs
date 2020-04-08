using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_covid_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            ListaDoble l = new ListaDoble();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Introduzca Nombre:");
                        string nombre = Console.ReadLine();
                        string segundoNombre = Console.ReadLine();
                        Console.WriteLine("Introduzca Apellidos;");
                        string apellido = Console.ReadLine();
                        string segundoApellido = Console.ReadLine();
                        Console.WriteLine("Introduzca Edad;");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca Sexo (M/F); ");
                        string Sexo = Console.ReadLine();
                        Console.WriteLine("Introduzca Estado: ");
                        string estado = Console.ReadLine();

                        Infectado a = new Infectado(nombre, segundoNombre, apellido, segundoApellido, edad, Sexo, estado);
                        l.Insertar(a);
                        break;
                    case 2:
                        Console.WriteLine("Que Apellido Desea Eliminar");
                        string x = (Console.ReadLine());
                        l.EliminarApellido(x);
                        Console.ReadKey();
                        break;
                    case 3:
                        l.Mostrar();
                        Console.ReadKey();
                        break;

                }
            }
        }
    }

}
