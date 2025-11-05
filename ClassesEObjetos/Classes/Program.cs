using Classes;
// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Azul Goiaba";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.WriteLine($"Abrindo a garrafa Stanley");
// Stanley.Abrir();

// Console.WriteLine($"Bebendo água da garrafa Stanley");
// Stanley.Beber();


//Conta Bancária
int opcao;
ContaBancaria Conta1 = new ContaBancaria();
do
{
    Console.Clear();
    Console.WriteLine($"Sistema Bancário");
    Console.WriteLine();
    Console.WriteLine($"1) Depositar");
    Console.WriteLine($"2) Sacar");
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
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


