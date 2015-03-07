using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !Directory.Exists(args[0]))
                return;
            string[] filenames=Directory.GetFiles(args[0], "RTS - *.*", SearchOption.AllDirectories);
            foreach (string filename in filenames)
                File.Move(filename, filename.Replace("RTS - ", "RTS_MWS_"));
        }
    }
}
