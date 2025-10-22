Console.WriteLine("Digite o número de repetições desejadas");
int repeticoes = int.Parse(Console.ReadLine());

int contador = 0;

while (contador < repeticoes)
{
    Console.WriteLine("Digite o primeiro número");
    
    float num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número");
    float num2 = float.Parse(Console.ReadLine());

    if(num1 > num2)
    {
        Console.WriteLine("O primeiro numero é maior");
    }
    else if(num2 > num1)
    {
        Console.WriteLine("O segundo numero é maior");
    }
    else
    {
        Console.WriteLine("Os números são iguais");
    }
    contador++;
}
