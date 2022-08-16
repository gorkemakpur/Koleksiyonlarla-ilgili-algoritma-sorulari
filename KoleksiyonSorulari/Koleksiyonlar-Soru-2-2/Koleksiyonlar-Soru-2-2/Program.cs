int[] sayiDizisi = new int[20];
int[] enBuyukSayilar = new int[3];
int[] enKucukSayilar = new int[3];


for (int i = 0; i < 20; i++)
{
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Array.Sort(sayiDizisi); 


//sayı dizisi küçükten büyüğe
Console.Write("Küçükten büyüğe Sayı Dizisi:");
for (int i = 0; i < sayiDizisi.Length; i++)
{
    Console.Write(sayiDizisi[i]+",");
}
Console.WriteLine(" ");



//En büyük sayılar
int enBuyukSayiToplam = 0;
int enBuyukSayiSayac = 0;
for (int i = sayiDizisi.Length; i > sayiDizisi.Length-3; i--) 
{
    enBuyukSayilar[(sayiDizisi.Length-i)] = sayiDizisi[i-1];
    enBuyukSayiToplam += enBuyukSayilar[sayiDizisi.Length-i];
    enBuyukSayiSayac++;
}

//En Küçük Sayılar
int enKucukSayiToplam = 0;
int enKucukSayiSayac = 0;
for (int i = 0; i < 3; i++) 
{
    enKucukSayilar[i] = sayiDizisi[i];
    enKucukSayiToplam += enKucukSayilar[i];
    enKucukSayiSayac++;
}
double kucukOrtalama = enKucukSayiToplam / enKucukSayiSayac;
double buyukOrtalama = enBuyukSayiToplam / enBuyukSayiSayac;

Console.WriteLine("En küçük 3 sayınızın ortalaması : " + kucukOrtalama + " Sayılarınızın toplamı ise : " + enKucukSayiToplam);

Console.WriteLine("En büyük 3 sayınızın ortalaması : " + buyukOrtalama + " Sayılarınızın toplamı ise : " + enBuyukSayiToplam);
double kb = kucukOrtalama + buyukOrtalama;
Console.WriteLine("iki dizinin ortalama toplamları ise : "+ kb);
