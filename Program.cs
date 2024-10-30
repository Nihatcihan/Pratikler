// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("deger");
String degisken = " ";
byte  b = 5;    // 1 byte 0-255
sbyte c = 5;    // 1 byte -128 127

short s = 5;    // 2 byte -32678 32677
ushort us = 5;  // 2 byte   0 65365

Int16 i16= 2;   // 2 byte reel sayilar
int i =2;       // 4 byte
Int32 i32 =2;   // 4 byte
Int64 i64=2;    // 8 byte
uint ui=2;      // 4 byte
long l=4;       // 8 byte
ulong ul=4;     // 8 byte

float f=5;      // 4 byte
double d =5;    // 8 byte
decimal de =5;  // 16 byte

char ch= '2';    // 2 byte
string str ="kardelen"; // sinirsiz

bool b1 =true;
bool b2 =false;

DateTime dt =DateTime.Now;
Console.WriteLine(dt);
 
 object o1 ="x";
 object o2 ="y";
 object o3 =4;
 object o4 =4.3;

 // string ifadeler

 string str1 = string.Empty;
 string ad="kardelen";
string soyad="cavdar";

string tamisim = ad + " " + soyad;

//integer tanimlama şekilleri

int integer1 =5;
int integer2 =3;
int integer3 = integer1 * integer2;

// Boolean
bool bool1 =10>2;

// değişken dönüşmleri

string str20 ="20";
int int20 =20;

string yeniDeger =str20 + int20.ToString(); // çıktısı 2020

Console.WriteLine(yeniDeger);

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // çıktısı 40

// int22 =int20 + int.Parse(str20); // çıktısı 40 ama çalışmadı (parse stringi integer a çeviriyor)

// datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // tarihi gün ay yıl olarak getir
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy"); // tarihi gün ay yıl olarak getir
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm"); // tarihi gün ay yıl olarak getir
Console.WriteLine(hour);



 

