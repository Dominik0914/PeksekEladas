using PeksekEladas;
List<pekaru> Pekaruk = new List<pekaru>();

string[] beolvas = File.ReadAllLines("pekseg.txt");
Console.WriteLine("Napi eladások:");
foreach(string sor in beolvas)
{
    pekaru peldany = new pekaru(sor);
    Pekaruk.Add(new pekaru(sor));
    Console.WriteLine(peldany);

}
Console.WriteLine("");
Console.WriteLine("Statisztika:");
int bevetel = Pekaruk.Sum(x =>x.Egysegar*x.EladottDb);
Console.WriteLine($"Pékség teljes napi bevétele: {bevetel} Ft");
pekaru leg = Pekaruk.MaxBy(a=>a.EladottDb);
Console.WriteLine($"Legnagyobb mennyiségben eladott termék: {leg.Nev} ({leg.EladottDb} db)");