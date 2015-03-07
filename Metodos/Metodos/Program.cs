using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metodos
{
    class Program
    {
        static bool Positivo(double numero)//Positivo dá valor booleano, lendo variável numero (double)
        {//obrigado colocar chaves "{}"
            if (numero < 0)
                return false;//pelo método ser bool, é obrigado por return
            else
                return true;
        }
        static void ExibeTextoVermelho(string texto)
        {
            ConsoleColor cor = Console.ForegroundColor; // guarda a cor agual na variável cor
            Console.ForegroundColor = ConsoleColor.Red; // altera a cor atual para vermelho
            Console.WriteLine(texto); // escreve o texto em vermelho
            Console.ForegroundColor = cor; // restaura a cor que estava antes de executar o método.
        }
        static void limpaTela()
        {
            Console.Clear();
            Console.WriteLine("Tela limpinha!!!!");
        }
        static void teste(int variavel)
        {
            variavel = variavel * 2;
        }
        static void Main(string[] args)//pelo método ser void("vazio"), não retorna nada (return desnecessário)
        {
            if (Positivo(7))
                Console.WriteLine("O número 7 é um número positivo.");
            else
                Console.WriteLine("O número 7 não é um número positivo.");
            Console.ReadLine();

            ExibeTextoVermelho("Este texto está sendo exibido em vermelho");
            Console.WriteLine("Pressione enter para terminar.");
            Console.ReadLine();

            ExibeTextoVermelho("xxxxxxxxxxxxxxxxx");
            Console.WriteLine("yyyyyyyyyyyyyyyyyy");
            Console.WriteLine("Pressione enter para limpar a tela!");
            Console.ReadLine();
            limpaTela();
            Console.ReadLine();

            int numero = 8;
            teste(numero);
            Console.WriteLine(numero);
            Console.ReadLine();
        }
    }
}
