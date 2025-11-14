namespace Exercicio04
{
    public class Aluno : Pessoa
    {
        public string Curso = "";

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Curso: {Curso}");
            
        }
    }
}