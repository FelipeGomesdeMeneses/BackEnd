//aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%.
//Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7,
//ainda teria direito a uma última avaliação de recuperação.
//Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado,
//porém caso a frequência respeite o mínimo exigido,
//começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.

float media, frequencia;

Console.WriteLine($"Consulta Escola");

Console.WriteLine($"Olá, digite a média do aluno");
media = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a frequência do aluno em %");
frequencia = float.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Aluno reprovado por frequência");
}
else if (media < 3)
{
    Console.WriteLine($"Aluno reprovado por média");
}
else if (media >= 3 && media < 7)
{
    Console.WriteLine($"O aluno ainda tem direito a uma última avaliação de recuperação");
}
else
{
    Console.WriteLine($"Aluno aprovado");

}