using ClasseEObjetos;

// //Garrafas
// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Azul Goiaba";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.WriteLine($"Abrindo a garrafa Stanley");
// Stanley.Abrir();

// Console.WriteLine($"Bebendo água da garrafa Stanley");
// Stanley.Beber();





// Conta Bancária
int opcao;
ContaBancaria Conta1 = new ContaBancaria();

Console.Clear();
Console.WriteLine($"Sistema Bancário");
Console.WriteLine();
Console.WriteLine($"Qual é o titular da conta bancária?");
Conta1.Titular = Console.ReadLine();
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
            Console.WriteLine($"Valor para depósito: ");
            float Valor = float.Parse(Console.ReadLine());

            Conta1.Depositar(Valor);

            break;
        case 2:
            Console.WriteLine($"Valor para saque: ");
            Valor = float.Parse(Console.ReadLine());

            Conta1.Sacar(Valor);

            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);





// //Produto com Desconto
// Produto Produto1 = new Produto();

// Console.Clear();
// Console.WriteLine($"Olá, digite o seu nome");
// Produto1.Nome = Console.ReadLine();

// Console.WriteLine($"Digite o valor do produto");
// Produto1.Preco = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o valor do desconto em porcentagem");
// double Desconto = float.Parse(Console.ReadLine());

// Produto1.AplicarDesconto(Desconto);

// Console.WriteLine($"Seu nome é {Produto1.Nome} e o valor após o desconto é {Produto1.Preco}");