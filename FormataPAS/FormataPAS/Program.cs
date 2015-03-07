using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FormataPAS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;
            if(!File.Exists(args[0]))
                return;
            string[] dados = File.ReadAllText(args[0]).Split('\n');
            for (int n = 0; n < dados.Length; n++)
                if (n == 0)
                    File.WriteAllText("resultado.txt", dados[n]);
                else if(dados[n]!="")
                    File.AppendAllText("resultado.txt", Environment.NewLine + dados[n]);
        }
    }
}
