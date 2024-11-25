// See https://aka.ms/new-console-template for more information

using System.Collections;

ArrayList liste = new ArrayList();
// liste.Add("Kardelen");
// liste.Add(2);
// liste.Add(true);
// liste.Add('B');
 

//  foreach (var item in liste)
//     Console.WriteLine(item);
 
 // AddRange birden fazla eleman ekleme

 Console.WriteLine("****AddRange****");
 string[] renkler={"kırmızı","siyah","beyaz","turuncu","bordo"};
 List<int> sayilar= new List<int>(){44,8,55,2,15,74,1,3,45,84,99,1456,74568552};
//  liste.AddRange(renkler);
 liste.AddRange(sayilar);

 foreach (var item in liste)
    Console.WriteLine(item);

//Sort
Console.WriteLine("*****Sort*****");
liste.Sort();
 foreach (var item in liste)
    Console.WriteLine(item);

//BinarySearch
Console.WriteLine("***BinarySearch");
Console.WriteLine(liste.BinarySearch(99));

//Reverse
Console.WriteLine("****reverse*****");
liste.Reverse();

foreach (var item in liste)
    Console.WriteLine(item);
    