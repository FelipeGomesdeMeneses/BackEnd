namespace Construtores
{
    public class AlunoMedia
    {
        public string Nome;

        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float Media;

        public AlunoMedia(string n, float n1, float n2, float n3)
        {
            Nome = n;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }
        public AlunoMedia(string n)
        {
            Nome = n;
            Nota1 = 0;
            Nota2 = 0;
            Nota3 = 0;
        }
        public void Calc()
        {
            Media = (Nota1 + Nota2 + Nota3) / 3;
            Console.WriteLine($"A média do aluno {Nome} é {Media}");
            
        }
    }
}