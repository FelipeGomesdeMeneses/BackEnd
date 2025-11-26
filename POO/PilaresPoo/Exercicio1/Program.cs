using Exercicio1;
Console.Clear();

Carro BMW = new Carro();
BMW.DefinirMarca("BMW");
BMW.DefinirModelo("M1");

BMW.Acelerar(50);
BMW.Acelerar(-1);
BMW.Desacelerar(10);
BMW.Desacelerar(60);

Console.WriteLine($"Velocidade atual {BMW.ObterVelocidade()}");
Console.ReadLine();