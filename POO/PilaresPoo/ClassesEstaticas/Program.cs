using ClassesEstaticas;
Console.Clear();


Console.WriteLine($"Digite o primeiro número para realizar cálculos matématicos");
float X = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número ");
float Y = float.Parse(Console.ReadLine());

// Console.WriteLine($"Soma de {X} e {Y} = {CalculosMatematicos.Somar(X,Y)}");

// Console.WriteLine($"Subtração de {X} e {Y} = {CalculosMatematicos.Subtrair(X,Y)}");

// Console.WriteLine($"Multiplicacao de {X} e {Y} = {CalculosMatematicos.Multiplicacao(X,Y)}");

// Console.WriteLine($"Divisao de {X} e {Y} = {CalculosMatematicos.Divisao(X,Y)}");

float menor = Math.Min(X, Y);
float maior = Math.Max(X, Y);

if(menor == maior)
{
    Console.WriteLine($"Eles são iguais");
    return;
    
}
Console.WriteLine($"O maior número é {maior}");
Console.WriteLine($"O menor número é {menor}");

