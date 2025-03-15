int secim;

do
{
    Console.WriteLine("----- Menü -----");
    Console.WriteLine("1- Toplama");
    Console.WriteLine("2- Çıkarma");
    Console.WriteLine("3- Çarpma");
    Console.WriteLine("4- Çıkış");
    Console.Write("Seçiminiz: ");
    secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.WriteLine("Toplama seçildi.");
            break;
        case 2:
            Console.WriteLine("Çıkarma seçildi.");
            break;
        case 3:
            Console.WriteLine("Çarpma seçildi.");
            break;
        case 4:
            Console.WriteLine("Çıkış yapılıyor...");
            break;
        default:
            Console.WriteLine("Geçersiz seçim!");
            break;
    }

} while (secim != 4);
