using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //http://stackoverflow.com/questions/12372110/command-prompt-c-sharp
            Console.WriteLine("Digite o comando a ser executado:");
            string CmdTxt = Console.ReadLine().Replace(" -", " /");
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c "+CmdTxt);
            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;

            // Here is where you grab the output:
            processStartInfo.RedirectStandardOutput = true;

            Process process = new Process
            {
                StartInfo = processStartInfo
            };
            process.Start();
            
            // Now use streams to capture the output
            StreamReader outputReader = process.StandardOutput;
            
            process.WaitForExit();
            Console.Write(process.StandardOutput.ReadToEnd());
            Console.Read();
        }
    }
}
