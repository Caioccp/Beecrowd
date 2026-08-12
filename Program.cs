int I = int.Parse(Console.ReadLine());
char a = 'a';
string total = "";

while (I < 1 || I > 10000)
{
    I = int.Parse(Console.ReadLine());
}

total = new string('a', I);

Console.WriteLine($"Feliz nat{total}l!");

