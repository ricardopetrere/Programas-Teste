using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Substring
{
    class Program
    {
        static string texto,substring;
        static int index,length;
        static string SUBSTRING()
        {
            for (int n = 0; n < length; n++)
                substring = substring + texto[n+index].ToString();
            return substring;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto qualquer:");
            texto = Console.ReadLine();
            Console.WriteLine("Digite o índice inicial para a substring:");
            bool correto=false;
            while (!correto)
            {
                try
                {
                    index = Convert.ToInt32(Console.ReadLine());
                    correto = true;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido.");
                }
            }
            correto = false;
            while (!correto)
            {
                Console.WriteLine("Digite a length da substring:");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    correto = true;
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido.");
                }
                if (index + length > texto.Length)
                {
                    Console.WriteLine("Valor ímpossível (a substring não pode ser maior que o texto).");
                    correto = false;
                }
            }
            Console.WriteLine("Substring: " + SUBSTRING());
            Console.ReadLine();
        }
    }
}
