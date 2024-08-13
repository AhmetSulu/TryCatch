using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan veri alır
        Console.Write("Lütfen bir sayı giriniz: ");
        string input = Console.ReadLine();

        try
        {
            // Girişi sayıya çevirir
            double number = Convert.ToDouble(input);

            // Sayının karesini hesaplar
            double square = number * number;

            // Sonucu ekrana yazdırır
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
        }
        catch (FormatException)
        {
            // Hatalı giriş ekanı
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
        finally
        {
            // Her durumda çalışacak mesaj
            Console.WriteLine("Program sona erdi.");
        }
    }
}
