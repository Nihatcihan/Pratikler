// See https://aka.ms/new-console-template for more information

// out parametreler

using System.Reflection.Metadata;

string sayi="999";
int outSayi;
// double a =int.Parse(sayi); string to int
// Console.WriteLine(a);

bool sonuc =int.TryParse(sayi, out outSayi);
if(sonuc)
{
    Console.Write("Basarili:");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Basarisiz");
}

Metotlar instance =  new Metotlar();
instance.Topla(4,7,out int toplamsonuc);
Console.WriteLine(toplamsonuc);

int aa=1903;
instance.EkranaYazdir(Convert.ToString(aa));
instance.EkranaYazdir(aa);

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam=a+b;
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
}





