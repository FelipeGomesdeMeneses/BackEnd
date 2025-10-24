int opcao;

do
{

    Console.WriteLine($"-------------------------------------------------------");
    Console.WriteLine($"                   Bem Vindo, Usuário                  ");
    Console.WriteLine($"-------------------------------------------------------");

    Console.WriteLine($"Escolha uma opção abaixo:");
    Console.WriteLine($"1) Opção 1");
    Console.WriteLine($"2) Opção 2");
    Console.WriteLine($"3) Opção 3");
    Console.WriteLine($"0) Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção 1");
            break;
        case 2:
            Console.WriteLine($"Você escolheu a opção 2");
            break;
        case 3:
            Console.WriteLine($"Você escolheu a opção 3");
            break;
        case 0:
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine($"Você escolheu uma opção inválida");
            break;
    }
} while (opcao != 0);