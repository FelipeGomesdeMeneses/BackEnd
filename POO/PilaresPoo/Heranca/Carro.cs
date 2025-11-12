namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public override void MostraInfo()
        {
            base.MostraInfo();
            Console.WriteLine($"Quantidade de Portas: {QtdPortas}");
            
        }
        
    }
}