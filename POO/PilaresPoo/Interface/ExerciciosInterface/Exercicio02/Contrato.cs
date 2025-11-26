namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Nome = "";
        public string TextoClausulas = "";

        public Contrato(string nome, string textoclausulas)
        {
            Nome = nome;
            TextoClausulas = textoclausulas;
        }

        public void Imprimir()
        {

            Console.WriteLine($@"
Nome {Nome}
Cláusulas {TextoClausulas}
            ");
        }
    }
}