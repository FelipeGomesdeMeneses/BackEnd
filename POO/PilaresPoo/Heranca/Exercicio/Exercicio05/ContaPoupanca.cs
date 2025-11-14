namespace Exercicio05
{
    public class ContaPoupanca : Conta
    {
        public void CalcRendimento()
        {
            Saldo = Saldo * 1.02f;

        }
    }
}