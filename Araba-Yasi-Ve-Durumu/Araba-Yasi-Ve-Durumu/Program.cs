using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.Write("Arabanızın yaşını giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        string sonuc = ArabaDurumu(yas);
        Console.WriteLine(sonuc);
    }

    static string ArabaDurumu(int yas)
    {
        if (yas >= 0 && yas < 10)
            return "Arabanız yeni";
        else if (yas >= 10 && yas < 20)
            return "Servise götürmeniz gerekebilir";
        else if (yas >= 20 && yas <= 30)
            return "Arabanız hurdaya çıkabilir";
        else
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
    }
}
//Ekstra: Switch - Case ile Nasıl Yapılır? (Not: Range kullanımı C# 8.0 sonrası desteklenmez, sadece sabit değerler kullanılabilir)
//csharp

//static string ArabaDurumuSwitch(int yas)
//{
//    switch (yas)
//    {
//        case int n when (n >= 0 && n < 10):
//            return "Arabanız yeni";
//        case int n when (n >= 10 && n < 20):
//            return "Servise götürmeniz gerekebilir";
//        case int n when (n >= 20 && n <= 30):
//            return "Arabanız hurdaya çıkabilir";
//        default:
//            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
//    }
//}