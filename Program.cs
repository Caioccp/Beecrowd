using System;

class URI {

    static void Main(string[] args) { 

        int L = int.Parse(Console.ReadLine());

        while (L < 0 || L > 11) {
            L = int.Parse(Console.ReadLine());
        }

        char T = char.Parse(Console.ReadLine());

        while (T != 'S' && T != 'M') {
            T = char.Parse(Console.ReadLine());
        }

        double[,] matriz = new double[12, 12];

        for (int linha = 0; linha < 12; linha++) {
            for (int coluna = 0; coluna < 12; coluna++) {
                matriz[linha, coluna] = double.Parse(Console.ReadLine());
            }
        }
            
        double soma = 0;
            
        for (int coluna = 0; coluna < 12; coluna++) {
                soma = soma + matriz[L, coluna];
        }
          
        if (T == 'M') {
                soma = soma / 12.0;
        }
            
        Console.WriteLine($"{soma:F1}");
    }
}