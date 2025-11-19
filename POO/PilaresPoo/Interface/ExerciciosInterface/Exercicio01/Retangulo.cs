namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public double Largura;
        public double Altura;
        public double Area;
        public void CalcularArea()
        {
            Area = Largura * Altura;
        }

        public void ExibirArea()
        {
            Console.WriteLine($"Área do Retângulo {Area}");
            
        }
    }
}