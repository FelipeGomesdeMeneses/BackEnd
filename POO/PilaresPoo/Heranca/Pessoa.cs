namespace Heranca
{
    public class Pessoa
    {
        public string Nome = "";

        public int Idade;

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            
            
        }
        
    }
}