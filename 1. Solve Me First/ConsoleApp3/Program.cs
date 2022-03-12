using System;
class Solution
{
    static int solveMeFirst(int a, int b)
    {
        // Dica: Digite return a+b abaixo  
        return a + b;
    }

    static void Main(String[] args)
    {
        Console.Write("Digite o primeiro valor: "); //Linha descartada no desafio
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: "); //Linha descartada no desafio
        int valor2 = Convert.ToInt32(Console.ReadLine());

        int soma = solveMeFirst(valor1, valor2);
        Console.WriteLine("A soma é " + soma);
    }
}
