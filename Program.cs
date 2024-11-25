// See https://aka.ms/new-console-template for more information

List<int> sayiListesi = new List<int>();

sayiListesi.Add(1);
sayiListesi.Add(2);
sayiListesi.Add(48);
sayiListesi.Add(27456);
sayiListesi.Add(123);
sayiListesi.Add(215);

List<string> renkListesi = new List<string>();
renkListesi.Add("sari");
renkListesi.Add("beyaz");
renkListesi.Add("siyah");
renkListesi.Add("kahverengi");
renkListesi.Add("mavi");

foreach (int sayi in sayiListesi)
    Console.WriteLine(sayi);


foreach (string renk in renkListesi)
    Console.WriteLine(renk);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

//listeden eleman çıkarma

sayiListesi.Remove(123);
renkListesi.Remove("sari");


sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));
sayiListesi.RemoveAt(3);
renkListesi.RemoveAt(3);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

//liste içerisinde arama

if(renkListesi.Contains("siyah"))
    Console.WriteLine("siyah beyaz");
    
//eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("kahverengi"));
    
//diziyi listeye çevirme

string[] hayvanlar ={"kedi","kopek","kus","kurt"};
List<string> hayvanListesi = new List<string>(hayvanlar);

hayvanListesi.ForEach(hayvan=> Console.WriteLine(hayvan));

//listeyi temizleme
hayvanListesi.Clear();
List<kullanicilar> kullaniclarListesi = new List<kullanicilar>();

kullanicilar kullanici1 = new kullanicilar();
kullanici1.Isim="Kardelen";
kullanici1.Soyisim= "cavdar";
kullanici1.Yas = 27;

kullanicilar kullanici2 = new kullanicilar();
kullanici2.Isim="Nihat";
kullanici2.Soyisim= "Cihan";
kullanici2.Yas = 27;

kullaniclarListesi.Add(kullanici1);
kullaniclarListesi.Add(kullanici2);

List<kullanicilar> yeniListe = new List<kullanicilar>();
yeniListe.Add(new kullanicilar(){
 Isim="Cagri",
 Soyisim="Sinci",
 Yas = 34

});

foreach (var kullanici in kullaniclarListesi)
{
    Console.WriteLine("Kullanıcı adı"+ kullanici.Isim);
    Console.WriteLine("Kullanıcı soyadı"+ kullanici.Soyisim);
    Console.WriteLine("Kullanıcı yası"+ kullanici.Yas);
}
yeniListe.Clear();

public class kullanicilar{     private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}