

double number5 = 10.4; //virgülden sonra 15 16 karakter
decimal number6 = 10.4m; //virgülden sonra 28 29 karakter

char character = 'a';
bool condition = true;

byte number4 = 255; //8bitlik yer kaplar 
short number3 = 32767; //16bitlik yer kaplar
int number1 = 2147483647; //32bitlik yer kaplar
long number2 = 9223372036854775807; //64bitlik yer kaplar

var number7 = 10;
number7 = 'A';

Console.WriteLine("number1 is {0}", number1);
Console.WriteLine("number2 is {0}", number2);
Console.WriteLine("number3 is {0}", number3);
Console.WriteLine("number4 is {0}", number4);
Console.WriteLine("number5 is {0}", number5);
Console.WriteLine("number7 is {0}", number7);
Console.WriteLine("Character is {0}", character);
Console.WriteLine(Days.Friday);

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}