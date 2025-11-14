namespace Construtores
{
    public class TresConstrutores
    {
        public string Nome;

        public int Idade;

        public TresConstrutores()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public TresConstrutores(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public TresConstrutores(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void Exibir()
        {
            Console.WriteLine($"{Nome} tem {Idade} anos.");
            
        }
    }
}