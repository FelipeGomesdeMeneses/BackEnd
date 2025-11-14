namespace Exemplos
{
    public class Pessoa : Animais
    {
        public  string Nome;

        public  int Idade;

        public  void Dormir()
        {
            Console.WriteLine($"zzzzzzzzzz");
            
        }


        public override void FazerSom()
        {
            Console.WriteLine($"AAAAAAAAAAAAAAAAAAAAAAA!");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Tum! Tum! Tum!");
            
        }
        public void ExibirInfo()
        {
            Nome = "Arthur Batista";
            Idade = 18;
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            FazerSom();
            Mover();
        }

    }
}