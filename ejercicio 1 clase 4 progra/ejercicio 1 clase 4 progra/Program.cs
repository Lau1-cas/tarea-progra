using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_1_clase_4_progra
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int horizontalAbajo = 22;
            int verticalDerecho = 77;
            int horizontalArriba = 2;
            int verticalIzquierdo = 2;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (F = verticalIzquierdo; F <= verticalDerecho; F++)
                {
                    Console.SetCursorPosition(F, horizontalAbajo); Console.Write("%*");
                    Console.SetCursorPosition(F, horizontalArriba); Console.Write("%*");
                }
                for (C = horizontalArriba; C <= horizontalAbajo; C++)
                {
                    Console.SetCursorPosition(verticalIzquierdo, C); Console.Write("*/*");
                    Console.SetCursorPosition(verticalDerecho, C); Console.Write("*/*");
                }
                horizontalArriba++;
                horizontalAbajo--;
                verticalIzquierdo++;
                verticalDerecho--;
            }//for principal
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 7; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
            Console.SetCursorPosition(25, 24);
            Console.Write("Pulse una tecla");
        }
    }
}
    

