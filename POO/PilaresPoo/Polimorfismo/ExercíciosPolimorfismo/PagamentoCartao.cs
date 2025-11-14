namespace ExercíciosPolimorfismo
{
    public class PagamentoCartao : Pagamento
    {
        private float Acrescimo = 5.38f;
        public float ValorCompra;
        public override float CalcularTotal()
        {
            float ValorAcrescimo = ValorCompra / 100 * Acrescimo; // Quanto paga a mais

            

            return ValorCompra = ValorCompra + ValorAcrescimo;;
        }
    }
}