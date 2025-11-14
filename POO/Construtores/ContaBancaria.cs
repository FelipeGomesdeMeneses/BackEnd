namespace Construtores
{
    public class ContaBancaria
    {
        public string Titular;

        public float Saldo;

        public ContaBancaria(string t, float s)
        {
            Titular = t;
            Saldo = s;
        }
        public ContaBancaria(string t)
        {
            Titular = t;
        }

        public void Exibir()
        {
            Console.WriteLine($"Titular da conta bancária: {Titular}");
            Console.WriteLine($"Saldo da conta bancária: {Saldo}");
            
        }
    }
}