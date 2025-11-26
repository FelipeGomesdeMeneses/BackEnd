namespace Exercicio1
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }
        public string ObterMarca()
        {
            return Marca;
        }
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }
        public string ObterModelo()
        {
            return Modelo;
        }
        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }
        public void Acelerar(int valor)
        {
            if(valor < 0)
            {
                Console.WriteLine($"Valor inválido");
            }
            else
            {
                VelocidadeAtual = VelocidadeAtual + valor;
                Console.WriteLine($"Nova velocidade: {VelocidadeAtual}");
            }
        }
        public void Desacelerar(int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine($"Valor inválido");
            }
            else
            {
                VelocidadeAtual = VelocidadeAtual - valor;
                if(VelocidadeAtual < 0)
                {
                    VelocidadeAtual = 0;
                }
                
            }
                Console.WriteLine($"Velocidade atual {VelocidadeAtual}");
        }

    }
}