using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica6
{
    class Ejercicio2
    {
        static int Alto = 0, Ancho = 0, x = 0, y = 0;
        static string caracter;
        static void Main(string[] args)
        {
            Console.Write("Alto: ");
            Alto = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nAncho: ");
            Ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n/////////////////////////////////////////////////////////");
            Console.WriteLine("\nNOTA: DEJAR EN BLANCO PARA OCUPAR DATOS PREDETERMINADOS");
            Console.WriteLine("\nCaracter a utilizar: ");
            caracter = Console.ReadLine();
            if (caracter == "")
            {

                coor();
                if (x == 0 && y == 0)
                {
                    Console.Clear();
                    Dibujo(Ancho, Alto);
                }
                else
                {
                    Console.Clear();
                    caracter = "*";
                    Dibujo(Ancho, Alto, caracter, x, y);
                }

            }
            else
            {
                coor();
                if (x == 0 && y == 0)
                {
                    Console.Clear();
                    Dibujo(Ancho, Alto, caracter);
                }
                else
                {
                    Console.Clear();
                    Dibujo(Ancho, Alto, caracter, x, y);

                }
            }
            Console.ReadKey();
        }

        static void coor()
        {
            Console.WriteLine("\nCoordenandas:" +
                    "\nX: ");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                coX:
                Console.WriteLine("\nY: ");
                if (int.TryParse(Console.ReadLine(), out y))
                {
                    Console.Clear();
                    Dibujo(Ancho, Alto);
                }
                else
                {
                    Console.Clear();
                    goto coX;
                }
            }
        }
        static void Dibujo(int ancho, int alto)
        {
            string figura = "";
            string carac = "* ";

            for (int i = 1; i <= alto; i++)
            {
                figura = figura + "\n";
                for (int i2 = 1; i2 <= ancho; i2++)
                {
                    if (i == 1 || i == alto)
                    {
                        figura = figura + carac;
                    }
                    else
                    {
                        if (i2 == 1 || i2 == ancho)
                        {
                            figura = figura + carac;
                        }
                        else
                        {
                            figura = figura + "  ";
                        }
                    }
                }
            }
            Console.WriteLine(figura);
        }

        static void Dibujo(int ancho, int alto, string cara)
        {
            string figura = "";

            for (int i = 1; i <= alto; i++)
            {
                figura = figura + "\n";
                for (int i2 = 1; i2 <= ancho; i2++)
                {
                    if (i == 1 || i == alto)
                    {
                        figura = figura + cara + " ";
                    }
                    else
                    {
                        if (i2 == 1 || i2 == ancho)
                        {
                            figura = figura + cara + " ";
                        }
                        else
                        {
                            figura = figura + "  ";
                        }
                    }
                }
            }
            Console.WriteLine(figura);
        }

        static void Dibujo(int ancho, int alto, string cara, int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            string figura = "";
            for (int i = 1; i <= alto; i++)
            {
                figura = figura + "\n";
                for (int i2 = 1; i2 <= ancho; i2++)
                {
                    if (i == 1 || i == alto)
                    {
                        figura = figura + cara + " ";
                    }
                    else
                    {
                        if (i2 == 1 || i2 == ancho)
                        {
                            figura = figura + cara + " ";
                        }
                        else
                        {
                            figura = figura + "  ";

                        }
                    }
                }
            }
            Console.WriteLine(figura);
        }
    }
}
