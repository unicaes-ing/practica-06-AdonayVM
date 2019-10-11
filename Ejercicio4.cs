using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica6
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSu número en binario es: {0}", Binario(numero));
        }

        static string Binario(int num)
        {
            int sobra;
            string numBinario = "";
            do
            {
                sobra = num % 2;
                num = num / 2;
                numBinario = numBinario + Convert.ToString(sobra);

            } while (num != 0 || num != 1);

            return numBinario;
        }
    }
}
