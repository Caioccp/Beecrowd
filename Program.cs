using System; 

class URI {

    static void Main(string[] args) { 

        int C = int.Parse(Console.ReadLine());

        while (C < 0 || C > 11) {
            C = int.Parse(Console.ReadLine());
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
            
        for (int linha = 0; linha < 12; linha++) {
                soma = soma + matriz[linha, C];
        }
          
        if (T == 'M') {
                soma = soma / 12.0;
        }
            
        Console.WriteLine($"{soma:F1}");
    }
}
