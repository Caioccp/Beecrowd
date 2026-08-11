int totalfora = 0;
int totaldentro = 0;
int N = int.Parse(Console.ReadLine());

int[] X = new int[N];

for (int i = 0; i < N; i++)
{
    X[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < N; i++)
{
    if (X[i] > 10 && X[i] < 20)
    {
        totaldentro++;
    }
    else
    {
        totalfora++;
    }
}

Console.WriteLine($"{totaldentro} in");
Console.WriteLine($"{totalfora} out");