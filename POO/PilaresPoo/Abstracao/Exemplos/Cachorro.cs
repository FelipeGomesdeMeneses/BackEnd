namespace Exemplos
{
    public class Cachorro : Animais
    {
        public override void FazerSom()
        {
                Console.WriteLine($"Au Au Au");
                
        }
        public override void Mover()
        {
            Console.WriteLine($"Pluf Pluf Pluf");
            
        }
    }
}