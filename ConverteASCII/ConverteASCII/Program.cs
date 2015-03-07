using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConverteASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                args = new string[] { "cfgbd.ini" };
            if (File.Exists(args[0]))
            {
                string arquivo = "";
                arquivo = File.ReadAllText(args[0]);
                arquivo = arquivo.Substring(arquivo.IndexOf("Senha=") + 6);
                arquivo = arquivo.Substring(0, arquivo.IndexOf("DiretorioArqMDF=") - 2);
                if (arquivo.Length % 3 != 0)
                {
                    Console.WriteLine("Campo senha faltando ou sobrando dígitos");
                    Console.ReadLine();
                    return;
                }
                char[] caracteres = new char[arquivo.Length / 3];
                string retorno = "";
                for (int n = 0; n < caracteres.Length; n++)
                {
                    caracteres[n] = (char)Convert.ToInt32(arquivo.Substring(3 * n, 3));
                    retorno += caracteres[n].ToString();
                }
                Console.WriteLine("Senha traduzida: " + retorno);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não foi executado um arquivo cfgbd.ini em conjunto com esse programa ou não existe um arquivo cfgbd.ini na mesma pasta desse executável.");
                Console.ReadLine();
            }
        }
    }
}
