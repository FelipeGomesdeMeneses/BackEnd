namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string NomeDoResponsavel = "";
        public string TextoRelatorio = "";

        public Relatorio(string nomedoresponsavel, string textorelatorio)
        {
            NomeDoResponsavel = nomedoresponsavel;
            TextoRelatorio = textorelatorio;
        }

        public void Imprimir()
        {

            Console.WriteLine($@"
Nome do Responsável {NomeDoResponsavel}
Texto do Relatório {TextoRelatorio}
            ");
        }
    }
}