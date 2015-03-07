using System.Diagnostics;

namespace Ricardo.AbreLinks
{
    public class AbreLinks
    {
        public static void a(string[] links, bool IsPrivate)
        {
            try
            {
                foreach (string link in links)
                    if (IsPrivate)
                        Process.Start(new ProcessStartInfo { Arguments = "-incognito " + link, FileName = "chrome.exe" });
                    else
                        Process.Start(new ProcessStartInfo { Arguments = link, FileName = "chrome.exe" });
            }
            catch
            {
                foreach (string link in links)
                    if (IsPrivate)
                        Process.Start(new ProcessStartInfo { Arguments = "-private " + link, FileName = "iexplore.exe" });
                    else
                        Process.Start(new ProcessStartInfo { Arguments = link, FileName = "iexplore.exe" });
            }
        }
    }
}