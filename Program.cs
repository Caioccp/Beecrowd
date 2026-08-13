int[] X = new int[10];

for (int i = 0; i < X.Length; i++) {
    X[i] = int.Parse(Console.ReadLine());
}

if (X[0] <= 0) {
    X[0] = 1;
}  

if (X[1] <= 0) {
    X[1] = 1;
}

if (X[2] <= 0) {
    X[2] = 1;
} 

if (X[3] <= 0) {
    X[3] = 1;
} 

if (X[4] <= 0) {
    X[4] = 1;
}  

if (X[5] <= 0) {
    X[5] = 1;
} 

if (X[6] <= 0) {
    X[6] = 1;
}

if (X[7] <= 0) {
    X[7] = 1;
}  

if (X[8] <= 0) {
    X[8] = 1;
}  

if (X[9] <= 0) {
    X[9] = 1;
} 

Console.WriteLine ($"X[0] = {X[0]}");
Console.WriteLine ($"X[1] = {X[1]}");
Console.WriteLine ($"X[2] = {X[2]}");
Console.WriteLine ($"X[3] = {X[3]}");
Console.WriteLine ($"X[4] = {X[4]}");
Console.WriteLine ($"X[5] = {X[5]}");
Console.WriteLine ($"X[6] = {X[6]}");
Console.WriteLine ($"X[7] = {X[7]}");
Console.WriteLine ($"X[8] = {X[8]}");
Console.WriteLine ($"X[9] = {X[9]}");
