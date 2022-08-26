internal class Program
{
    private static void Main(string[] args)
    {
        // Datatime
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);
        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddYears(5));

        //Datetime format 
        Console.WriteLine(DateTime.Now.ToString("dd")); //26
        Console.WriteLine(DateTime.Now.ToString("ddd")); // cum
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Cuma

        Console.WriteLine(DateTime.Now.ToString("MM")); //08
        Console.WriteLine(DateTime.Now.ToString("MMM")); // Agu
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //Ağustos

        Console.WriteLine(DateTime.Now.ToString("yy")); //22
        Console.WriteLine(DateTime.Now.ToString("yyy")); // 2022
        Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

        // Math Kütüphanesi 

        Console.WriteLine(Math.Abs(-25)); // 25
        Console.WriteLine(Math.Sin(10)); //sinus
        Console.WriteLine(Math.Ceiling(22.3)); // 22.3'den büyük ilk sayı 
        Console.WriteLine(Math.Round(22.3)); // en yakın tam sayı
        Console.WriteLine(Math.Floor(22.3)); // 22.3'den küçük ilk tamsayı

        Console.WriteLine(Math.Min(128,10));
        Console.WriteLine(Math.Max(126,9));
        Console.WriteLine(Math.Pow(3,4)); //3^4
        Console.WriteLine(Math.Sqrt(9)); //Karakök
        Console.WriteLine(Math.Log(9)); //log
        Console.WriteLine(Math.Exp(3)); // e^3
        Console.WriteLine(Math.Log10(10)); // log10 tabanında karşılığı 
        Console.WriteLine(Math.Equals(21,21));



    }
}