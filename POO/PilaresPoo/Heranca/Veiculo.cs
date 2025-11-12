namespace Heranca
{
    public class Veiculo
    {
        public string Marca = "";
        public string Modelo = "";

        public virtual void MostraInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }
        

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o veículo ");
            
        }
    }
}