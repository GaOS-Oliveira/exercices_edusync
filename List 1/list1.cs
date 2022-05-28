// Lista de Exercícios 1 — Variáveis

// a)
void excc_a()
{
    Console.WriteLine("************ Exercício A ************");
    int x = 15;
    int y = 20;

    Console.WriteLine($"x = {x}");

    int b = 3;

    Console.WriteLine($"x = {x}, y = {y}");
    Console.WriteLine("*************************************");
}

excc_a();

// b)
void excc_b()
{
    Console.WriteLine("************ Exercício B ************");
    int a = 15;
    int b = 3;
    int c = a * b;

    Console.WriteLine($"c = {c}");

    b = 10;
    c = a - b;

    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine("*************************************");
}

excc_b();

// c)
void excc_c()
{
    Console.WriteLine("************ Exercício C ************");
    int x = 10;
    int y = 12;
    int z = x;
    y = z;
    x = y;

    Console.WriteLine($"x = {x}, y = {y}, z = {z}");
    Console.WriteLine("*************************************");
}

excc_c();

// d)
void excc_d()
{
    Console.WriteLine("************ Exercício D ************");
    int a = 10;
    int b = a + 2;
    a = b + 1;
    b = a + 1;

    Console.WriteLine($"a = {a}");

    a = b + 1;

    Console.WriteLine($"a = {a}, b = {b}");
    Console.WriteLine("*************************************");
}

excc_d();

// e)
void excc_e()
{
    Console.WriteLine("************ Exercício E ************");
    int x = 12;
    int y = x;
    int z = x + y;
    x = 20;
    y = 10;

    Console.WriteLine($"x = {x}, y = {y}, z = {z}");
    Console.WriteLine("*************************************");
}

excc_e();

// f)
void excc_f()
{
    Console.WriteLine("************ Exercício F ************");
    int a = 2;
    int b = 3;
    a = a + b;
    int c = a - b;

    Console.WriteLine($"c = {c}");

    b = 5;

    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    Console.WriteLine("*************************************");
}

excc_f();