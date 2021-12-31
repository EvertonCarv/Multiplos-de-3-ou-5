// See https://aka.ms/new-console-template for more information
Console.WriteLine("Encontre a soma de todos os múltiplos de 3 ou 5 abaixo de 1000");

double soma = 0;
double resultado;

for (double i = 0; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        soma = soma + i;
        Console.WriteLine();
    }
}
resultado = soma;
Console.WriteLine(resultado);