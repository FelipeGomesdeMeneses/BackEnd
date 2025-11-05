
namespace Calculadora
{
    public class Calculator
    {
        public double Num1;
        public double Num2;
        public double Resultado;
        public void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"            BEM VINDO           ");
            Console.WriteLine($"                a               ");
            Console.WriteLine($"          Calculadora OO        ");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine();
        }
        public double Somar()
        {
            Resultado = Num1 + Num2;
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = Num1 - Num2;
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = Num1 * Num2;
            return Resultado;
        }
        public double Dividir()
        {
            Resultado = Num1 / Num2;
            return Resultado;
        }
    }
}