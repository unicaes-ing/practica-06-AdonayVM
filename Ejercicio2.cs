using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica6
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dibujo(5,5));
            Console.ReadKey();
        }

        static string Dibujo(int ancho, int alto)
        {
            string figura = "";

            for (int i = 1; i <= alto; i++)
            {
                figura = figura + "\n";
                for (int i2 = 1; i2 <= ancho; i2++)
                {
                    if (i == 1 || i == alto)
                    {
                        figura = figura + "* ";
                    }
                    else
                    {
                        if (i2 == 1 || i2 == ancho)
                        {
                            figura = figura + "* ";
                        }
                        else
                        {
                            figura = figura + "  ";
                        }

                    }

                }
            }

            return figura;
        }

        
    }
}
