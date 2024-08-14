// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Olá, mundo!");
/*
1. Tipos de variáveis var, int, short, long, decimal, double, bool e string;*/

int a = 10;
int b = 5;

/*
2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários;*/

int r = a + b;

//Console.WriteLine("Resultado " + r);

Console.WriteLine("Digite a 1a nota: ");
var nota1 = Console.ReadLine();
Console.WriteLine("Digite a 2a nota: ");
var nota2 = Console.ReadLine();

Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");

double media = ((Convert.ToDouble(nota1)) + (Convert.ToDouble(nota2)))/2;

if (media >= 6)
{
    Console.WriteLine($"Média: {media}");
    Console.WriteLine("Aprovado.");
} 

/*
3. Estruturas de decisão if/else, ternárias e switch;
4. Estruturas de repetição while, do/while, for, foreach;
5. Arrays.
**/

