using System;

namespace Pregunta_1
{
    delegate int Aritmetica(int x, int y, int z);
    public class CSharpApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicar: 2*3*4");
            Console.WriteLine(DoOperacion(Multiplicacion, 2, 3, 4));
            Console.WriteLine("Multiplicar: 3*4*2 ");
            Console.WriteLine(DoOperacion(Multiplicacion, 3, 4, 2));
            Console.WriteLine("Multiplicar: -4*(-3)*(-6)");
            Console.WriteLine(DoOperacion(Multiplicacion, -4, -3, -6));

            Console.ReadKey();
        }
        static int DoOperacion(Aritmetica op, int x, int y, int z)
        {
            return (op(x, y, z));
        }
        static int Multiplicacion(int x, int y, int z)
        {
            return x * y * z;
        }

    }
}
