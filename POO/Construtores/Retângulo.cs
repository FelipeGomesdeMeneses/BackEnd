namespace Construtores
{
    public class Retângulo
    {
        public string Nome;
        public float Altura;

        public float Largura;

        public float Area;

        public Retângulo(string n,float a, float l)
        {
            Nome = n;
            Altura = a;
            Largura = l;
        }

        public Retângulo(string n)
        {
             Nome = n;
             Altura = 1;
             Largura = 1;
        }

        public void Calc()
        {
            Area = Largura * Altura;
        }
        public void Exibir()
        {
            Console.WriteLine($"Área do retângulo do {Nome}: {Area}");
        }
    }
}