
string[] students = new string[3] { "engin", "derin", "salih" };

string[] students2 = { "engin", "derin", "salih" };

foreach (var student in students)
{
    Console.WriteLine(student); 
}

string[,] regions = new string[5,3]
{
    { "istanbul","izmit","balıkesir" },
    { "ankara","konya","kırıkale" },
    { "antalya","adana","mersin" },
    { "rize","trabzon","samsun" },
    { "izmir","muğla","manisa" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("*****************");
}