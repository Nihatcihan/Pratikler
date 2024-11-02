// See https://aka.ms/new-console-template for more information
//erisim_belirteci  geri_donustipi metot_adi (parametrelistesi/arguman)
// {
    // komutlar;
// }

int a=2;
int b=3;
Console.WriteLine(a+b);
int sonuc =topla(a,b);
Console.WriteLine(sonuc); 

static int topla (int deger1, int deger2)
{
    return (deger1+deger2);
}
metotlar ornek= new metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));
int deger =ornek.arttirvetopla(a,b);
ornek.EkranaYazdir(Convert.ToString(deger));


class metotlar 
{
   public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int arttirvetopla(int deger1,int deger2)
    {
        deger1++;
        deger2++;
        return(deger1+deger2);
    }
}