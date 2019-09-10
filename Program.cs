using System;

namespace Práctica6
{
    class Program
    {
        //Valencia Machado, Elí Adonay
        //08-09-19
        static void Main(string[] args)
        {
            int nump, colorp = 5;
            Console.WriteLine("Ingrese un número: ");
            nump = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n/////////////////////////////////////////////////////////");
            Console.WriteLine("\nNOTA: DEJAR EN BLANCO PARA OCUPAR DATOS PREDETERMINADOS");
            try
            {
                Console.WriteLine("\nCaolor a utilizar: ");
                Console.WriteLine("\n [1] Azul" +
                                  "\n [2] Rojo" +
                                  "\n [3] Verde" +
                                  "\n [4] Amarillo");
                colorp = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Color de predeterminado.");
            }
            goto SALIDA;

                SALIDA: 

            Console.Clear();
            Console.WriteLine("Tabla del " + nump + ":\n" + tabla(nump));
            Console.ReadKey();
        }

        static string tabla(int num)
        {
            string multi = "";
            for (int i = 1; i <= 10; i++)
            {
                multi = multi + "\n" + Convert.ToString(num);
                multi = multi + " * " + Convert.ToString(i);
                multi = multi + " = " + Convert.ToString(num * i);


            }
            return multi;
        }

        static string tabla(int num, int color = 5)
        {

            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Azul");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rojo");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Verde");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Amarillo");
                    break;
                default:
                    Console.WriteLine("Color por defecto\n");
                    break;
            }
            string multi = "";
            for (int i = 1; i <= 10; i++)
            {
                multi = multi + "\n" + Convert.ToString(num);
                multi = multi + " * " + Convert.ToString(i);
                multi = multi + " = " + Convert.ToString(num * i);
            }
            return multi;
        }
    }
}
