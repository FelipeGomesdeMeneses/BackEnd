namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public float Bonus = 1.2f;
        public override void ExibirSalario()
        {
            float SalarioGerente = SalarioBase * Bonus;
            base.ExibirSalario();
            Console.WriteLine($"Salario com bônus adicional R$ {SalarioGerente}");
            
        }
    }
}