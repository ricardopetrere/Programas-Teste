using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            double dfinal;
            Console.WriteLine("Digite a quantia inicial:");
            dfinal = Convert.ToDouble(Console.ReadLine());
            
            /*for (int meses = 0; dfinal <= 1000000; meses++)
            {
                dfinal = dfinal * 1.005;
                Console.WriteLine(dfinal);
            }
            */

            int meses = 0;
            do
            {
                meses++;
                dfinal = dfinal * 1.005;
                Console.WriteLine(dfinal);
            }
            while (dfinal <= 1000000);



            Console.WriteLine("parabéns, você está milionário!Foram necessários {0} meses",meses);
            Console.ReadLine();
        }
    }
}
