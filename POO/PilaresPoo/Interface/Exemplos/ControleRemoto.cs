namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;

        public int VolumeMaximo = 30;
        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV...");
            
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV...");
            
        }

        public void AumentarVolume()
        {
            if(NivelVolume != VolumeMaximo)
            {
            NivelVolume = NivelVolume + 1;
            Console.WriteLine($"Volume {NivelVolume}");
            
                
            }
            else
            {
                Console.WriteLine($"Volume Máximo atingido");
                return;
                
            }
        }
        public void DiminuirVolume()
        {
            if(NivelVolume <= 0)
            {
                Console.WriteLine($"Nível mínimo de volume atingido");
                return;
            }
            else
            {   
                NivelVolume = NivelVolume - 1;
                Console.WriteLine($"Volume {NivelVolume}");
            
            }

        }

    }
}