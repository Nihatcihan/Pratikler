// See https://aka.ms/new-console-template for more information

//ekrana girilen sayıya kadar olan tek sayıları ekran yazdır
// Console.Write("lutfen bir sayi giriniz: ");
// int sayac =int.Parse(Console.ReadLine());
// for (int i =1; i <= sayac; ++i) 
// {
// // komutlar
//     if(i%2 == 1)
//     Console.WriteLine(i);
// }
// 1 ile 1000 arasındaki tek ve çift sayıları toplamak
int tek=0;
int cift=0;
for (int i =1; i<=1000; ++i)
{
    if(i%2==1)
    {
        tek=tek+i; // tek +=i yazılabilir
    }
    else if(i%2==0)
    {
        cift=cift+i;
    }
}
    Console.WriteLine("Tek sayilar toplami:"+tek);
    Console.WriteLine("Cift sayilar toplami:"+cift);
