using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_2_clase_4_progra
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int lenght)
        {
            string result = parametro.Substring(startindex, lenght);
            return result;
        }
        static void marque(string NOM)
        {
            
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;
            int CF = 0;

            Console.SetCursorPosition(1, 12);
            Console.Write(NOM);
            CI = NOM.Length;
            CF = 70;
            NOM = NOM.ToUpper();
            for (P = NOM.Length; P >= 1; P--)
            {
                CAR = Mid(NOM, P - 1, 1);
                for (K = CI; K <= CF; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + CAR);
                    Thread.Sleep(50);
                }
                CF = CF - 1;
                CI = CI - 1;
            }
        }
        static void Main(string[] args)
        {
            string NOM;
            Console.Write("Ingrese su nombre:");
            NOM = Console.ReadLine();
            marque(NOM);
            marque("Lau");
        }
    }//end class
}
    

