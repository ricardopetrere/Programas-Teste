using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace ARES_2._0
{
    class Program
    {
        public struct Cadastro
        {
            public string nome;
            public string aniversario;
            public string email;
            public string endereco;
            public string cidade;
            public string tel1;
            public string dtel1;
            public string tel2;
            public string dtel2;
            public string tel3;
            public string dtel3;
        }
        const string arquivo = @"cadastros.txt";
        static void ADICIONAR()
        {
            char repetiradicionar;
            do
            {
                string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                string[] dados = new string[11];
                for (int n = 0; n < 11; n++)
                {
                    if (n == 0)
                        Console.WriteLine("Digite o nome da pessoa");
                    else if (n == 1)
                        Console.WriteLine("Digite a data de aniversário no esquema dd/mm/aa");
                    else if (n == 2)
                        Console.WriteLine("Digite o e-mail da pessoa.");
                    else if (n == 3)
                        Console.WriteLine("Digite o endereço da pessoa.");
                    else if (n == 4)
                        Console.WriteLine("Digite a cidade onde a pessoa mora.");
                    else if (n == 5)
                        Console.WriteLine("Digite o 1º telefone da pessoa.");
                    else if (n == 6)
                        Console.WriteLine("Digite a descrição do 1º telefone da pessoa.");
                    else if (n == 7)
                        Console.WriteLine("Digite o 2º telefone da pessoa.");
                    else if (n == 8)
                        Console.WriteLine("Digite a descrição do 2º telefone da pessoa.");
                    else if (n == 9)
                        Console.WriteLine("Digite o 3º telefone da pessoa.");
                    else if (n == 10)
                        Console.WriteLine("Digite a descrição do 3º telefone da pessoa.");
                    dados[n] = Console.ReadLine().Trim();
                }
                Console.WriteLine("Tem certeza que deseja adicionar este contato?\n\nNome: {0}\tData: {1}\t E-mail: {2}\nEndereço: {3}\tCidade: {4}\nTelefone 1 ({5})\n{6}\nTelefone 2 ({7})\n{8}\nTelefone 3 ({9})\n{10}\n\n<S/N>",
                    dados[0], dados[1], dados[2], dados[3], dados[4], dados[6], dados[5], dados[8], dados[7], dados[10], dados[9]);
                char opc = Console.ReadLine().ToLower()[0];
                if (opc == 's')
                {
                    for (int n = 0; n < 11; n++)
                        if (n == 10)
                            File.AppendAllText(arquivo, dados[n] + Environment.NewLine);
                        else
                            File.AppendAllText(arquivo, dados[n] + "|");
                    Console.WriteLine("Cadastro adicionado.\n\n");
                }
                else
                    Console.WriteLine("Cadastro cancelado.\n\n");
                Console.WriteLine("Deseja adicionar outro cadastro?(S/N)");
                repetiradicionar = Console.ReadLine().ToLower()[0];
            }
            while (repetiradicionar == 's');
        }
        static void REMOVER()
        {
            char repetirapagar;
            do
            {
                string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                Console.WriteLine("Digite o nome da pessoa.");
                string nomeapagar = Console.ReadLine().Trim();
                int listados = 0;
                string[] possiveis = new string[linhas.Length];
                for (int n = 0; n < linhas.Length; n++)
                    if (linhas[n].IndexOf(nomeapagar) >= 0)
                    {
                        possiveis[listados] = linhas[n].Substring(0, linhas[n].IndexOf('|'));
                        Console.WriteLine("{0} - {1}", listados + 1, possiveis[listados]);
                        listados++;
                    }
                if (listados > 0)
                {
                    Console.WriteLine("\nQual dos contatos você deseja remover?");
                    int escolhaapagar = int.Parse(Console.ReadLine().Trim());
                    if (escolhaapagar <= listados)
                    {
                        File.Delete(arquivo);
                        for (int n = 0; n < linhas.Length; n++)
                            if (possiveis[escolhaapagar - 1] != linhas[n].Substring(0, linhas[n].IndexOf('|')))
                                File.AppendAllText(arquivo, linhas[n] + Environment.NewLine);
                        Console.WriteLine("Cadastro deletado.\n\n");
                    }
                    else
                        Console.WriteLine("O número está além dos limites.");
                }
                else
                    Console.WriteLine("Não existe cadastro com sua busca.");
                Console.WriteLine("Deseja remover outro cadastro?(S/N)");
                repetirapagar = Console.ReadLine().ToLower()[0];
            }
            while (repetirapagar == 's');
        }
        static void EDITAR()
        {
            char repetirescolha;
            do
            {
                Console.Clear();
                string[] linhas = File.ReadAllLines(arquivo, Encoding.UTF8);
                Console.WriteLine("Digite o nome da pessoa.");
                string nomeeditar = Console.ReadLine().Trim();
                
                int listados = 0;
                string[] possiveis = new string[linhas.Length];
                for (int n = 0; n < linhas.Length; n++)
                    if (linhas[n].IndexOf(nomeeditar) >= 0)
                    {
                        possiveis[listados] = linhas[n].Substring(0, linhas[n].IndexOf('|'));
                        Console.WriteLine("{0} - {1}", listados + 1, possiveis[listados]);
                        listados++;
                    }
                if (listados > 0)
                {
                    Console.WriteLine("\nQual dos contatos você deseja editar?");
                    int escolhaeditar = int.Parse(Console.ReadLine().Trim());
                    int editado = 0;
                    if (escolhaeditar <= listados)
                    {
                        for (int n = 0; n < linhas.Length; n++)
                            if (possiveis[escolhaeditar - 1] == linhas[n].Substring(0, linhas[n].IndexOf('|')))
                                editado = n;
                        string[] cadastroantigo = linhas[editado].Split('|');
                        Console.Clear();
                        Console.WriteLine("\nNome: {0}\tData: {1}\t E-mail: {2}\nEndereço: {3}\tCidade: {4}\n1º Telefone ({5})\n{6}\n2º Telefone ({7})\n{8}\n3º Telefone ({9})\n{10}",
                            cadastroantigo[0], cadastroantigo[1], cadastroantigo[2], cadastroantigo[3], cadastroantigo[4], cadastroantigo[6], cadastroantigo[5], cadastroantigo[8], cadastroantigo[7], cadastroantigo[10], cadastroantigo[9]);
                        char repetircadastro;
                        do
                        {
                            Console.WriteLine("\nO que você deseja alterar?\n1) Nome\n2) Data\n3) E-mail\n4) Endereço\n5) Cidade\n6) 1º Telefone\n7) Descrição do 1º Telefone\n8) 2º Telefone\n9) Descrição do 2º Telefone\n10) 3º Telefone\n11) Descrição do 3º Telefone");
                            int partecadastro = int.Parse(Console.ReadLine().Trim());

                            if (partecadastro == 1)
                            {
                                Console.WriteLine("Digite o novo nome.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 2)
                            {
                                Console.WriteLine("Digite a nova data de aniversário no esquema dd/mm/aa.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 3)
                            {
                                Console.WriteLine("Digite o novo E-mail.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 4)
                            {
                                Console.WriteLine("Digite o novo endereço.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 5)
                            {
                                Console.WriteLine("Digite a nova cidade.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 6)
                            {
                                Console.WriteLine("Digite o novo 1º telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 7)
                            {
                                Console.WriteLine("Digite a nova descrição do 1º Telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 8)
                            {
                                Console.WriteLine("Digite o novo 2º telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 9)
                            {
                                Console.WriteLine("Digite a nova descrição do 2º Telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 10)
                            {
                                Console.WriteLine("Digite o novo 3º telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else if (partecadastro == 11)
                            {
                                Console.WriteLine("Digite a nova descrição do 3º Telefone.");
                                cadastroantigo[partecadastro - 1] = Console.ReadLine().Trim();
                            }
                            else
                                Console.WriteLine("Número indisponível.");
                            if (partecadastro < 12)
                            {
                                linhas[editado] = "";
                                for (int n = 0; n < 11; n++)
                                    if (n == 10)
                                        linhas[editado] += cadastroantigo[n];
                                    else
                                        linhas[editado] += cadastroantigo[n] + "|";
                                File.Delete(arquivo);
                                for (int n = 0; n < linhas.Length; n++)
                                    File.AppendAllText(arquivo, linhas[n] + Environment.NewLine);
                                Console.WriteLine("\n\nCadastro editado.");
                            }
                            Console.WriteLine("\nDeseja editar mais algo deste cadastro?(S/N)");
                            repetircadastro = Console.ReadLine().ToLower()[0];
                        }
                        while (repetircadastro == 's');

                    }
                    else
                        Console.WriteLine("Número indisponível.");
                }
                else
                    Console.WriteLine("Não existe cadastro com sua busca.");
                Console.WriteLine("Deseja editar outro cadastro?(S/N)");
                repetirescolha = Console.ReadLine().ToLower()[0];
            }
            while (repetirescolha == 's');
            
        }
        static void Main(string[] args)
        {
            try
            {
                char sair;
                do
                {
                    Console.WriteLine("Deseja adicionar cadastros (A), remover (R), editar (E) ou sair (S)?");
                    sair = Console.ReadLine().ToLower()[0];
                    if (sair == 'a')
                        ADICIONAR();
                    else if (sair == 'r')
                        REMOVER();
                    else if (sair == 'e')
                        EDITAR();
                    else if (sair != 's')
                        Console.WriteLine("Opção inválida.");
                }
                while (sair != 's');
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("ERRO! O programa vai sair.");
                Thread.Sleep(1000);
            }
        }
    }
}
