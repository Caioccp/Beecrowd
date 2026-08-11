int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);
int D = int.Parse(Console.ReadLine()!);
int E = int.Parse(Console.ReadLine()!);
int totalpares = 0;
int totalimpares = 0;
int totalpositivos = 0;
int totalnegativos = 0;

if (A % 2 == 0) {
    totalpares++;
} else if (A % 2 != 0) {
    totalimpares++;
}

if (B % 2 == 0) {
    totalpares++;
} else if (B % 2 != 0) {
    totalimpares++;
}

if (C % 2 == 0) {
    totalpares++;
} else if (C % 2 != 0) {
    totalimpares++;
}

if (D % 2 == 0) {
    totalpares++;
} else if (D % 2 != 0) {
    totalimpares++;
}

if (E % 2 == 0) {
    totalpares++;
} else if (E % 2 != 0) {
    totalimpares++;
}

if (A > 0) {
    totalpositivos++;
} else if (A < 0) {
    totalnegativos++;
}

if (B > 0) {
    totalpositivos++;
} else if (B < 0) {
    totalnegativos++;
}

if (C > 0) {
    totalpositivos++;
} else if (C < 0) {
    totalnegativos++;
}

if (D > 0) {
    totalpositivos++;
} else if (D < 0) {
    totalnegativos++;
}

if (E > 0) {
    totalpositivos++;
} else if (E < 0) {
    totalnegativos++;
}   


Console.WriteLine($"{totalpares} valores pares");
Console.WriteLine($"{totalimpares} valores impares");
Console.WriteLine($"{totalpositivos} valores positivos");
Console.WriteLine($"{totalnegativos} valores negativos");