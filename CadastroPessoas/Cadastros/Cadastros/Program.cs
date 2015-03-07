using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Cadastros
{
    class Program
    {
        public struct Cadastro
        {
            public string nome;
            public string tel1, tel2, tel3;
            public string dtel1, dtel2, dtel3;
            public string aniversario;
            public string email;
            public string endereco;
            public string cidade;
        }
        const string arquivo = @"cadastros.txt";
        static string[] pessoas = File.ReadAllLines(arquivo, Encoding.UTF8);
        static void atribuir(ref Cadastro cadastronovo,int linha)
        {
            string[] temporario = pessoas[linha].Split('|');
            cadastronovo.nome = temporario[0];
            cadastronovo.aniversario = temporario[1];
            cadastronovo.email = temporario[2];
            cadastronovo.endereco = temporario[3];
            cadastronovo.cidade = temporario[4];
            cadastronovo.tel1 = temporario[5];
            cadastronovo.dtel1 = temporario[6];
            cadastronovo.tel2 = temporario[7];
            cadastronovo.dtel2 = temporario[8];
            cadastronovo.tel3 = temporario[9];
            cadastronovo.dtel3 = temporario[10];
        }
        static void Main(string[] args)
        {
            try
            {
                char sair;
                Console.WriteLine("Bem vindo.\n");
                do
                {
                    Console.Clear();
                    Console.WriteLine("Deseja pesquisar por nome (1) ou por telefone (2)?");
                    char nometelefone = Console.ReadLine()[0];
                    if (nometelefone == '1')
                    {
                        Console.WriteLine("Digite o nome da pessoa que você deseja procurar:");
                        string pesquisa = Console.ReadLine().Trim();
                        Cadastro[] pesquisados = new Cadastro[pessoas.Length];
                        Console.Clear();
                        int escolha = 0;
                        if (pesquisa.Length == 0)
                        {
                            for (int n = 0; n < pessoas.Length; n++)
                            {
                                atribuir(ref pesquisados[n], n);
                                Console.WriteLine("{0} - {1}", n + 1, pesquisados[n].nome);
                            }
                            Console.WriteLine("Escolha um dos contatos:");
                            escolha = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("Contato: {0}\tAniversário: {1}\nEndereço: {2}\tCidade: {3}\nEmail: {4}\n Telefone 1 ({5})\tTelefone 2 ({6})Telefone 3({7})\n{8}\t{9}\t{10}\n\n"
                            , pesquisados[escolha].nome, pesquisados[escolha].aniversario, pesquisados[escolha].endereco, pesquisados[escolha].cidade, pesquisados[escolha].email,
                            pesquisados[escolha].dtel1, pesquisados[escolha].dtel2, pesquisados[escolha].dtel3, pesquisados[escolha].tel1, pesquisados[escolha].tel2, pesquisados[escolha].tel3);
                        }
                        else
                        {
                            int pesquisada = 0;
                            string[] nomes = new string[pessoas.Length];
                            for (int n = 0; n < pessoas.Length; n++)
                                nomes[n] = pessoas[n].Substring(0, pessoas[n].IndexOf('|'));
                            for (int n = 0; n < pessoas.Length; n++)
                                if (nomes[n].ToLower().IndexOf(pesquisa.ToLower()) >= 0)
                                {
                                    atribuir(ref pesquisados[pesquisada], n);
                                    Console.WriteLine("{0} - {1}\n", pesquisada + 1, pesquisados[pesquisada].nome);
                                    pesquisada++;
                                }
                            if (pesquisada == 0)
                                Console.WriteLine("\nNão há ninguém cadastrado com esse nome.\n\n");
                            else
                            {
                                Console.WriteLine("Escolha um dos contatos:");
                                escolha = int.Parse(Console.ReadLine()) - 1;
                                Console.Clear();
                                Console.WriteLine("\nContato: {0}\tAniversário: {1}\nEndereço: {2}\tCidade: {3}\nEmail: {4}\nTelefone 1 ({5})\tTelefone 2 ({6})Telefone 3({7})\n{8}\t{9}\t{10}\n\n"
                                    , pesquisados[escolha].nome, pesquisados[escolha].aniversario, pesquisados[escolha].endereco, pesquisados[escolha].cidade, pesquisados[escolha].email,
                                    pesquisados[escolha].dtel1, pesquisados[escolha].dtel2, pesquisados[escolha].dtel3, pesquisados[escolha].tel1, pesquisados[escolha].tel2, pesquisados[escolha].tel3);
                            }
                        }
                    }
                    else if (nometelefone == '2')
                    {
                        Cadastro[] telefonecontatos = new Cadastro[pessoas.Length];
                        Cadastro[] telefonepesquisados = new Cadastro[pessoas.Length];
                        for (int n = 0; n < pessoas.Length; n++)
                            atribuir(ref telefonecontatos[n], n);
                        Console.WriteLine("Digite o número de telefone que deseja pesquisar (sem traços):");
                        string telefonepesquisa = Console.ReadLine().Trim();
                        Console.Clear();
                        if (telefonepesquisa.IndexOf('-') >= 0)
                            telefonepesquisa = telefonepesquisa.Replace("-", "");
                        int telefoneencontrados = 0;
                        int escolhatelefone = 0;
                        for (int n = 0; n < pessoas.Length; n++)
                            if ((telefonecontatos[n].tel1.IndexOf(telefonepesquisa) >= 0) || (telefonecontatos[n].tel2.IndexOf(telefonepesquisa) >= 0) || (telefonecontatos[n].tel3.IndexOf(telefonepesquisa) >= 0))
                            {
                                atribuir(ref telefonepesquisados[telefoneencontrados], n);
                                telefoneencontrados++;
                                Console.WriteLine("{0} - {1}\n{2}\t{3}\t{4}\n\n", telefoneencontrados, telefonecontatos[n].nome, telefonecontatos[n].tel1, telefonecontatos[n].tel2, telefonecontatos[n].tel3);
                            }
                        if (telefoneencontrados == 0)
                            Console.WriteLine("\nNão há ninguém cadastrado com esse número\n\n");
                        else
                        {
                            Console.WriteLine("Escolha um dos contatos:");
                            escolhatelefone = int.Parse(Console.ReadLine()) - 1;
                            Console.Clear();
                            Console.WriteLine("\nContato: {0}\tAniversário: {1}\nEndereço: {2}\tCidade: {3}\nEmail: {4}\nTelefone 1 ({5})\tTelefone 2 ({6})Telefone 3({7})\n{8}\t{9}\t{10}\n\n"
                                , telefonepesquisados[escolhatelefone].nome, telefonepesquisados[escolhatelefone].aniversario, telefonepesquisados[escolhatelefone].endereco,
                                telefonepesquisados[escolhatelefone].cidade, telefonepesquisados[escolhatelefone].email, telefonepesquisados[escolhatelefone].dtel1, telefonepesquisados[escolhatelefone].dtel2,
                                telefonepesquisados[escolhatelefone].dtel3, telefonepesquisados[escolhatelefone].tel1, telefonepesquisados[escolhatelefone].tel2, telefonepesquisados[escolhatelefone].tel3);
                        }
                    }
                    else
                        Console.WriteLine("Número indisponível.");
                    Console.WriteLine("Deseja sair?<S/N>");
                    do
                    {
                        sair = Console.ReadLine().ToLower()[0];
                        if (sair != 'n' && sair != 's')
                            Console.WriteLine("Digite uma opção válida.\n");
                    }
                    while (sair != 'n' && sair != 's');
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
