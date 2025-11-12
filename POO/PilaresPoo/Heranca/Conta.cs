namespace Heranca
{
    public class Conta
    {
        public int Numero;
        public float Saldo;

        public void Depositar()
        {
            Console.WriteLine($"Digite o saldo desejado para depositar");
            Saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"saldo depositado é R$ {Saldo}");

        }

        public void Sacar()
        {
            Console.WriteLine($"Digite o saldo desejado para sacar");
            Saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"saldo sacado é R$ {Saldo}");
        }
    }
}