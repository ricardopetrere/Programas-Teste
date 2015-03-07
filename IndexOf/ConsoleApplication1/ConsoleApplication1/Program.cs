using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int INDEX(char caractere, string texto)
        {
            int index = -1;
            for (int n = texto.Length - 1; n >= 0; n--)
                if (texto[n] == caractere)
                    index = n;
            return index;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto.");
            string texto = Console.ReadLine();
            Console.WriteLine("Digite um caractere para busca");
            char car = Console.ReadLine()[0];
            if (INDEX(car, texto) == -1)
                Console.WriteLine("Lamento, mas o caractere não existe no texto.");
            else
                Console.WriteLine("O caractere se encontra na {0}ª posição do texto.", INDEX(car, texto) + 1);
            Console.ReadLine();
        }
    }
}
