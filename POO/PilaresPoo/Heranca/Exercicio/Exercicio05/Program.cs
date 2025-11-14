using Exercicio05;

int opcao = -1;
Conta contaEscolhida = null;

do
{
    Console.Clear();
    Console.WriteLine($"Sistema Bancário");
    Console.WriteLine();
    Console.WriteLine($"Escolha o tipo de conta:");
    Console.WriteLine($"1) Conta Poupança");
    Console.WriteLine($"2) Conta Normal");
    Console.WriteLine($"0) Sair");
    
    int escolhaConta = int.Parse(Console.ReadLine());

    switch (escolhaConta)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            contaEscolhida = new ContaPoupanca();  
            Console.WriteLine($"Conta Poupança selecionada.");
            break;
        case 2:
            contaEscolhida = new Conta();  
            Console.WriteLine($"Conta Normal selecionada.");
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            continue;  
    }

    if (contaEscolhida == null) continue;  

    do
    {
        Console.Clear();
        Console.WriteLine($"Sistema Bancário");
        Console.WriteLine();
        Console.WriteLine($"1) Depositar");
        Console.WriteLine($"2) Sacar");
        if (contaEscolhida is ContaPoupanca)
        {
            Console.WriteLine($"3) Aplicar Rendimento (2%)");
        }
        Console.WriteLine($"4) Exibir Saldo");
        Console.WriteLine($"0) Sair");
        
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 0:
                Console.WriteLine($"Encerrando o programa...");
                break;
            case 1:
                contaEscolhida.Depositar();
                break;
            case 2:
                contaEscolhida.Sacar();
                break;
            case 3:
                Console.WriteLine($"Saldo atual: R$ {contaEscolhida.Saldo:F2}");
                break;
            case 4:
                if (contaEscolhida is ContaPoupanca contaPoupanca)
                {
                    Console.WriteLine($"Saldo antes do rendimento: R$ {contaPoupanca.Saldo:F2}");
                    contaPoupanca.CalcRendimento();
                    Console.WriteLine($"Saldo após rendimento: R$ {contaPoupanca.Saldo:F2}");
                }
                else
                {
                    Console.WriteLine($"Esta não é uma conta poupança. Não é possível aplicar rendimento.");
                }
                break;
            default:
                Console.WriteLine($"Opção Inválida");
                break;
        }

        Console.WriteLine($"Pressione <Enter> para continuar...");
        Console.ReadLine();

    } while (opcao != 0);

} while (opcao != 0);