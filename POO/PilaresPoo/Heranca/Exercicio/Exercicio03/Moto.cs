namespace Exercicio03
{
    public class Moto : Veiculo
    {

        public string TipoCapacete = "";


        public override void MostraInfo()
        {
            base.MostraInfo();
            Console.WriteLine($"Tipo de Capacete: {TipoCapacete}");
            
        }
    }
}