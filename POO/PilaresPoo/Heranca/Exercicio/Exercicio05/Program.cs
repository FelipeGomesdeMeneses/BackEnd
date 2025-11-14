using Exercicio05;


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