using System.Diagnostics;

string[] nomes = new string[10];
// int[] idades = new int[3];
float[] Saldo = new float[10];
int totalClientes = 0;
int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"==== Sistema Bancario ====");
    Console.WriteLine($"1) Cadastrar Clientes");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Tranferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:

            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Tranferir();
            break;

        case 5:
            ListarClientes();
            break;
        default:
            break;  
         
}

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);




void CadastrarCliente()
{
    // Console.WriteLine($"Funcao cadastrar cliente em deselvolvimento");

    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de cadastros atingido");
        return;
    }
    
     Console.WriteLine($"Digite o nome do Cliente");
    nomes[totalClientes] = Console.ReadLine();

    Console.WriteLine($"Digite o saldo de  {nomes[totalClientes]}");
    Saldo[totalClientes] = float.Parse(Console.ReadLine());
    totalClientes++;
    Console.WriteLine($"Aluno cadastrado com sucesso!");
}

void ListarClientes()
{
    Console.WriteLine($"Funcao listar cliente em deselvolvimento");
}

void Depositar()
{
    Console.WriteLine($"Funcao Depositar em deselvolvimento");
}

void Tranferir()
{
    Console.WriteLine($"Funcao Tranferir deselvolvimento");
}

void Sacar()
{
 Console.WriteLine($"Funcao Sacar em deselvolvimento");
}