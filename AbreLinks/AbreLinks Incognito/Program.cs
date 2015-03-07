using System.Diagnostics;
using System.IO;

namespace AbreLinks_Incognito
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;
            string[] links = File.ReadAllLines(args[0]);
            try
            {
                foreach (string link in links)
                    Process.Start(new ProcessStartInfo { Arguments = "-incognito " + link, FileName = "chrome.exe" });
            }
            catch
            {
                foreach (string link in links)
                    Process.Start(new ProcessStartInfo { Arguments = "-private " + link, FileName = "iexplore.exe" });
            }
        }
    }
}
