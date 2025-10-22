Console.WriteLine($"Quantos números você quer digitar");
int numdigit = int.Parse(Console.ReadLine());
string pares = "Pares: ";
string impares = "Impares: ";

for(int i = 1; i <= numdigit; i++)
{
    Console.WriteLine($"Digite o {i}° número");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares += numero.ToString() + ", ";
    }
    else
    {
        impares += numero.ToString() + ", ";
    }
        
}
    Console.WriteLine("Resultado");
    Console.WriteLine();
    Console.WriteLine(pares);
    Console.WriteLine(impares);
    