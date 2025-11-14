namespace Construtores
{
    public class Funcionario
    {
        public string Nome;
        public string Cargo;
        public float Salario;

        public Funcionario(string n)
        {
            Nome = n;
            Cargo = "Desconhecido";
            Salario = 0;
        }
        public Funcionario(string n, string c)
        {
            Nome = n;
            Cargo = c;
            Salario = 0;
        }
        public Funcionario(string n, string c, float s)
        {
            Nome = n;
            Cargo = c;
            Salario = s;
        }
        public void Exibir()
        {
            Console.WriteLine($"O nome do funcionário é {Nome}, o Cargo é {Cargo} e o salário é {Salario}");
            
        }
    }
}