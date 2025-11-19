namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double Raio;
        public double Area;
        public void CalcularArea()
        {
            Area = Math.PI * Raio * Raio;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"Área do Círculo {Area}");
            
        }
    }
}