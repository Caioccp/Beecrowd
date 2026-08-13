using System;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] X = new int[N];

        string[] entrada = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            X[i] = int.Parse(entrada[i]);
        }

        int menor = X[0];
        int posicao = 0;

        for (int i = 1; i < N; i++)
        {
            if (X[i] < menor)
            {
                menor = X[i];
                posicao = i;
            }
        }

        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Posicao: {posicao}");
    }
}
