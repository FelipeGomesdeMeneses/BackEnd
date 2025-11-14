namespace Exercicio05
{
    public class Conta
    {
        public int Numero;
        public float Saldo;

        public void Depositar()
        {
            Console.WriteLine("Digite o valor desejado para depositar:");
            float deposito = float.Parse(Console.ReadLine());

            Saldo += deposito;

            Console.WriteLine($"Saldo depositado: R$ {deposito}. Saldo atual: R$ {Saldo}");
        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor desejado para sacar:");
            float saque = float.Parse(Console.ReadLine());

            if (saque <= Saldo)
            {
                Saldo -= saque;
                Console.WriteLine($"Saque realizado: R$ {saque}. Saldo atual: R$ {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }
    }
}