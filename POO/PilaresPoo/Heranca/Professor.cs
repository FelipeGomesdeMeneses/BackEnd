namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina = "";

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Disciplina: {Disciplina}");
            
        }
    }
}