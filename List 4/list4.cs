// List de Exercícios - Estrutura Sequencial

// 1
static void excc_01()
{
    int A = 5;
    int B = 15;
    int C = 25;

    double X = A + B / C;

    Console.WriteLine($"{X} = {A} + {B} / {C}");
}

//excc_01();

// 2
static void excc_02()
{
    double nota1 = 5.0;
    double nota2 = 7.0;
    double nota3 = 8.0;

    double media = ((nota1 * 2.0) + (nota2 * 3.0) + (nota3 * 5.0)) / 10.0;

    Console.WriteLine($"Média = {media}");
}

//excc_02();

// 3
static void excc_03()
{
    double time_s = 3920.0;

    double time_m = time_s / 60.0;
    double time_h = time_s / 3600.0;

    Console.WriteLine($"{time_h} horas equivale a {time_m} minutos que equivale a {time_s} segundos.");
}

//excc_03();

// 4
static void excc_04()
{
    double base_t = 25.0;
    double height_t = 45.0;

    double area = base_t * height_t / 2.0;

    Console.WriteLine($"A área de um triângulo equilátero de base {base_t} e altura {height_t} equivale a {area}");
}

//excc_04();

// 5
static void excc_05()
{
    int A = 5;
    int B = 2;
    int C = 9;

    double equation = Math.Pow((A + B), 2.0) + C;

    Console.WriteLine($"Resultado: {equation}");
}

//excc_05();

// 6
static void excc_06()
{
    int num = 9;

    int double_predecessor = (num - 1) * 2;

    Console.WriteLine($"O dobro do antecessor de {num} é {double_predecessor}");
}

//excc_06();

// 7
static void excc_07()
{
    int voters = 50000;
    int white_v = 15000;
    int null_v = 10000;
    int valid_v = 25000;

    double white_v_pcent = 100.0 / (voters / white_v);
    double null_v_pcent = 100.0 / (voters / null_v);
    double valid_v_pcent = 100.0 / (voters / valid_v);

    Console.WriteLine($"Votos Totais: {voters}\nVotos Brancos: {white_v} ({white_v_pcent}%)\nVotos Nulos: {null_v} ({null_v_pcent}%)\nVotos Válidos: {valid_v} ({valid_v_pcent}%)");
}

//excc_07();

// 8
static void excc_08()
{
    double price_factory = 75000.0;

    double pcent_distributor = (price_factory * 30.0) / 100.0;
    double taxes = (price_factory * 45.0) / 100.0;

    double final_price = price_factory + pcent_distributor + taxes;

    Console.WriteLine($"Preço final: R${final_price}");
}

//excc_08();
