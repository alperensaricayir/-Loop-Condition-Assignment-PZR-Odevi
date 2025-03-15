int sayi;
int toplam = 0;

Console.WriteLine("Sayı giriniz (Bitirmek için 0 giriniz): ");
sayi = Convert.ToInt32(Console.ReadLine()); // İlk sayı

while (sayi != 0) // 0 girilmediği sürece devam et
{
    toplam += sayi; // Sayıyı toplama ekle
    Console.WriteLine("Sayı giriniz (Bitirmek için 0 giriniz): ");
    sayi = Convert.ToInt32(Console.ReadLine()); // Yeni sayı
}

Console.WriteLine("Toplam: " + toplam);
