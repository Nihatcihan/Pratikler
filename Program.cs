internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(((int)Gunler.Pazar)+1);
        int sicaklik=32;

        if (sicaklik <= (int)HavaDurumu.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını beklelim");

        else if(sicaklik>= (int)HavaDurumu.Sıcak)
            Console.WriteLine("Dışarıya çıkmak çok sıcak bir gün");

        else if(sicaklik>= (int)HavaDurumu.Normal && sicaklik<= (int)HavaDurumu.CokSıcak)
            Console.WriteLine("Hadi dışarıya çıkalım");
    }   
}
enum Gunler
{
    Pazartesi,
    Sali,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar

}
enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sıcak=25,
    CokSıcak=30
}