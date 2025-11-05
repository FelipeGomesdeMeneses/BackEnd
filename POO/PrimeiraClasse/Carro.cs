
namespace PrimeiraClasse
{
    public class Carro
    {
        public string modelo;
        public string marca;
        public string cor;
        public int potencia;


        public void Ligar()
        {
            Console.WriteLine($"Ligando em 3, 2, 1 ... vrum");
        }
        public void Acelerar()
        {
            Console.WriteLine($"Vrum, Vrum ...");
        }
    }
}