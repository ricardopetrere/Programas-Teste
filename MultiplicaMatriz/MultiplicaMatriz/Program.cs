using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa q multiplica QUAISQUER matrizes
            Random sorteio = new Random();
            Console.WriteLine("Matrizes teste:");
            Console.WriteLine("2 3\n1 0\n4 5\n e \n");
            Console.WriteLine("3 1\n2 4\n\n\n");
            Console.WriteLine("Resultado:\n12 14\n3  1\n22 24\n\n");
            int linha1, coluna1, linha2, coluna2;
            do
            {
                Console.WriteLine("Digite a qtde de linhas da primeira matriz:");
                linha1=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite a qtde de colunas da primeira matriz:");
                coluna1=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite a qtde de linhas da segunda matriz:");
                linha2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite a qtde de colunas da segunda matriz:");
                coluna2 = Convert.ToInt16(Console.ReadLine());
                if (coluna1 != linha2)
                    Console.WriteLine("ERRO! Impossível realizar multiplicação. Tente novamente.\n\n\n");
            }
            while (coluna1!=linha2);
            int[,] matriz1 = new int[linha1, coluna1];
            int[,] matriz2 = new int[linha2, coluna2];
            Console.WriteLine("\n\nMatriz 1:");
            for(int n=0;n<linha1;n++)
                for (int a = 0; a < coluna1; a++)
                {
                    //Console.Write("Linha {0}, coluna {1}:", n+1,a+1);
                    matriz1[n, a] = sorteio.Next(11);
                    //matriz1[n,a] = Convert.ToInt16(Console.ReadLine());
                }
            Console.WriteLine("\nMatriz 2:");
            for (int n = 0; n < linha2; n++)
                for (int a = 0; a < coluna2; a++)
                {
                    //Console.Write("Linha {0}, coluna {1}:", n + 1, a + 1);
                    matriz2[n, a] = sorteio.Next(11);
                    //matriz2[n, a] = Convert.ToInt16(Console.ReadLine());
                }
            int[,] matriz3 = new int[linha1, coluna2];
            for(int n=0;n<linha1;n++)
                for (int a = 0; a < coluna2; a++) 
                {
                    for (int b = 0; b < coluna1; b++)
                        matriz3[n, a] += matriz1[n, b] * matriz2[b, a];
                }
            Console.WriteLine("\n\n");
            for (int linha = 0; linha < linha1; linha++)
            {
                for (int coluna = 0; coluna < coluna2; coluna++)
                {
                    Console.Write("{0} ", matriz3[linha, coluna]);
                }
                Console.WriteLine();
            }

            /*
            matriz3[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0])+(matriz1[0,2]*matriz2[2,0]);
            matriz3[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]);
            matriz3[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]);
            matriz3[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]);
            matriz3[2, 0] = (matriz1[2, 0] * matriz2[0, 0]) + (matriz1[2, 1] * matriz2[1, 0]);
            matriz3[2, 1] = (matriz1[2, 0] * matriz2[0, 1]) + (matriz1[2, 1] * matriz2[1, 1]);
            */
            /*
            for (int n = 0; n < 3; n++)
            {
                for (int a = 0; a < 2; a++)
                {
                    matriz3[n, a] = (matriz1[n, 0] * matriz2[0, a]) + (matriz1[n, 1] * matriz2[1, a]);
                }
            }
            Console.WriteLine();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("{0} ", matriz3[linha, coluna]);
                }
                Console.WriteLine();
            }
            */
            Console.ReadLine();
        }
    }
}
