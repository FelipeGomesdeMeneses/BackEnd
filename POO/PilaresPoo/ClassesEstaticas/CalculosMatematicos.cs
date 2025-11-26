namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static double PI = 3.14159265359;

        public static float Somar(float x, float y)
        {
            return x + y;
        }
        public static float Subtrair(float x, float y)
        {
            return x - y;
        }
        public static float Multiplicacao(float x, float y)
        {
            return x * y;
        }
        public static float Divisao(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine($"Divisão Inválida");

            }
            return x / y;
        }

        
    }
}