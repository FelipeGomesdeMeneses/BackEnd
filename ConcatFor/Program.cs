int qtdletras = 0;

Console.WriteLine($"Olá usuário, quantas letras tem o seu nome?");
qtdletras = int.Parse(Console.ReadLine());
string nome = "";

for(int i = 1; i <=qtdletras; i++)
{
    Console.WriteLine($"Qual é a {i} ° letra?");
    nome += Console.ReadLine();
     
}

Console.WriteLine($"Seu nome é : {nome}");


