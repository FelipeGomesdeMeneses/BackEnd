namespace Construtores
{
    public class Livro
    {
        public string Titulo;

        public string Autor;

        public float Preco;

        public Livro(string t, string a, float p)
        {
            Titulo = t;
            Autor = a;
            Preco = p;
        }

        public Livro(string t, string a)
        {
            Titulo = t;
            Autor = a;
        }
        
        public void Exibir()
        {
            Console.WriteLine($"O título do livro é {Titulo}.");
            Console.WriteLine($"O autor do livro é {Autor}.");
            

            if (Preco != 0)
            {
                Console.WriteLine($"O preço do livro é {Preco}.");
                Console.WriteLine();
                

            }
            else
            {
                Console.WriteLine($"O preço do livro não foi informado.");
                
            }
            
            
        }
    }
}