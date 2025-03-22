
int[] notas = new int[5];
double soma = 0.00;
double media = 0.00;
int menu = 0;

do
{
    Console.WriteLine("===Gerenciador de Notas===");
    Console.WriteLine("1-Cadastrar Notas");
    Console.WriteLine("2-Listar notas");
    Console.WriteLine("3-Estatisticas");
    Console.WriteLine("4-Sair");
    menu = int.Parse(Console.ReadLine());

    if (menu == 1)
    {
        try
        {
            for (int pos = 0; pos < notas.Length; pos++)
            {
                Console.Write($"Digite a {pos + 1}ª nota:");
                notas[pos] = int.Parse(Console.ReadLine());
                soma = notas[pos] + soma;
                if (notas[pos] < 0 || notas[pos] > 10)
                {
                    throw new ArgumentOutOfRangeException("Número invalido");
                }
            }
            Console.WriteLine("Notas do aluno:");
            for (int pos = 0; pos < notas.Length; pos++)
            {
                Console.Write($"{notas[pos]} ");
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
        }
        catch (FormatException ex1)
        {
            Console.WriteLine("ERRO: Formato INVÁLIDO");
        }
        catch (OverflowException ex1)
        {
            Console.WriteLine("ERRO: Número muito grande");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Número invalido");
        }
    }

    if (menu == 2)
    {
        Console.WriteLine("Notas do aluno:");
        for (int pos = 0; pos < notas.Length; pos++)
        {
            Console.Write($"{notas[pos]} ");
        }
    }

    if(menu == 3)
    {
        Console.WriteLine($"A média atual do aluno é: {media}");
    }

    Console.WriteLine();
}
while (menu != 4);
