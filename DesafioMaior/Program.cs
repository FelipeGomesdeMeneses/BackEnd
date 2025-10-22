float num1, num2;

Console.WriteLine("Olá digite o primeiro número");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Olá digite o segundo número");
num2 = float.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} é maior que {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1} é menor que {num2}");
}
else
{
    Console.WriteLine($"Os números são iguais");
}