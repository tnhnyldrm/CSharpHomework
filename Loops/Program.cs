
//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();

if (IsPrimeNumber(6))
{
    Console.WriteLine("is a prime number");
}
else
{
    Console.WriteLine("is not a prime number");
}
static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i=number;
        }
    }
    return result;
}

static void ForLoop()
{
    for (int i = 0; i < 100; i = i + 2)
    {
        Console.WriteLine(i);
    }
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 0);
}

static void ForEachLoop()
{
    string[] students = new string[3] { "engin", "derin", "salih" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}