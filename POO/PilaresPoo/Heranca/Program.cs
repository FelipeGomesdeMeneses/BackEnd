using Heranca;
Console.Clear();

// Veiculo Generic = new Veiculo();




// Aviao Boeing = new Aviao();
// Boeing.Marca ="Boeing";
// Boeing.Modelo ="737";
// Boeing.Passageiros =215;
// Boeing.ExibirInfo();
// Boeing.Acelerar();
// Console.WriteLine($"");



// Exercicio 1
// Gato Garfield = new Gato();
// Garfield.FazerSom();

// Cachorro Scooby = new Cachorro();
// Scooby.FazerSom();


//Exercicio 2

// Funcionario Salgado = new Funcionario();
// Salgado.Nome = "Felipe Salgado";
// Salgado.SalarioBase = 2000;
// Salgado.ExibirSalario();
// Console.WriteLine($"");


// Gerente Gomes = new Gerente();
// Gomes.Nome = "Felipe Gomes";
// Gomes.SalarioBase = 2000;
// Gomes.ExibirSalario();



//Exercicio3

// Carro Fusca = new Carro();
// Fusca.Marca ="Volks";
// Fusca.Modelo ="Fusca";
// Fusca.QtdPortas =2;
// Fusca.MostraInfo();
// Console.WriteLine($"");



// Moto Suzuki = new Moto();
// Suzuki.Marca = "Suzuki";
// Suzuki.Modelo = "Hayabusa";
// Suzuki.TipoCapacete = "Fechado";
// Suzuki.MostraInfo();
// Console.WriteLine($"");


//Exercicio 4
// Aluno Gomes = new Aluno();
// Gomes.Nome = "Felipe Gomes";
// Gomes.Idade = 17;
// Gomes.Curso = "DEV";
// Gomes.ExibirInfo();
// Console.WriteLine($"");


// Professor Edu = new Professor();
// Edu.Nome = "Eduardo Costa";
// Edu.Idade = 43;
// Edu.Disciplina = "Desenvolvimento de Sistema";
// Edu.ExibirInfo();


//Execicio 5 
int opcao;
ContaPoupanca Conta1 = new ContaPoupanca();
do
{
    Console.Clear();
    Console.WriteLine($"Sistema Bancário");
    Console.WriteLine();
    Console.WriteLine($"1) Depositar");
    Console.WriteLine($"2) Sacar");
    Console.WriteLine("3) Aplicar Rendimento (2%)");
    Console.WriteLine("4) Exibir Saldo");
    Console.WriteLine($"0) Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            Conta1.Depositar();
            break;
        case 2:
            Conta1.Sacar();
            break;
        case 3:
            Console.WriteLine($"Saldo antes do rendimento: R$ {Conta1.Saldo:F2}");
            Conta1.CalcRendimento();
            break;
        case 4:
            Console.WriteLine($"Saldo atual: R$ {Conta1.Saldo:F2}");
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);