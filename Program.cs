// See https://aka.ms/new-console-template for more information
//recursive yinelemeli fonksiyon kendi kedni çağıran foınksiyon
//3^4

int result=1;
for(int i =1;i<5;i++)
{
    result=result*3;
}
Console.WriteLine(result);
Islemler instance =new();
Console.WriteLine(instance.Expo(3,4));

//Extention fonksiyonlar 
string ifade ="Nihat Kardelen";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if(sonuc)
    Console.WriteLine(ifade.RemoteWhiteSpaces());
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi ={9,3,6,2,1,5,0};
dizi.SortArray();
dizi.EkranaYazdir();    
int sayi=44;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());

public class Islemler{

    public int Expo(int sayi,int üs)
    {
        if(üs<2)
          return sayi;
        return Expo(sayi,üs-1)*sayi;  
    }
}

public static class Extention{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoteWhiteSpaces(this string param)
    {
        string[] dizi= param.Split(" ");
        return string.Join("",dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach (int item in param)
            Console.WriteLine(item);
    }
    public static bool IsEvenNumber(this int param)
    {
    return param%2==0 ;
    }   
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
}
