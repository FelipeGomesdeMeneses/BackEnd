// Desenvolva um programa que recebe do usuário,o placar de um jogo de futebol (os gols de cada time) e 
//informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

int goltime1, goltime2;

Console.WriteLine($"Resultado Futebol");


Console.WriteLine($"Olá, digite os gols feitos pelo primeiro time");
goltime1 = int.Parse(Console.ReadLine());


Console.WriteLine($"Digite os gols feitos pelo segundo time");
goltime2 = int.Parse(Console.ReadLine());

if(goltime1 > goltime2)
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
