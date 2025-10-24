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
            opcao0();
            break;
        case 1:
            opcao1();
            break;
        case 2:
            opcao2();
            break;
        case 3:
            opcao3();
            break;
        case 4:
            opcao4();
            break;
        case 5:
            opcao5();
            break;
        default:
            opcaoinvalida();
            break;
    }
       Console.WriteLine($"Digite <Enter> para continuar...");
       Console.ReadLine();
} while (opcao != 0);

        void opcao0()
        {
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar ...");
            Console.WriteLine();        }

        void opcao1()
        {
            Console.WriteLine($"boa escolha, vamos prepara sua batata");
        }

        void opcao2()
        {
            Console.WriteLine($"boa escolha, vamos prepara seu hamburguer");
        }

        void opcao3()
        {
            Console.WriteLine($"boa escolha, vamos prepara sua pizza");
        }
        void opcao4()
        {
            Console.WriteLine($"boa escolha, vamos prepara seu sushi");
        }
        void opcao5()
        {
            Console.WriteLine($"boa escolha, vamos prepara sua feijoada");
        }
        void opcaoinvalida()
        {
            Console.WriteLine($"Opção Inválida");
        }
