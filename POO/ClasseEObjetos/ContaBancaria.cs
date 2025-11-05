namespace ClasseEObjetos
{
    public class ContaBancaria
    {
        public string Titular;
        public float Saldo;
        public void Depositar(float Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine($"Valor de depósito inválido. O valor deve ser maior que zero.");
                return;
            }
            Saldo += Valor;

             Console.WriteLine($"Depósito de R$ {Valor:F2} realizado na conta com o titular {Titular}. Saldo atual R$ {Saldo}");
        }

        public void Sacar(float Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine($"Valor para saque inválido. O valor deve ser maior que zero.");
                return;
            }
            if (Saldo < Valor)
            {
                Console.WriteLine($"Saldo atual{Saldo}");
                Console.WriteLine($"Não é possível sacar este valor solicitado. Por favor insira um valor válido.");
                return;
            }

            Saldo -= Valor;

             Console.WriteLine($"Saque de R$ {Valor:F2} realizado na conta com o titular {Titular}. Saldo atual R${Saldo}.");

        }
    }
}