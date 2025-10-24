//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo
//    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//   − Triângulo    Isóscele:    possui    2    lados    iguais.     
//   − Triângulo    Escaleno:    possui    3    lados    diferentes.

float lado1, lado2, lado3;

Console.WriteLine($"Consulta Triângulo");

Console.WriteLine($"Ola, digite o valor do primeiro lado");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor do segundo lado");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor do terceiro lado");
lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3)
{
    Console.WriteLine($"Esse triângulo é equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"Esse triângulo é isóceles");
}
else
{
    Console.WriteLine($"Esse triângulo é escaleno");
}