using PeksekEladas;
List<pekaru> Pekaruk = new List<pekaru>();

string[] beolvas = File.ReadAllLines("pekseg.txt");
foreach(string sor in beolvas)
{
    Pekaruk.Add(new pekaru(sor));

}
