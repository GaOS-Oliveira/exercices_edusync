// Lista de Exercícios 3 - Condicional e Repetição

// 1
static void excc_01()
{
    double nota1 = 5.0;
    double nota2 = 7.0;
    double nota3 = 5.0;

    double media = (nota1 + nota2 + nota3) / 3.0;

    Console.WriteLine($"Média = {media}");

    if (media >= 6.0)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

//excc_01();

// 2
static void excc_02()
{
    int A = 9;
    int B = 6;
    int C = 7;

    if (A > B)
    {
        if (B > C)
        {
            Console.WriteLine($"{A} é o maior número.");
        }
        else
        {
            Console.WriteLine($"{C} é o maior número.");
        }
    }
    else if (B > C)
    {
        Console.WriteLine($"{B} é o maior número.");
    }
    else
    {
        Console.WriteLine($"{C} é o maior número.");
    }
}

//excc_02();

// 3
static void excc_03()
{
    int A = 12;
    int B = 3;

    if (A % B == 0 || B % A == 0)
    {
        Console.WriteLine("São múltiplos.");
    }
    else
    {
        Console.WriteLine("Não são múltiplos.");
    }
}

//excc_03();

// 4
static void excc_04()
{
    float altura = 1.95f;
    int sexo = 1; // 0 para homem, 1 para mulher

    if (sexo == 0)
    {
        float imc = (72.7f * altura) - 58;
        Console.WriteLine($"Seu IMC é {imc}");
    }
    else if (sexo == 1)
    {
        float imc = (62.1f * altura) - 44.7f;
        Console.WriteLine($"Seu IMC é {imc}");
    }
    else
    {
        Console.WriteLine("Números inválidos.");
    }
}

//excc_04();

// 5
static void excc_05()
{
    int num1 = 5;
    int num2 = 5;

    if (num1 == num2)
    {
        Console.WriteLine("Números iguais.");
    }
    else if (num1 > num2)
    {
        Console.WriteLine("O Primeiro número é maior.");
    }
    else if (num1 < num2)
    {
        Console.WriteLine("O Segundo número é maior.");
    }
}

//excc_05();

// 6
static void excc_06()
{
    for (int i = 10; i > 0; i--)
    {
        Console.WriteLine($"{i}");
    }
}

//excc_06();

// 7
static void excc_07()
{
    for (int i = 1; i < 51; i++)
    {
        if (i % 5 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

//excc_07();

// 8
static void excc_08()
{
    int num = 13;

    for (int i = 1; i < num + 1; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

//excc_08();

// 9
static void excc_09()
{
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"7 X {i} = {i * 7}");
    }
}

//excc_09();

// 10

static int fibb(int num)
{
    if (num < 2)
    {
        return num;
    }
    else
    {
        return fibb(num - 1) + fibb(num - 2);
    }
}

static void excc_10()
{
    for (int i = 1; i < 16; i++)
    {
        Console.WriteLine($"(número {i}): {fibb(i)}");
    }
}

//excc_10();
