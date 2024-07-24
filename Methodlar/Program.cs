


//Geriye Döndürülmeyen bir Void Method
Lyrics();

static void Lyrics()
{
    Console.WriteLine("Ben zaten ger acının tiryakisi olmuşum");
}



 // Geriye Tam Sayı Döndüren bir Method
PrintRandom();

static void PrintRandom()
{
    Random rnd = new Random();
    int number = rnd.Next();
    Console.WriteLine("random sayını -> " + number + " 2'ye bölümünden kalan -> " + (number % 2));

}

Console.WriteLine("---------------------------------------------------");

//Parametre Alan ve Geriye Değer Döndüren bir Method

int result = MultiplicationNumbers(5, 3);
Console.WriteLine("Çarpım: " + result);

static int MultiplicationNumbers(int a, int b)
{

    return a * b;
}

Console.WriteLine("---------------------------------------------------");
// Parametre Alan ve Geriye Değer Döndürmeyen bir Method

Console.WriteLine("İsminizi giriniz:");
string name = Console.ReadLine();

Console.WriteLine("Soy isminizi giriniz:");
string surname = Console.ReadLine();


GreetUsar(name,surname);


static void GreetUsar(string name, string surname)
{
    Console.WriteLine($"Hoşgeldiniz {name} {surname}");
}