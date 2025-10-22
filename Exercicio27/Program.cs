Console.WriteLine("Digite a quantidade de números que você quer digitar");
int quantnum = int.Parse(Console.ReadLine());

int contador = 0;

while (contador < quantnum)
{
    Console.WriteLine($"Digite o {contador + 1} º número");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número digitado é par");
    }
    contador++;
}
