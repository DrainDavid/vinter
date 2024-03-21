// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

 // Starten av spelet där man får svara på frågor 
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

//skapar en void så om man svarar fel kan man inte komma vidare i spelet

void RestOfTheGame()
{
    int herohp = 100;
    Console.WriteLine("Du går in lite längre och ser Sus hjärtat av NTI, hon spelar en viktig roll för att du ska överleva.");
    Console.WriteLine("Sus varnar dig att de finns mycket farliga varelser i närheten ");
    Console.WriteLine("Sus vill hjälpa dig behålla gamla Nti och ger dig ett val");
    Console.WriteLine("Hon säger vill du ha en energidryck eller macka");
    string val = Console.ReadLine().ToLower();
    if(val == "macka")
    {
        Console.WriteLine("Sus säger att hon är stolt och ger dig 20 extra hp");
        herohp += 20;
        Console.WriteLine($"Ditt hp är nu {herohp}");
    }
    
    else if(val == "energidryck")
    {
      Console.WriteLine("Sus säger att hon är inte är stolt och ger dig bara 10 extra hp");
        herohp += 10;
        Console.WriteLine($"Ditt hp är nu {herohp}");  
    }

     Console.WriteLine("Sus säger att de finns en  boss i närheten");
     Console.WriteLine("Sus säger att  bossen har tagit godis från henne");
     Console.WriteLine("Hon säger att du måste slakta den och som belöning får du ett matkort");
     Console.WriteLine("Hon leder dig vägen till 400 vånigen ");
     Console.WriteLine("Tekinkarnas värsta fiende estetarna");
     Console.WriteLine("Du ser en grupp estetarna gömma nått du gå fram och flyttar på de");
     Console.WriteLine("Där ser du Nti hjärtat mackerspace de har stulit mackerspace och du utamnar de till en duel"); 
    
    int villianhp = 100;
    string heroname = "du";
    string villianname = "Estetarna";

    Random generator = new Random();

    // Kör striden så länge båda lever
    while (herohp > 0 && villianhp > 0) 
    {
    Console.WriteLine("\n-----===Ny Runda===-----");
    Console.WriteLine($"{heroname}: {herohp}  {villianname}: {villianhp}");

    // Gör skada på fienden 
    int heroskada = generator.Next(20);
    villianhp -= heroskada;                            
    villianhp = Math.Max(0, villianhp);
    Console.WriteLine($"{heroname} gör {heroskada} skada på {villianname}");

    // gör skada på hero
    int villianskada = generator.Next(20);
    herohp -= villianskada;
    herohp = Math.Max(0, herohp);
    Console.WriteLine($"{villianname} gör {villianskada} skada på dig");
    Console.WriteLine(" Tryck på valfri kanpp för att fortsätta");
    Console.ReadKey();
    }
   Console.WriteLine("--------Striden är över--------");
    // Om man man vinner,förlorar eller om de blir ovagjort ska de komma olika svar eller om man behöver starta om
if (herohp == 0 && villianhp == 0)
{
  Console.WriteLine("De blev ingen vinare trycka valfri knapp för att börja om försök bättre nästa gång.");  
}
else if (herohp == 0)
{
 Console.WriteLine($"{villianname} Kanske Vann tryck valfri knapp för att börja om försök bättre nästa gång");   
}
else if (villianhp == 0)
{
Console.WriteLine($"{heroname}  vann");
Console.WriteLine("Sus kommer fram till dig och tackar dig");
Console.WriteLine("Hon bär up macker space till den räta platsen");
Console.WriteLine("Hon ger dig matkortet och säger till dig att dra till subway och Nti kommer vara lika bra som förr igen.");
}


    Console.ReadLine();
}




Console.ReadLine();