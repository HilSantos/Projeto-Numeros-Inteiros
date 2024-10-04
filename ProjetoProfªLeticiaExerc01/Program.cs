using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProfªLeticiaExerc01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int soma, Num1, Num2;

            Console.WriteLine("Digite o Num1: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Num2: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("soma: ");
            soma = Convert.ToInt32(Console.ReadLine());

            soma = Num1 + Num2;

            Console.WriteLine("A soma de " + Num1 + "+" + Num2 + "=" + soma);

Console.ReadKey();
        }
    }
}
