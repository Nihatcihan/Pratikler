
internal class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Ayşe","Kara",123548,"İnsan kaynakları");
        calisan1.CalisanBilgileri();
       

        Calisan calisan2=new Calisan();
        calisan2.Ad="Nihat";
        calisan2.Soyad="Cihan";
        calisan2.No=123546;
        calisan2.Departman="satış";
        calisan2.CalisanBilgileri();
        Calisan calisan3=new Calisan("Kardelen","cavdar");
        calisan3.CalisanBilgileri();
    }
}
class Calisan
{
    public string Ad;

    public string Soyad;

    public int No;

    public string Departman;

    public Calisan(string ad,string soyad,int no,string departman)
    {
        Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;

    }
    public Calisan(string ad,string soyad)
    {
        Ad=ad;
        this.Soyad=soyad;
    }
    public Calisan(){

    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}",Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
        Console.WriteLine("Çalışanın Numarası: {0}",No);
        Console.WriteLine("Çalışanın Departmanı: {0}",Departman);
    }
}