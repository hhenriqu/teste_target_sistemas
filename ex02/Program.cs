
// 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Console.WriteLine("Digite um numero para descobrir se faz parte da sequencia de Fibonacci:");
int number = int.Parse(Console.ReadLine());

int i = 0, j = 1;
while(i < number && j < number)
{
 i += j;
 j += i;
}

if(i == number || j == number)
Console.WriteLine($"o numero {number} faz parte da sequencia de Fibonacci");
else
Console.WriteLine($"o numero {number} não faz parte da sequencia de Fibonacci");
