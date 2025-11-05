namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Console.WriteLine($"Objeto Criado");

        }
        public Pessoa(String n, int i)
        {
            Nome = n;
            Idade = i;
        }

        // public Pessoa()
        // {
        //     Nome = "Desconhecido";
        //     Idade = 0;
        // }

        // public Pessoa(string n)
        // {
        //     Nome = n;
        //     Idade = 0;
        // }

        // public Pessoa(string = n, int i)
        // {
        //     Nome = n;
        //     Idade = i;
        // }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade {Idade}");

        }
    }
}