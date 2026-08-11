int[] valores = new int[100];
int maior = valores[0];
int posicao = 0;

for (int i = 0; i < valores.Length; i++)
{
    valores[i] = int.Parse(Console.ReadLine());
    if (valores[i] > maior)
    {
        maior = valores[i];
        posicao = i + 1;
    }
}

Console.WriteLine(maior);
Console.WriteLine(posicao);