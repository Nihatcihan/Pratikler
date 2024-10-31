// See https://aka.ms/new-console-template for more information


int time = DateTime.Now.Hour;
if (time>=6 && time <11)
    Console.WriteLine("Gunaydin");
else if (time <= 18)
    Console.WriteLine("Iyi gunler");
else 
    Console.WriteLine("Iyi geceler");

    string sonuc = time <=18 ? "Iyi gunler" : "Iyi geceler";
        Console.WriteLine(sonuc);

    sonuc = time >= 6 && time < 11 ? "Gunaydin" : time <= 18 ? "Iyi gunler" : "Iyi Geceler";
        
        Console.WriteLine(sonuc);

