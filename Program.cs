
int[] notas = new int[5];
double soma = 0.00;
double media = 0.00;
for (int pos = 0; pos < notas.Length; pos++)
{
    Console.Write($"Digite a {pos+1} notas:");
    notas[pos] = int.Parse(Console.ReadLine());
    soma = notas[pos] + soma;
}
    Console.WriteLine("Notas do aluno:");
for (int pos = 0;pos < notas.Length; pos++)
{
    Console.Write($"{notas[pos]} " );
}
media = soma / 5;

Console.WriteLine();

Console.WriteLine($"Media: {media}");
if (media >= 7)
{
    Console.WriteLine("O aluno foi APROVADO!");
}
else
{
    Console.WriteLine("O aluno foi REPROVADO!");
}
