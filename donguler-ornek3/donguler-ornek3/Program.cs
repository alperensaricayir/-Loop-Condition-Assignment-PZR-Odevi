int sayi;
int toplam = 0;

do
{
    Console.WriteLine("Sayı giriniz (Bitirmek için 0 giriniz): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
} while (sayi != 0); // 0 girilene kadar devam et

Console.WriteLine("Toplam: " + toplam);
