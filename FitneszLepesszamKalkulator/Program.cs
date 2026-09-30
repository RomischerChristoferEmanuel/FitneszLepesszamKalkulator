//2.feladat
List<int> lepesszamok = new List<int>();
Console.WriteLine("=== Heti Lépésszám Rögzítése ===");
for (int i=0; i < 5; i++)
{
    Console.Write($"{i+1}. nap lépésszáma:  ");
    int megadott=int.Parse(Console.ReadLine() );
    lepesszamok.Add(megadott);

}
//3.feladata

double osszeg = 0;
for (int i = 0; i < 5; i++)
{
    osszeg += lepesszamok[i];
}
//osszeg=lepesszamok.Sum();
double atlag = osszeg/lepesszamok.Count;

//4.feladat
string kiir = "";
if (atlag >= 10000) kiir=("Kiváló forma, teljesítetted a célt!");
else if (atlag >= 7000) kiir=("Átlagos aktivitás, jó úton jársz.");
else kiir=("Kevés mozgás, több aktivitás szükséges!");

//5.feladat
Console.WriteLine("Adatok feldolgozása...\n========================================\nRögzített napi lépésszámok:");
for(int i = 0; i <= lepesszamok.Count;i++)
{
    Console.WriteLine($"\t- {i+1}. nap: {lepesszamok[i]} lépés");
}
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Összes lépésszám: {osszeg} lépés");
Console.WriteLine($"Napi átlagos lépészám: {atlag:0f} lépés");
Console.WriteLine($"Heti értékelés: {kiir}");
Console.WriteLine("========================================");