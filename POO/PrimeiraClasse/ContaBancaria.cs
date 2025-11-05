namespace PrimeiraClasse
{
    public class ContaBancaria
    {
        public int valor = 0;
        public void Depositar()
        {
            Console.WriteLine($"Digite o valor desejado para depositar");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor depositado é R$ {valor}");

        }
        
        public void Sacar()
        {
            Console.WriteLine($"Digite o valor desejado para sacar");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor sacado é R$ {valor}");
            
        }
    }
}