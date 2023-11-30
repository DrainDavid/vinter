// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;


while (true)
{

    Console.WriteLine("Tjena din dräng");
    Console.WriteLine("Välkommen till gammla Nti");
    Console.WriteLine("Du behöver klara massa uppifter och slagsmål för att överleva här");

    Console.Write("Väljer du att ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("gå in");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(" eller");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" inte");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("");
    string resp = "";
    while (resp != "inte" && resp != "gå in")
    {
        resp = Console.ReadLine().ToLower();
    }

    if (resp == "inte")
    {
        Console.WriteLine("du valde fel börja om");
        Console.WriteLine("tryck valfri knapp för att starta om");
        Console.ReadLine();
        Console.Clear();
    }
    else if (resp == "gå in")
    {
        Console.WriteLine("Välkommen till NTI");
        RestOfTheGame();
    }
}

int herohp = 100;

void RestOfTheGame()
{
    Console.WriteLine("Du går in lite längre och ser Sus hjärtat av NTI, hon spelar en viktig roll för att du ska överleva.");
    Console.WriteLine("Sus varnar dig att de finns mycket farliga varelser i närheten ");
    Console.WriteLine("Sus vill hjälpa dig behålla gamla Nti och ger dig ett val");
    Console.WriteLine("Hon säger vill du ha en enegidryck eller macka");



    Console.ReadLine();
}




Console.ReadLine();