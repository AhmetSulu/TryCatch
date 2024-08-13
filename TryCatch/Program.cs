using System;

class Program
{
    static void Main()
    {
        while (true) // Sonsuz döngü başlatılıyor
        {
            // Kullanıcıdan veri al
            Console.Write("Lütfen bir sayı giriniz (Çıkmak için 'q' yazın): ");
            string input = Console.ReadLine();

            // Kullanıcı 'q' girerse döngüden çık
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            try
            {
                // Girişi sayıya çevir
                double number = Convert.ToDouble(input);

                // Sayının karesini hesapla
                double square = number * number;

                // Sonucu ekrana yazdır
                Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
            }
            catch (FormatException)
            {
                // Hatalı giriş olduğunda gösterilecek mesaj
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            finally
            {
                // Her durumda çalışacak mesaj
                Console.WriteLine("Giriş işlemi tamamlandı.");
            }
        }
    }
}
