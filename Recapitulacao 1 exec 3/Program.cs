/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

int a, b, c, d, diferenca;

Console.WriteLine("Informe o valor de A:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de A:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de A:");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de A:");
d = int.Parse(Console.ReadLine());

diferenca = a * b - c * d;

Console.WriteLine("Difenreça = " + diferenca);