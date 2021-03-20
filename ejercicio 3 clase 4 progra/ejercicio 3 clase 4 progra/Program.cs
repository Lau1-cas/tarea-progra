using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_clase_4_progra
{
    class Program
    {

        public static string Generaletra(int rango1, int rango2)
        {
            Random ran = new Random();
           int NUM = Convert.ToInt32(ran.Next(100));
            string respuesta = "NO HAY";
            if (((NUM > rango1) & (NUM < rango2)))
            {

                respuesta = Convert.ToString((char)NUM);
            } return respuesta;
        }
        static void Main(string[] args)
        {
            byte CAN, K;
            string linea;
            Console.Write("Cuantos Números?");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            
            string letras = " ";
            for (K = 1; K <= CAN; K++)
            {
                letras = Generaletra(0,100);
                Console.WriteLine($"El codigo  {letras} ");
                Console.ReadKey();
            }
         

        }
  
    }
}


