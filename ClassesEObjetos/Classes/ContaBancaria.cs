namespace Classes
{
    public class ContaBancaria
    {
        public int saldo = 0;
        public void Depositar()
        {
            Console.WriteLine($"Digite o saldo desejado para depositar");
            saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"saldo depositado é R$ {saldo}");


        }
        
        public void Sacar()
        {
            Console.WriteLine($"Digite o saldo desejado para sacar");
            saldo = int.Parse(Console.ReadLine());
            Console.WriteLine($"saldo sacado é R$ {saldo}");
            
        }
    }
}