//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze.
//Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

float macacomprada, valortotal;

Console.WriteLine($"Consulta preço das maçãs");

Console.WriteLine($"Olá, quantas maçãs você comprou?");
macacomprada = float.Parse(Console.ReadLine());

if(macacomprada >= 12)
{
    valortotal = macacomprada * 0.25f;
    Console.WriteLine($"Valor total da compra: {valortotal} ");
    
}
else
{
    valortotal = macacomprada * 0.30f;
    Console.WriteLine($"Valor total da compra: {valortotal}");
}
