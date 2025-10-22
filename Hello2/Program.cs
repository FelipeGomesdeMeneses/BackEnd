// Pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario e quanto investiu 

// Kemel case - Letra maiscula a partir da segunda palavra
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

//Pasca case - Primeira letra de cada palavra sempre maiscula
Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Quanto você investiu?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Nome: {nome}  {sobrenomeDoFulano}");
Console.WriteLine($"Idade: {nome} ");
Console.WriteLine($"Saldo Bancário do {nome} : R$ {saldoBancario}");
Console.WriteLine($"Investimentos do {nome}: R$ {investimentos}");
