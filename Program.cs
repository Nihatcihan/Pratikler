// See https://aka.ms/new-console-template for more information
// dizi tanimlama

string[] renkler = new string[5]; //dizinin boyutu 5

string[] hayvanlar = {"Kedi","Kopek","Kartal"};

int[] dizi;

dizi = new int[5];

//dizilere değer atama ve erişim 
renkler[0] ="Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[2]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//Döngüler dizi kullanımı
// klavyeden girilen n tane sayının ortalaması

Console.WriteLine("Lutfen dizinin eleman sayisini giriniz");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for(int i=0; i<diziUzunlugu; ++i)
{
    Console.Write("Lutfen {0}. sayiyi giriniz: ",i+1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());

}
int toplam =0;

foreach (var sayi in sayiDizisi)
{
    toplam +=sayi;    
}
Console.WriteLine("ortalama" + toplam/diziUzunlugu);
