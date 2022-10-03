// See https://aka.ms/new-console-template for more information
/* »Užduotis: Konvertuoti EUR į USD, PLN, BYR
 * »Naudoti 2 masyvus
 * »Su valiutų pavadinimais (string[])
 * »Su valiutų kursu (decimal[]) */


string[] valiuta = new string[] { "USD", "PLN", "BYR" };
decimal[] kursas = new decimal[] { 1.00M, 4.73M, 2.52M };

Console.WriteLine("Koki kieki EUR norite konvertuoti?");
decimal kiekis = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("I kokia valiuta konvertuosite: [1] USD, [2] PLN, [3] BYR");
int indeksas = Int32.Parse(Console.ReadLine());
Console.WriteLine($" jus gausite {Konvertavimas(kursas, kiekis, indeksas)} {valiuta[indeksas -1]}");
static decimal Konvertavimas(decimal[] kursas, decimal kiekis, int indeksas) => kiekis * kursas[indeksas-1];
