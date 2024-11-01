// See https://aka.ms/new-console-template for more information

//sort

int[] sayidizisi = {23,12,4,86,72,11,17};

Console.WriteLine("*****Sirasiz Liste*****");
foreach (var sayi in sayidizisi)
    Console.Write(sayi+" ");
Console.WriteLine(" ");

Console.WriteLine("*****Sirali Liste*****");
Array.Sort(sayidizisi);

foreach (var sayi in sayidizisi)
        Console.Write(sayi+" ");

//Clear
Console.WriteLine(" ");

Console.WriteLine("*****Array Clear*****");

Array.Clear(sayidizisi,2,2); // 2. elemandan sonra 2 elamını sıfırla
foreach (var sayi in sayidizisi)
        Console.Write(sayi+" ");

//reverse
Console.WriteLine(" ");
Console.WriteLine("*****Array Reverse*****");

Array.Reverse(sayidizisi);
foreach (var sayi in sayidizisi)
        Console.Write(sayi+" ");
//IndexOf
Console.WriteLine(" ");
Console.WriteLine("*****Array IndexOf*****");
Console.WriteLine(Array.IndexOf(sayidizisi,23)); // 23 hangi satırdadır

//REsize
Console.WriteLine(" ");
Console.WriteLine("*****Array Resize*****");
Array.Resize<int>(ref sayidizisi,9);
sayidizisi[8] =99;

foreach (var sayi in sayidizisi)
        Console.Write(sayi+" ");

