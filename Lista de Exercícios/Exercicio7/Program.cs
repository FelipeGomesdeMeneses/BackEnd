using System.Reflection.Emit;
int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"--------------------------------");
    Console.WriteLine($"           BEM VINDO            ");
    Console.WriteLine($"              ao                ");
    Console.WriteLine($"         Jacareca Food          ");
    Console.WriteLine($"--------------------------------");
    Console.WriteLine();
    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine();
    Console.WriteLine($"1) Batata .....................R$10,00");
    Console.WriteLine($"2) Hamburguer..................R$20,00");
    Console.WriteLine($"3) Pizza.......................R$50,00");
    Console.WriteLine($"4) Sushi.......................R$35,00");
    Console.WriteLine($"5) Feijoada....................R$25,00");
    Console.WriteLine($"0) Sair");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar ...");
            Console.WriteLine();
            break;
        case 1:
            Console.WriteLine($"boa escolha, vamos prepara sua batata");
            break;
        case 2:
            Console.WriteLine($"boa escolha, vamos prepara seu hamburguer");
            break;
        case 3:
            Console.WriteLine($"boa escolha, vamos prepara sua pizza");
            break;
        case 4:
            Console.WriteLine($"boa escolha, vamos prepara seu sushi");
            break;
        case 5:
            Console.WriteLine($"boa escolha, vamos prepara sua feijoada");
            break;     
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }
   
   Console.WriteLine($"Digite <Enter> para continuar...");
   Console.ReadLine();
} while (opcao != 0);