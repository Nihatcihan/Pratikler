// See https://aka.ms/new-console-template for more information
string degisken="zaman sinekleri";
string degisken2="zaman sinekleri";

//Lenght
Console.WriteLine(degisken.Length);

//ToUpper, ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat
Console.WriteLine(String.Concat(degisken," ÇS"));

//Compare CompareTo
Console.WriteLine(degisken.CompareTo(degisken2)); //1 -1 0
Console.WriteLine(String.Compare(degisken,degisken2,true)); //büyük küçük harfi aynı görür
Console.WriteLine(String.Compare(degisken,degisken2,false)); //büyük küçük harfi aynı duyarlıdır

//Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("sinekleri"));
Console.WriteLine(degisken.StartsWith("sinekleri"));

//IndexOf
Console.WriteLine(degisken.IndexOf("sin"));
Console.WriteLine(degisken.IndexOf("ÇS"));
Console.WriteLine(degisken.LastIndexOf("r")); // son r harfinin indexini verir

//Insert
Console.WriteLine(degisken.Insert(0,"ÇS-Farazi: "));

//PadLeft PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'+') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,3));

//Replace
Console.WriteLine(degisken.Replace("sinekleri", "Kırıntıları"));
Console.WriteLine(degisken.Replace(" ", "*"));

//Split
// Console.WriteLine(degisken.Split(' '));

//Substring
Console.WriteLine(degisken.Substring(4)); 
Console.WriteLine(degisken.Substring(4,8));
 



