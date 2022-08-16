using System.Collections;

ArrayList enKucukSayilar = new ArrayList();
ArrayList enBuyukSayilar = new ArrayList();
ArrayList sayiDizisi = new ArrayList();
ArrayList siraliListe = new ArrayList();
//Listeleri oluşturduk

Console.WriteLine("Sayıları giriniz");


for (int i = 0; i < 20; i++) //klavyeden kaç sayı alacağımı belirttiğim kısım
{
    sayiDizisi.Add(Console.ReadLine());

}
sayiDizisi.Sort();
Console.WriteLine("Yeni Sıralı Liste");
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
    siraliListe.Add(item);
}

for (int i = 0; i < 3; i++) //En küçük ilk 3 sayıyı ekliyorum
{
    enBuyukSayilar.Add(sayiDizisi[i]);
}

for (int i = sayiDizisi.Count - 1; i > sayiDizisi.Count - 4; i--)//en büyük ilk 3 sayıyı ekliyorum
{
    enKucukSayilar.Add(sayiDizisi[i]);
}



//listeleri yazdırıp kontrolünü sağlıyorum
Console.WriteLine("En Büyük sayı listesi: ");
foreach (var item in enKucukSayilar)
{
    Console.Write(item+" ");

}
Console.WriteLine(" ");
Console.WriteLine("En Küçük sayı listesi: ");
foreach (var item in enBuyukSayilar)
{
    Console.Write(item + " ");

}

Console.WriteLine(" ");

//toplam ve ortalama kısmı
int enBuyukToplam = 0;
int enKucukToplam = 0;

Console.WriteLine("**********************************");

for (int i = 0; i < enKucukSayilar.Count; i++)
{
    enKucukToplam += Convert.ToInt32(enKucukSayilar[i]);
}

Console.WriteLine("**********************************");
for (int i = 0; i < enBuyukSayilar.Count; i++)
{
    enBuyukToplam += Convert.ToInt32(enBuyukSayilar[i]);
}

int enBuyukOrtalama = enBuyukToplam / enBuyukSayilar.Count;
int enKucukkOrtalama = enKucukToplam / enBuyukSayilar.Count;

Console.WriteLine("En büyük sayıların ortalaması :" + enKucukkOrtalama);
Console.WriteLine("En büyük sayıların Toplamı :" + enKucukToplam);

Console.WriteLine("En küçük sayıların ortalaması :" + enBuyukOrtalama);
Console.WriteLine("En küçük sayıların Toplamı :" + enBuyukToplam);

int toplamOrtalama = enKucukkOrtalama + enBuyukOrtalama;

Console.WriteLine("Ortalamaların Toplamları : "+ toplamOrtalama);