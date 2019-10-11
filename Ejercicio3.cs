using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica6
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            double numero = 0, pot = 0;
            Console.WriteLine("Ingrese la base: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nIngrese la potencia: ");
            pot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n=====================================");
            Console.WriteLine("Resultado: {0}", Potecia(numero, pot));
            Console.ReadKey();
        }

        static double Potecia(double num, double pot)
        {
            double result = Math.Pow(num, pot);
            return result;
        }
    }
}
