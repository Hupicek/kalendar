//do pole si ulozime kazdy mesic 1-12, 1 leden, 12 prosinec zaroveň ošetří program proti bugům
string[] mesice = {"leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec"};
//rekne uzivateli aby napsal cislo  a ulozi ho
Console.WriteLine("napis cislo mesice (1-12)");
var zadanecislo = Convert.ToInt32(Console.ReadLine()); //4
//odecte a pricte mesic pred a po a ulozi do promene
int soucasny = zadanecislo - 1; //duben=3
int pred = zadanecislo - 2; //březen=2
int za = zadanecislo;
//vypsani mesicu a osetreni proti chybam
if (zadanecislo == 1)
{
    Console.WriteLine("mesic pred je prosinec " + "      mesic co jsi vybral je " + (mesice[soucasny]) + "      mesic po je " + (mesice[za]));
}
else if (zadanecislo == 12)
{
    Console.WriteLine("mesic pred je " + (mesice[pred]) + "      mesic co jsi vybral je " + (mesice[soucasny]) + "      mesic po je leden");
}
else
{
    Console.WriteLine("mesic pred je " + (mesice[pred]) + "      mesic co jsi vybral je " + (mesice[soucasny]) + "      mesic po je " + (mesice[za]));
}
//zepta se jestli chce vypsat vsechny mesice
Console.WriteLine("chcete vypsat vsechny mesice? (y/n)");
string? vypsat = Console.ReadLine();
if (vypsat == "y")
{
    foreach (string pole in mesice)
    {
        Console.WriteLine(pole);
    }
}
 