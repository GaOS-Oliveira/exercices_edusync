// List 6 - Vetor e Funções

// 1
static void excc_01()
{
    var cubos = new List<int> { };
    for (int i = 0; i < 8; i++)
    {
        cubos.Add((int)Math.Pow(i, 3));
    }
    cubos.ForEach(Console.WriteLine);
}

//excc_01();

// 2
static void excc_02()
{
    int[] lista = { 5, 1, 4, 2, 7, 8, 3, 6 };
    var lista2 = new List<int> { };
    foreach (int num in lista)
    {
        lista2.Add(num * 2);
    }
    lista2.ForEach(Console.WriteLine);
}

//excc_02();

// 3
static void excc_03()
{
    Random rnd = new Random();

    var lista = new List<int> { };
    var lista2 = new List<int> { };
    int x = rnd.Next(2, 50);

    for (int i = 1; i < 11; i++)
    {
        lista.Add(i);
    }
    foreach (int num in lista)
    {
        lista2.Add(num * x);
    }
    Console.WriteLine($"x = {x}");
    Console.WriteLine(String.Join(' ', lista2));
}

//excc_03();


// 4
static void excc_04()
{
#pragma warning disable CS8604
#pragma warning disable CS8600

    var nomes = new List<string> { };
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Enter a name:");
        nomes.Add((string?)Console.ReadLine());
    }

    Console.WriteLine("\nEnter a name to search:");
    string name_src = (string?)Console.ReadLine();

    if (nomes.Contains((string?)name_src))
    {
        Console.WriteLine("\nAchei!");
    }
    else
    {
        Console.WriteLine("\nNão Achei.");
    }
#pragma warning restore CS8604
#pragma warning restore CS8600
}

//excc_04();

// 5
static void excc_05()
{
#pragma warning disable CS8604

    var numbers = new List<int> { };
    var x = true;
    while (x)
    {
        Console.WriteLine("Enter a even number:");
        int temp = Int32.Parse(Console.ReadLine());
        if (temp % 2 == 0)
        {
            numbers.Add(temp);
            if (numbers.Count == 10)
            {
                x = false;
            }
        }
    }

    var max_num = numbers.Max();
    var index_max_num = numbers.IndexOf(max_num);

    Console.WriteLine($"Max number:{max_num} - Index: {index_max_num}");
#pragma warning restore CS8604
}

//excc_05();

// 6
static void excc_06()
{
#pragma warning disable CS8604

    var weather_week = new List<int> { };
    bool x = true;
    while (x)
    {
        Console.WriteLine("Enter the temperature of the day:");
        weather_week.Add(Int32.Parse(Console.ReadLine()));
        if (weather_week.Count == 7)
        {
            x = false;
        }
    }

    var weather_min = weather_week.Min();
    var weather_max = weather_week.Max();
    var weather_aver = weather_week.Sum() / 7;
    int bellow_aver = 0;

    foreach (int day in weather_week)
    {
        if (day < weather_aver)
        {
            bellow_aver++;
        }
    }

    Console.WriteLine($"Menor Temperatura da Semana: {weather_min}");
    Console.WriteLine($"Maior Temperatura da Semana: {weather_max}");
    Console.WriteLine($"Temperatura Média da Semana: {weather_aver}");
    Console.WriteLine($"Dias com Temperatura abaixo da Média: {bellow_aver}");

#pragma warning restore CS8604
}

//excc_06();

// 7
static void excc_07()
{
#pragma warning disable CS8604
    var numbers = new List<int> { };

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Enter a number:");
        numbers.Add(Int32.Parse(Console.ReadLine()));
    }
    numbers.Sort();

    Console.WriteLine(String.Join(' ', numbers));
#pragma warning restore CS8604
}

//excc_07();

// 8
static int excc_08_a(int num1, int num2, int num3)
{
    var sum = num1 + num2 + num3;
    Console.WriteLine($"A soma dos números é: {sum}");

    return sum;
}

static int excc_08_b(int num1, int num2, int num3)
{
    var sum = excc_08_a(num1, num2, num3);
    var average = sum / 3;
    Console.WriteLine($"A média dos números é: {average} (A parte decimal do número é excluída)");

    return average;

}

//excc_08_b(5, 7, 3);

// 9
static string excc_09(int num)
{
    if (num > 0)
    {
        Console.WriteLine("P");
        return "P";
    }
    else
    {
        Console.WriteLine("N");
        return "N";
    }
}

//excc_09(2);

// 10
static void excc_10(int num)
{
    var lenght_num = num.ToString().Length;
    Console.WriteLine(lenght_num);
}

//excc_10(1234567);
