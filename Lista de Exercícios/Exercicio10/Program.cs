int opcao;

do
{
    Console.WriteLine($"-------------------------------------------------------");
    Console.WriteLine($"                   Bem Vindo, Usuário                  ");
    Console.WriteLine($"-------------------------------------------------------");

    Console.WriteLine($"Escolha uma opção abaixo:");
    Console.WriteLine($"1) Exercício 1");
    Console.WriteLine($"2) Exercício 2");
    Console.WriteLine($"3) Exercício 3");
    Console.WriteLine($"4) Exercício 4");
    Console.WriteLine($"5) Exercício 5");
    Console.WriteLine($"6) Exercício 6");
    Console.WriteLine($"0) Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
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
        case 6:
            opcao6();
            break;
        case 0:
            sair();
            break;
        default:
            opcaoinvalida();
            break;
    }

    Thread.Sleep(3000);

} while (opcao != 0);


void opcao1()
{
    // Faça um programa que o usuário informe o salário recebido e o total gasto.
    // Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse
    // o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

    float salario, totalgasto;

    Console.WriteLine($"Olá, qual é o seu salário recebido?");
    salario = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual é o total gasto?");
    totalgasto = float.Parse(Console.ReadLine());

    if (salario > totalgasto)
    {
        Console.WriteLine($"Gastos dentro do orçamento.");
    }
    else if (totalgasto > salario)
    {
        Console.WriteLine($"Orçamento estourado");
    }
    else
    {
        Console.WriteLine($"Salário igual o total gasto");
    }
}


void opcao2()
{
    // Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e 
    // informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

    int goltime1, goltime2;

    Console.WriteLine($"Consulta salário");

    Console.WriteLine($"Resultado Futebol");

    Console.WriteLine($"Olá, digite os gols feitos pelo primeiro time");
    goltime1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Digite os gols feitos pelo segundo time");
    goltime2 = int.Parse(Console.ReadLine());

    if (goltime1 > goltime2)
    {
        Console.WriteLine($"O resultado foi vitória do time 1");
    }
    else if (goltime2 > goltime1)
    {
        Console.WriteLine($"O resultado foi vitória do time 2");
    }
    else
    {
        Console.WriteLine($"O resultado foi empate");
    }
}


void opcao3()
{
    // Escreva um programa que leia as medidas dos lados de um triângulo
    // e escreva se ele é Equilátero, Isósceles ou Escaleno. 

    // − Triângulo Equilátero: possui os 3 lados iguais.     
    // − Triângulo Isóscele: possui 2 lados iguais.     
    // − Triângulo Escaleno: possui 3 lados diferentes.

    float lado1, lado2, lado3;

    Console.WriteLine($"Consulta Triângulo");

    Console.WriteLine($"Ola, digite o valor do primeiro lado");
    lado1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o valor do segundo lado");
    lado2 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o valor do terceiro lado");
    lado3 = float.Parse(Console.ReadLine());

    if (lado1 == lado2 && lado1 == lado3)
    {
        Console.WriteLine($"Esse triângulo é equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine($"Esse triângulo é isóceles");
    }
    else
    {
        Console.WriteLine($"Esse triângulo é escaleno");
    }
}


void opcao4()
{
    // Escreva um programa que verifique a validade de uma senha fornecida pelo usuário.
    // A senha válida é o número 1234.
    // Devem ser impressas as seguintes mensagens:
    // - ACESSO PERMITIDO caso a senha seja válida.
    // - ACESSO NEGADO caso a senha seja inválida

    string senha = "";

    Console.WriteLine($"Consulta de senhas");

    Console.WriteLine($"Olá, digite sua senha");
    senha = Console.ReadLine();

    if (senha == "1234")
    {
        Console.WriteLine($"ACESSO PERMITIDO");
    }
    else
    {
        Console.WriteLine($"ACESSO NEGADO");
    }
}


void opcao5()
{
    // As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, 
    // e R$ 0,25 se forem compradas pelo menos doze.
    // Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

    float macacomprada, valortotal;

    Console.WriteLine($"Consulta preço das maçãs");

    Console.WriteLine($"Olá, quantas maçãs você comprou?");
    macacomprada = float.Parse(Console.ReadLine());

    if (macacomprada >= 12)
    {
        valortotal = macacomprada * 0.25f;
        Console.WriteLine($"Valor total da compra: {valortotal} ");
    }
    else
    {
        valortotal = macacomprada * 0.30f;
        Console.WriteLine($"Valor total da compra: {valortotal}");
    }
}


void opcao6()
{
    // Aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%.
    // Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7,
    // ainda teria direito a uma última avaliação de recuperação.
    // Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado,
    // porém caso a frequência respeite o mínimo exigido,
    // começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

    float media, frequencia;

    Console.WriteLine($"Consulta Escola");

    Console.WriteLine($"Olá, digite a média do aluno");
    media = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite a frequência do aluno em %");
    frequencia = float.Parse(Console.ReadLine());

    if (frequencia < 75)
    {
        Console.WriteLine($"Aluno reprovado por frequência");
    }
    else if (media < 3)
    {
        Console.WriteLine($"Aluno reprovado por média");
    }
    else if (media >= 3 && media < 7)
    {
        Console.WriteLine($"O aluno ainda tem direito a uma última avaliação de recuperação");
    }
    else
    {
        Console.WriteLine($"Aluno aprovado");
    }
}


void sair()
{
    Console.WriteLine("Encerrando o programa...");
}


void opcaoinvalida()
{
    Console.WriteLine("Você escolheu uma opção inválida");
}
