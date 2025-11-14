namespace Construtores
{
    public class Produto
    {
        public string Nome;

        public float Preco;

        public int Estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Preço da {Nome}: {Preco}");
            Console.WriteLine($"Quantidade de estoque: {Estoque}");
            
        }
    }
}