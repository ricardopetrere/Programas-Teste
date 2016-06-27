using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AjustaLegenda
{
    class Program
    {
        static string arquivo;
        static void Main(string[] args)
        {
            /*
             * formato dos arquivos de legenda:
             * 
             * Index
             * hh:mm:ss,mmm --> hh:mm:ss,mmm
             * Texto
             * Texto (opcional)
             * (espaço em branco)
             * repete
             */
            if (args.Length == 1)
            {
                if (File.Exists(args[0]))
                    arquivo = args[0];
                else if (File.Exists(args[0].Substring(1)))
                    arquivo = args[0].Substring(1);
                else
                {
                    Console.WriteLine("Arquivo inexistente. Pressione qualquer tecla para fechar");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Arraste o arquivo desejado e pressione Enter");
                arquivo = Console.ReadLine().Trim('\"');
                if(!File.Exists(arquivo))
                {
                    Console.WriteLine("Arquivo inexistente. Pressione qualquer tecla para fechar");
                    Console.ReadLine();
                    return;
                }
            }
            string[] linhas = File.ReadAllLines(arquivo, Encoding.Default);
            Console.WriteLine("Digite a quantidade de segundos a reduzir (valores negativos são válidos)");
            float fAjuste = Convert.ToSingle(Console.ReadLine());
            int iSegundosAjuste = (int)fAjuste;
            TimeSpan tAjuste = new TimeSpan(0, 0, 0, iSegundosAjuste, (int)((fAjuste - iSegundosAjuste) * 1000));
            try
            {
                File.Delete(arquivo);
                Console.WriteLine("Processando...");
                for (int n = 0; n < linhas.Length; n++)
                {
                    //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28
                    //h  h  :  m  m  :  s  s  ,  m  m  m     -  -  >     h  h  :  m  m  :  s  s  ,  m  m  m
                    if (linhas[n].Length == 29)
                    {
                        if (linhas[n][2] == ':' && linhas[n][19] == ':')//linha indicando duração
                        {
                            DateTime dTempoPre = DateTime.ParseExact(linhas[n].Substring(0, 12), "HH:mm:ss,fff", System.Globalization.CultureInfo.CurrentCulture).Subtract(tAjuste);
                            DateTime dTempoPos = DateTime.ParseExact(linhas[n].Substring(17, 12), "HH:mm:ss,fff", System.Globalization.CultureInfo.CurrentCulture).Subtract(tAjuste);
                            linhas[n] = dTempoPre.ToString("HH:mm:ss,fff") + " --> " + dTempoPos.ToString("HH:mm:ss,fff");
                        }
                    }
                    File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.Default);
                }
                Console.WriteLine("Pronto!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro ao acessar arquivo. O arquivo deve estar aberto em outro programa.");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.ReadLine();
            }
            ////Código original:
            //
            //if (args.Length == 1)
            //{
            //    if (File.Exists(args[0]))
            //        arquivo = args[0];
            //    else if (File.Exists(args[0].Substring(1)))
            //        arquivo = args[0].Substring(1);
            //    else
            //    {
            //        Console.WriteLine("Arquivo inexistente. Pressione qualquer tecla para fechar");
            //        Console.ReadLine();
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Arraste o arquivo desejado e pressione Enter");
            //    arquivo = Console.ReadLine().Trim('\"');
            //    if (!File.Exists(arquivo))
            //    {
            //        Console.WriteLine("Arquivo inexistente. Pressione qualquer tecla para fechar");
            //        Console.ReadLine();
            //        return;
            //    }
            //}
            //string[] linhas = File.ReadAllLines(arquivo, Encoding.Default);
            //Console.WriteLine("Digite a quantidade de segundos a reduzir (valores negativos são válidos)");
            //int iAjuste = Convert.ToInt32(Console.ReadLine());
            //File.Delete(arquivo);
            //Console.WriteLine("Processando...");
            //for (int n = 0; n < linhas.Length; n++)
            //{
            //    //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28
            //    //h  h  :  m  m  :  s  s  ,  m  m  m     -  -  >     h  h  :  m  m  :  s  s  ,  m  m  m
            //    if (linhas[n].Length == 29)
            //    {
            //        if (linhas[n][2] == ':' && linhas[n][19] == ':')//linha indicando duração
            //        {
            //            int iTempoPre = Convert.ToInt32(linhas[n].Substring(6, 2));
            //            iTempoPre += (Convert.ToInt32(linhas[n].Substring(3, 2)) * 60);
            //            iTempoPre += (Convert.ToInt32(linhas[n].Substring(0, 2)) * 3600);
            //            iTempoPre -= iAjuste;

            //            int iTempoPos = Convert.ToInt32(linhas[n].Substring(23, 2));
            //            iTempoPos += (Convert.ToInt32(linhas[n].Substring(20, 2)) * 60);
            //            iTempoPos += (Convert.ToInt32(linhas[n].Substring(17, 2)) * 3600);
            //            iTempoPos -= iAjuste;

            //            string sNovaLinha = "";
            //            sNovaLinha += (iTempoPre / 3600).ToString("00");
            //            iTempoPre = iTempoPre % 3600;
            //            sNovaLinha += ":" + (iTempoPre / 60).ToString("00");
            //            iTempoPre = iTempoPre % 60;
            //            sNovaLinha += ":" + iTempoPre.ToString("00");
            //            sNovaLinha += linhas[n].Substring(8, 4);
            //            sNovaLinha += " --> ";
            //            sNovaLinha += (iTempoPos / 3600).ToString("00");
            //            iTempoPos = iTempoPos % 3600;
            //            sNovaLinha += ":" + (iTempoPos / 60).ToString("00");
            //            iTempoPos = iTempoPos % 60;
            //            sNovaLinha += ":" + iTempoPos.ToString("00");
            //            sNovaLinha += linhas[n].Substring(25);
            //            linhas[n] = sNovaLinha;
            //        }
            //    }
            //    File.AppendAllText(arquivo, linhas[n] + Environment.NewLine, Encoding.Default);
            //}
            //Console.WriteLine("Pronto!");
            //Console.ReadLine();
        }
    }
}
