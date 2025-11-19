namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";//quem vai pagar o valor
        public string Credor = "";//quem vai receber o valor
        public float Valor = 0;//valor da fatura
        public int DiasAtrasos = 0;
        public float Juros = 0.10f;

        public Fatura(string DevedorFatura, string CredorFatura, float ValorFatura, int qtdDiasAtraso)
        {
            Devedor = DevedorFatura;
            Credor = CredorFatura;
            Valor = ValorFatura;
            DiasAtrasos = qtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if(DiasAtrasos > 0)
            {
                Valor = Valor + DiasAtrasos * Juros;
            }


            if(DiasAtrasos >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
        public void Imprimir()
        {
            CalcularValorDivida();

            Console.WriteLine($@"
Credor: {Credor}
Devedor: {Devedor}
Dias de Atraso: {DiasAtrasos}
Juros: R${DiasAtrasos * Juros}
Valor Total: R${Valor}
            ");

        }

    }
}