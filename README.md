# Projeto Numeros Inteiros

Crie um programa que solicite ao usuário a entrada de dois números inteiros, armazene esses valores em variáveis do tipo int, e depois exiba o resultado da soma desses dois números.
Dicas:
Utilize Console.WriteLine para exibir mensagens e pedir os valores.
Utilize Console.ReadLine para capturar as entradas do usuário e Convert.ToInt32 para converter essas entradas para números inteiros.
Armazene os números em variáveis int e realize a soma desses valores.
Exiba o resultado com Console.WriteLine.
==================================================================================================================================================================
using System;

namespace SomaDeDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o primeiro número
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

  // Solicita ao usuário o segundo número
            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

  // Realiza a soma dos dois números
            int soma = numero1 + numero2;

  // Exibe o resultado da soma
            Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}");
        }
    }
}
