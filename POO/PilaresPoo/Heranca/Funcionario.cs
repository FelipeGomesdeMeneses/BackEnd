namespace Heranca
{
    public class Funcionario
    {
        public string Nome = "";

        public float SalarioBase ;

        public virtual void ExibirSalario()
        {
            Console.WriteLine($"Salário do Funcionário {Nome}: R${SalarioBase}");
            
        }
    }
}