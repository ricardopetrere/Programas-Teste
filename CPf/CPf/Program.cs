using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que solicite um CPF e então seu programa devera informar
            //se o CPF é válido ou não, além de exibir os dígitos calculados
            int digito10=0, digito11=0;
            Console.WriteLine("Digite seu CPF:");
            string cpf = Console.ReadLine();
            cpf=cpf.Replace(".","").Trim();
            cpf = cpf.Replace("-", "");
            for (int n = 0; n < 9; n++)
            {
                digito10 = digito10 + ((10 - n) * Convert.ToInt16(cpf.Substring(n,1)));
            }
            digito10=digito10%11;
            if (digito10 == 0 || digito10 == 1)
                digito10 = 0;
            else
                digito10 = 11 - digito10;
            for (int n = 0; n < 9; n++)
                digito11 = digito11 + (11 - n) * Convert.ToInt16(cpf.Substring(n,1));
            digito11 = digito11 + digito10 * 2;
            digito11 %= 11;
            if (digito11 == 0 || digito11 == 1)
                digito11 = 0;
            else
                digito11 = 11 - digito11;
            if (digito10 != Convert.ToInt16(cpf.Substring(9, 1)) || digito11 != Convert.ToInt16(cpf.Substring(10, 1)))
                Console.WriteLine("CPF incorreto. Números finais esperados: {0} e {1}", digito10, digito11);
            else
                Console.WriteLine("Número digitado corretamente.");
            Console.ReadLine();
        }
    }
}
