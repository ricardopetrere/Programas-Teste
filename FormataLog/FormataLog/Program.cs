using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FormataLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = String.Empty;
            if (args.Length == 1)
            {
                if(File.Exists(args[0]))
                    arquivo = args[0];
            }
            else
            {
                Console.WriteLine("Arraste o arquivo, depois dê Enter.");
                arquivo = Console.ReadLine().Trim('\"');
            }
            if (arquivo == "")
                return;
            string dadosArquivo = File.ReadAllText(arquivo);
            dadosArquivo = dadosArquivo.Replace(Environment.NewLine, "");
            string[] linhas = dadosArquivo.Replace("\n[", "\r\n[").Split(new char[] { '\r', '\n' });
            File.Delete("resultado.txt");
            Console.Write("Gravando...");
            for (int n = 0; n < linhas.Length; n++)
            {
                string linha = linhas[n];
                if (linha.IndexOf('[') == 0 && linha.IndexOf('/') == 3)
                    File.AppendAllText("resultado.txt", (n != 0 ? Environment.NewLine : "") + linha);
                else
                    File.AppendAllText("resultado.txt", linha);
            }
        }
    }
}
