//Faça um programa que o usuário informe o salário recebido e o total gasto.
//Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse
//o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

float salario, totalgasto;

Console.WriteLine($"Consulta salário");

Console.WriteLine($"Olá, qual é o seu salário recebido?");
salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual é o total gasto?");
totalgasto = float.Parse(Console.ReadLine());

if(salario > totalgasto)
{
    Console.WriteLine($"Gastos dentro do orçamento.");
}
else if (totalgasto > salario)
{
    Console.WriteLine($"Orçamento estourado");
}
else
{
    Console.WriteLine($"Salário igual o total gasto");
}