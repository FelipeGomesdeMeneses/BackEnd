namespace Construtores
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string m1, string m2, int a)
        {
            Marca = m1;
            Modelo = m2;
            Ano = a;
        }
        
        public void Exibir()
        {
            Console.WriteLine($"Marca {Marca}, Modelo {Modelo}, Ano {Ano}.");
            
        }
    }
}