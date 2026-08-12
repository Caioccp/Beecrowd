int opcao = 1;

while (opcao == 1) {
    
double nota1 = double.Parse(Console.ReadLine());
double nota2 = double.Parse(Console.ReadLine());

while (nota1 < 0 || nota1 > 10 ) {
    Console.WriteLine("Nota inválida");
    nota1 = double.Parse(Console.ReadLine());
}

while (nota2 < 0 || nota2 > 10) {
    Console.WriteLine("Nota inválida");
    nota2 = double.Parse(Console.ReadLine());
}

double media = (nota1 + nota2) / 2; 
Console.WriteLine($"media = {media}");

Console.WriteLine ("Novo calculo (1-sim 2-nao)");
 opcao = int.Parse(Console.ReadLine());

while (opcao != 1 && opcao != 2) {
    opcao = int.Parse (Console.ReadLine());
}
}