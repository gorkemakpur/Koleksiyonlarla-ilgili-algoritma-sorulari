using System.Collections;

Console.Write("Cümlenizi Giriniz: ");
string cumle = Console.ReadLine();
string sesliHarf = "aeıioöuüAEIİOÖUÜ";
ArrayList cumleHarfler = new ArrayList();


for (int i = 0; i < cumle.Length; i++)
{
    for (int j = 0; j < sesliHarf.Length; j++)
    {
        if ((cumle[i]) == (sesliHarf[j]))
        {
            cumleHarfler.Add(sesliHarf[j]);
        }
    }
}
Console.Write("Dizi içerisindeki sesli harfler şunlar: ");
int sayac = 1;
foreach (var item in cumleHarfler)
{   
    Console.WriteLine(sayac+". sesli harf = "+item);
    sayac++;
}


