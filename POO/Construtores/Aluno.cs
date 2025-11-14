namespace Construtores
{
    public class Aluno
    {
        public string Nome;

        public float Nota;

        public Aluno(string nom, float not)
        {
            Nome = nom;
            Nota = not;
        }

        public void Exibir()
        {
            Console.WriteLine($"Aluno: {Nome} tem a nota: {Nota}.");
            
        }
    }
}