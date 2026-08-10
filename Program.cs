string[] entradas = Console.ReadLine().Split(' ');

int codigo = int.Parse(entradas[0]);
int qtde = int.Parse(entradas[1]);
double total = 0;

if (codigo == 1)
{
    total = qtde * 4;
}
else if (codigo == 2)
{
    total = qtde * 4.50;
}
else if (codigo == 3)
{
    total = qtde * 5;
}
else if (codigo == 4)
{
    total = qtde * 2;
}
else if (codigo == 5)
{
    total = qtde * 1.50;
}

Console.WriteLine($"Total: R$ {total:F2}");
