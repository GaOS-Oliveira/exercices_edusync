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
    float nota1 = 5.0f;
    float nota2 = 7.0f;
    float nota3 = 8.0f;

    float media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

    Console.WriteLine($"Média = {media}");
}

//excc_02();

// 3
static void excc_03()
{
    double time_s = 3920;

    double time_m = time_s / 60;
    double time_h = time_s / 3600;

    Console.WriteLine($"{time_h} horas equivale a {time_m} minutos que equivale a {time_s} segundos.");
}

//excc_03();

// 4
static void excc_04()
{
    float base_t = 25f;
    float height_t = 45f;

    float area = base_t * height_t / 2;

    Console.WriteLine($"A área de um triângulo equilátero de base {base_t} e altura {height_t} equivale a {area}");
}

//excc_04();

// 5
static void excc_05()
{
    int A = 5;
    int B = 2;
    int C = 9;

    double equation = Math.Pow((A + B), 2) + C;

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

    float white_v_pcent = 100 / (voters / white_v);
    float null_v_pcent = 100 / (voters / null_v);
    float valid_v_pcent = 100 / (voters / valid_v);

    Console.WriteLine($"Votos Totais: {voters}\nVotos Brancos: {white_v} ({white_v_pcent}%)\nVotos Nulos: {null_v} ({null_v_pcent}%)\nVotos Válidos: {valid_v} ({valid_v_pcent}%)");
}

//excc_07();

// 8
static void excc_08()
{
    float price_factory = 75000f;

    float pcent_distributor = (price_factory * 30) / 100;
    float taxes = (price_factory * 45) / 100;

    float final_price = price_factory + pcent_distributor + taxes;

    Console.WriteLine($"Preço final: R${final_price}");
}

//excc_08();