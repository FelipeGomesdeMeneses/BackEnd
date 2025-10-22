float num1, num2;
string operacao;

Console.WriteLine("Olá digite a operação. Opções: + , - , * , /");
operacao = Console.ReadLine();

Console.WriteLine("Digite o primeiro número");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
num2 = float.Parse(Console.ReadLine());

float resultadoSoma = num1 + num2;
float resultadoSub = num1 - num2;
float resultadoMult = num1 * num2;
float resultadoDiv = num1 / num2;

if (operacao == "+")
{
    Console.WriteLine($"Esse é o resultado da soma {resultadoSoma}");
}
else if (operacao == "-")
{
    Console.WriteLine($"Esse é o resultado da soma {resultadoSub}");
}
else if (operacao == "*")
{
    Console.WriteLine($"Esse é o resultado da soma {resultadoMult}");
}
else if (operacao == "/")
{
    Console.WriteLine($"Esse é o resultado da soma {resultadoDiv}");
}
else
{
    Console.WriteLine("Operação incorreta");
}
