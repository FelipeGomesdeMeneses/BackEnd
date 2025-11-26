using Encapsulamento;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaMaria = new ContaBancaria();

contaEdu.Depositar(-100);
contaEdu.Depositar(20);

contaEdu.Sacar(-200);
contaMaria.Sacar(10);

Console.WriteLine($"Saldo atual do Edu: R${contaEdu.GetSaldo()}");
Console.WriteLine($"Saldo atual da Maria: R${contaMaria.GetSaldo()}");


