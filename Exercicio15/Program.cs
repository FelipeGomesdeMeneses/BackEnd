//  faça um programa que receba 4 notas de um aluno, calcule e imprima 
//  a media aritmietica das notas e a mensagem de parovado para media superior
//  ou igual a >= 7 recuperacao para notas entre 5.0 e 7.0 ou a mensagem de preorvado para media inferior a 5

float nota1, nota2, nota3, nota4;

Console.WriteLine("Olá, digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Olá, digite a segunda nota");
nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Olá, digite a terceira nota");
nota3 = float.Parse(Console.ReadLine());

Console.WriteLine("Olá, digite a quarta nota");
nota4 = float.Parse(Console.ReadLine());

float notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

if (notaFinal >= 7)
{
    Console.WriteLine("APROVADO");
}
else if(notaFinal>= 5)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}
