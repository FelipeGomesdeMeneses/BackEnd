namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;

        public float Taxa = 1.03f;
        public override double Depositar(double ValorDeposito)
        {
            Console.WriteLine($"Quanto você deseja depositar?");
            ValorDeposito = double.Parse(Console.ReadLine());

            if (ValorDeposito < 0)
            {
                Console.WriteLine($"O seu valor de depósito não pode ser negativo ou nulo");
                return -1;
            }
            else
            {
              double Saldo1 = Saldo += ValorDeposito;
                Console.WriteLine($"O seu novo saldo é de R${Saldo1}");
                return Saldo1;
            }

        }

        public override double Sacar(double ValorSaque)
        {
            Console.WriteLine($"Quanto você deseja sacar ?");
            ValorSaque = double.Parse(Console.ReadLine());

            if (ValorSaque > Saldo)
            {
                Console.WriteLine($"O seu valor de saque está maior que o seu saldo no momento de R${Saldo}");
                return -1;
            }
            else
            {
              double Saldo2 = Saldo -= ValorSaque * Taxa;
                Console.WriteLine($"O seu novo saldo é de R${Saldo2}");
                return Saldo2;
            }
            
        }
    }
}