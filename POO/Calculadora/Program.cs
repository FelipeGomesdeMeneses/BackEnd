using Calculadora;

int opcao;

Calculator calc = new Calculator();
do
{
    calc.Cabecalho();
    Console.WriteLine();
    Console.WriteLine($"Digite o primeiro número");
    calc.Num1 = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine($"Digite o segundo número");
    calc.Num2 = double.Parse(Console.ReadLine());
    Console.WriteLine();


    Console.WriteLine($"1) Somar");
    Console.WriteLine($"2) Subtrair");
    Console.WriteLine($"3) Multiplicar");
    Console.WriteLine($"4) Dividir");
    Console.WriteLine($"0) Sair");
    Console.WriteLine();
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine();


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar ...");
            Console.WriteLine();
            break;
        case 1:
            Console.WriteLine($"Resultado da soma {calc.Somar()}");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine($"Resultado da subtração {calc.Subtrair()}");
            Console.WriteLine();
            break;

        case 3:
            Console.WriteLine($"Resultado da multiplicação {calc.Multiplicar()}");
            Console.WriteLine();
            break;

        case 4:
            if (calc.Num2 == 0)
            {
                Console.WriteLine($"Não existe divisão por zero");
            }
            else
            {
                Console.WriteLine($"Resultado da divisão {calc.Dividir()}");
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine($"Opção escolhida inválida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);