using System.IO;

namespace AbreLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;
            string[] links = File.ReadAllLines(args[0]);
            Ricardo.AbreLinks.AbreLinks.a(links, false);
        }
    }
}
