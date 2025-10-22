string cargo;
float salario;

Console.WriteLine("Olá, digite o cargo do funcionário");
cargo = Console.ReadLine();

Console.WriteLine("Digite o Salário");
salario = float.Parse(Console.ReadLine());

float salarioProducao = (salario * 0.065f) + salario;

float salarioadministração = (salario * 0.075f) + salario;

float salariodiretoria = (salario * 0.12f) + salario;

if (cargo == "Produção" || cargo == "produção")
{
    Console.WriteLine($"Salário Reajustado {salarioProducao}");
}

else if (cargo == "Administração" || cargo == "administração")
{
    Console.WriteLine($"Salário Reajustado {salarioadministração}");
}

else if (cargo == "Diretoria" || cargo == "diretoria")
{
    Console.WriteLine($"Salário Reajustado {salariodiretoria}");
}
else
{
    Console.WriteLine("As informações inseridas estão erradas");
}

