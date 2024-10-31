// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

// expression klontrol etmek istenilen kosul
switch (month)
{
    case 1:
    Console.WriteLine("Ocak ayindasiniz");
        break;
    case 2:
    Console.WriteLine("Subat ayindasiniz");
        break;
    case 10: 
    Console.WriteLine("Ekim ayindasiniz");
        break;
    default: 
    Console.WriteLine("Yanlis veri girdiniz");                         
        break;     //koşulların hiçbiri uymazsa bu kısım çalışır
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kis mevsimindesiniz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimindesiniz");
        break;
    default:
    break;
    
}