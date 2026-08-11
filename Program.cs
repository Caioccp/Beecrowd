int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());
int E = int.Parse(Console.ReadLine());
int total = 0;

if (A % 2 == 0) {
    total++;
}
if (B % 2 == 0) {
    total++;
}
if (C % 2 == 0) {
    total++;
}
if (D % 2 == 0) {
    total++;
}
if (E % 2 == 0) {
    total++;
}
Console.WriteLine($"{total} valores pares");