
//Add();
//Add();
//Add();
//var result=Add2(20);

/*
int number1 = 20;
int number2 = 100; //değer tipler
var result2 = Add3(ref number1,number2);
//ref referans tip methodta değişirse burda da değişir
//out değer atamadan gönderilebilir, baştan set etme yok

Console.WriteLine(result2);
Console.WriteLine(number1);*/

Console.WriteLine(Overload.Multiply(2, 4));
Console.WriteLine(Overload.Multiply(2, 4, 5));

static void Add()
{
    Console.WriteLine("Added!");
}

//default değerler her zaman en sonda olmalı
static int Add2(int number1, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

public class Overload
{
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    //main içinde olduğunda hata veriyor
    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
}
