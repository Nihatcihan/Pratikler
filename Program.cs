// See https://aka.ms/new-console-template for more information
//datetime ve math kütüphanesi
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second); 

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddMinutes(5));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddYears(4));
Console.WriteLine(DateTime.Now.AddMonths(2));

//DateTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); //ayın kaçı  
Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); //Satuurday
 
Console.WriteLine(DateTime.Now.ToString("MM")); // kaçıncı ay
Console.WriteLine(DateTime.Now.ToString("MMM"));//3 harfli
Console.WriteLine(DateTime.Now.ToString("dd")); // tamamı

Console.WriteLine(DateTime.Now.ToString("yy")); //24
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2024

//MATH kütüphanesi

Console.WriteLine(Math.Abs(-1)); //1 mutlak değer alma
Console.WriteLine(Math.Sin(90));
Console.WriteLine(Math.Cos(45));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); //23 bi üste yuvarlar
Console.WriteLine(Math.Round(22.3)); //22   en yakına
Console.WriteLine(Math.Round(22.7)); //23   en yakına
Console.WriteLine(Math.Floor(22.7)); // aşağıya yuvarlar

Console.WriteLine(Math.Min(44,89));
Console.WriteLine(Math.Max(44,89));

Console.WriteLine(Math.Pow(7,3));
Console.WriteLine(Math.Sqrt(49));
Console.WriteLine(Math.Log(10)); //10un e tabanındaki karşılığı

Console.WriteLine(Math.Exp(3));// e^3 ü verir
Console.WriteLine(Math.Log2(47));

