
//Intro();

string sentence = "My name is Engin Demiroğ";

var result = sentence.Length;
var result2 = sentence.Clone();//yeni bir referans oluşturdu
sentence = "my name is derin demiroğ";

bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("my name");

var result5 = sentence.IndexOf("name");//3 döndürür 3. karakter
var result6 = sentence.IndexOf(" ");//2 döndürür 2. karakter
var result7 = sentence.LastIndexOf(" ");//16 döndürür 16. karakter
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,5);

Console.WriteLine(result13);

static void Intro()
{
    string city = "ankara";
    Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "istanbul";
    string result = city + city2;
    Console.WriteLine(result);
    Console.WriteLine(String.Format("{0} {1}", city, city2));
}