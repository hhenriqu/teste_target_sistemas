// 5) Escreva um programa que inverta os caracteres de um string.

// IMPORTANTE:

// a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

// b) Evite usar funções prontas, como, por exemplo, reverse;

Console.WriteLine("escreva uma linha");
string? str = Console.ReadLine();
int str_lenght = str.Length;

for (int i = str_lenght; i > 0; i--)
{
  Console.Write(str[i - 1]);
}

