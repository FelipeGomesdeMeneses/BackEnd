using Exercicio02;

// //Cria uma lista para faturas, relatórios e contratos
// List<Fatura> ListaFatura = new List<Fatura>();
// List<Relatorio> ListaRelatorio = new List<Relatorio>();
// List<Contrato> ListaContrato = new List<Contrato>();


// //cria um objeto de cada classe e adiciona nas listas
// Fatura fatFelipe = new Fatura();
// Documentos.Add(fatFelipe);
// Fatura fatAlee = new Fatura();
// Documentos.Add(fatAlee);


// Relatorio relFelipe = new Relatorio();
// Documentos.Add(relFelipe);
// Relatorio relAlee = new Relatorio();
// Documentos.Add(relAlee);


// Contrato contFelipe = new Contrato();
// Documentos.Add(contFelipe);
// Contrato contAlee = new Contrato();
// Documentos.Add(contAlee);



// Console.WriteLine($"FATURAS");
// foreach (var item in Documentos)
// {
//     if (item is Fatura)
//     {
//         item.Imprimir();
//     }
// }

// Console.WriteLine($"");
// Console.WriteLine($"RELATÓRIOS");
// foreach (var item in Documentos)
// {
//     if (item is Relatorio)
//     {
//         item.Imprimir();
//     }
// }

// Console.WriteLine($"");
// Console.WriteLine($"CONTRATOS");
// foreach (var item in Documentos)
// {
//     if (item is Contrato)
//     {
//         item.Imprimir();
//     }
// }


List<IImprimivel> Documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opções
    1) Cadastrar Faturas
    2) Cadastrar Relatório   
    3) Cadastrar Contrato   
    4) Listar Faturas
    5) Listar Relatórios   
    6) Listar Contratos 
    0) Sair
    Escolha a opção
    ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contratos em desenvolvimento");
            break;
        case 4:
            ListarFaturas();
            break;
        case 5:
            Console.WriteLine($"Listar Relatório em desenvolvimento");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string Dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string Empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura");
    int QTDAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(Dev, Empresa, Valor, QTDAtraso);
    Documentos.Add(fat);

    Console.WriteLine($"Fatura Cadastrada com sucesso");
    


}

void CadastrarRelatorios()
{

}

void CadastrarContratos()
{

}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }

}

void ListasRelatorios()
{

}

void ListarContratos()
{

}