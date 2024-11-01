// See https://aka.ms/new-console-template for more information
// while
// 1 den başlayarak consoledan girilen sayıya kadar sayı dahil ortalama hesaplayıo konsola yazdır
// Console.Write("Lutfen bir sayi giriniz:");
// int sayi= int.Parse(Console.ReadLine());
// int sayac=1;
// int toplam=0;
// while (sayac<=sayi)
// {
//     toplam+= sayac;
//     ++sayac;

// }
// Console.WriteLine(toplam/sayi);

// // a'dan z'ye kadar tüm harfleri consola yazdir

// char character= 'a';
// while (character<'z')
// {
//     Console.Write(character);
//     ++character;
// }
Console.WriteLine("*** For Each****");

string[] arabalar = {"BMW","Ford","Toyota","Nissan","Ferrari"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}