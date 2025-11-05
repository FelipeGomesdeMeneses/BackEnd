namespace ClasseEObjetos
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public void AplicarDesconto(double Desconto)
        {
            Preco = Preco - (Preco * Desconto) / 100;
        }
    }
}