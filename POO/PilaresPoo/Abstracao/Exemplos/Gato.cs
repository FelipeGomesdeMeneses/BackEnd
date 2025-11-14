namespace Exemplos
{
    public class Gato : Animais
    {

        public override void FazerSom()
        {
            Console.WriteLine($"Miau, Miau, Miau");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Ploc, Ploc, Ploc");
            
        }
    }
}