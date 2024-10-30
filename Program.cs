// See https://aka.ms/new-console-template for more information
// try
// {
//     Console.WriteLine("Bir sayi giriniz");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Girmis oldugunuz sayi:" + sayi);

// }
// catch(Exception ex)
// {
// Console.WriteLine("Hata:" + ex.Message.ToString());

// }
// finally
// {
//     Console.WriteLine("İslem tamamlandi");
// }

// try
// {
//     int a = int.Parse(null);
// }
// catch(ArgumentNullException ex)
// {
// Console.WriteLine("Bos deger girdiniz");
// Console.WriteLine(ex);

// }

// try
// {
//     int a = int.Parse("test");
// }
// catch(ArgumentNullException ex)
// {
// Console.WriteLine("Bos deger girdiniz");
// Console.WriteLine(ex);

// }
// catch(FormatException ex)
// {
// Console.WriteLine("veri tipi uygun degil");
// Console.WriteLine(ex);

// }
try
{
    Int a = int.Parse("-20000000000");
}
catch(ArgumentNullException ex)
{
Console.WriteLine("Bos deger girdiniz");
Console.WriteLine(ex);
}
catch(FormatException ex)
{
Console.WriteLine("veri tipi uygun degil");
Console.WriteLine(ex);
}
catch(OverflowException ex)
{
Console.WriteLine("cok kucuk ya da cok buyuk bir deger girdiniz");
Console.WriteLine(ex);
}

finally
{
    Console.WriteLine("İslem basariyla tamamlandi");
}