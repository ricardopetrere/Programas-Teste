using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace randomico
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int ngerado = gerador.Next(100);
            Console.WriteLine("Número gerado: {0}", ngerado);
            Console.WriteLine("Número gerado: {0}", gerador.Next(1000));
            Console.ReadLine();
        }
    }
}
