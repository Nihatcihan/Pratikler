﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
        Calisan calisan =new("Nihat","Cihan","Scada");
        Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
        
        Console.WriteLine(Islemler.Topla(100,1));
        Console.WriteLine(Islemler.Cikar(100,1));

    }
}

class Calisan
{
    private static int calisanSayisi;
public static int CalisanSayisi { get => calisanSayisi; }

string Isim;
string Soyisim;

string Departman;

    public Calisan(string isim, string soyisim, string departman)
    {
         this.Isim= isim;
         this.Soyisim =soyisim;
         this.Departman =departman;
         calisanSayisi++;
    }
    
    static Calisan()
    {
        calisanSayisi =0;

    }

}

static class Islemler 
{
    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1,int sayi2)
    {
        return sayi1-sayi2;
    }
}
