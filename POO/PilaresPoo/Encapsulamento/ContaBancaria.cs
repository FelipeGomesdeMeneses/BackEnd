namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;


        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoinicial)
        {
            if(saldoinicial > 0)
            {
                Saldo = saldoinicial;
            }
            else
            {
                Saldo = 0;
            }
        }

        //Set de Saldo
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Valor inválido de depósito");
            }
            else
            {
                Saldo += valor;
            }

        }


        //Get do Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso");
                
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente ou negativo");
            }
        }
    }
}