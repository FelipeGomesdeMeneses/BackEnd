namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informações do Veículo:
            Marca: {Marca}
            Modelo: {Modelo}
            Ano: {Ano}
            Cor: {Cor}
            ");
            
        }
        public void Acelerar()
        {
            Console.WriteLine($"Dando partida vrum, vrumm");
            
        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freando irrrrrr");
            
        }
    }
}