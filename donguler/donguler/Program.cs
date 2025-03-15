using System;

class Program
{
    static void Main()
    {
        int sayac = 0;

        Console.WriteLine("While Döngüsü:");
        while (sayac < 3)
        {
            Console.WriteLine("Sayaç: " + sayac);
            sayac++;
        }

        Console.WriteLine("\nDo-While Döngüsü:");
        sayac = 0;
        do
        {
            Console.WriteLine("Sayaç: " + sayac);
            sayac++;
        } while (sayac < 3);
    }
}
//Not:
//While: Önce kontrol, sonra çalışır.
//Do - While: Önce çalışır, sonra kontrol eder. En az 1 kez çalışır.

//3. Ödev: Döngüler (Araştırma Konusu)  

//## **1. Döngüler Nedir?**  
//Döngüler, bir işlemi veya işlemler grubunu belirli bir koşul sağlandığı sürece tekrar tekrar çalıştırmamızı sağlar. Programlamada en çok kullanılan yapılar arasında yer alır.  

//Bu ödevde **"while"** ve **"do-while"** döngülerini araştırarak, çalışma mantıklarını, farklarını ve örneklerini öğreneceğiz.  

//---

//## **2. While Döngüsü**  

//### **Tanımı ve Çalışma Mantığı:**  
//- **While döngüsü** **önce koşulu kontrol eder**, eğer koşul doğruysa döngü çalışır.  
//- Eğer koşul baştan **yanlışsa**, döngü **hiç çalışmaz**.  
//- Koşul her döngüde tekrar kontrol edilir.  

//### **Genel Yazımı (Söz Dizimi):**  
//```csharp
//while (koşul)
//{
//    // Çalışacak kodlar
//}
//```  

//### **Kod Örneği: (1'den 5'e kadar sayıları yazdırma)**  
//```csharp
//int i = 1; // Başlangıç değeri

//while (i <= 5) // Koşul
//{
//    Console.WriteLine(i); // Ekrana yazdır
//    i++; // i değerini artır
//}
//```  

//### **Çıktısı:**  
//```
//1
//2
//3
//4
//5
//```  

//### **Dikkat Edilecekler:**  
//-Koşul en başta kontrol edilir.  
//- Eğer `i` değeri 1 yerine 6 olsaydı, döngü **hiç çalışmazdı**.  

//---

//## **3. Do-While Döngüsü**  

//### **Tanımı ve Çalışma Mantığı:**  
//- **Do-while döngüsü** **önce işlemi yapar**, **sonra koşulu kontrol eder**.  
//- Koşul **yanlış olsa bile en az 1 kere** çalışır.  
//- Koşul sağlandığı sürece döner.  

//### **Genel Yazımı (Söz Dizimi):**  
//```csharp
//do
//{
//    // Çalışacak kodlar
//} while (koşul) ;
//```  

//### **Kod Örneği: (1'den 5'e kadar sayıları yazdırma)**  
//```csharp
//int i = 1; // Başlangıç değeri

//do
//{
//    Console.WriteLine(i); // Ekrana yazdır
//    i++; // i değerini artır
//} while (i <= 5); // Koşul
//```  

//### **Çıktısı:**  
//```
//1
//2
//3
//4
//5
//```  

//### **Dikkat Edilecekler:**  
//-Döngü gövdesi** en az 1 kere** çalışır.  
//- Koşul, gövdenin sonunda kontrol edilir.  

//---

//## **4. While ve Do-While Arasındaki Farklar**  

//| Özellik                          | While Döngüsü                                   | Do-While Döngüsü                                |
//|----------------------------------|-------------------------------------------------|------------------------------------------------|
//| **Koşul Kontrol Yeri**             | Döngü başında                                  | Döngü sonunda                                   |
//| **En Az Bir Kez Çalışma Garantisı**| Hayır (Koşul yanlışsa hiç çalışmaz)             | Evet (Koşul yanlış olsa bile 1 kere çalışır)   |
//| **Kullanım Amacı**                 | Önce kontrol edilmesi gereken durumlarda       | En az 1 kez çalışması gereken durumlarda      |

//---

//## **5. Do-While'ın Özel Durumu (Örnek)**  

//```csharp
//int i = 10;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 5);
//```

//### **Çıktısı:**  
//```
//10
//```

//**Açıklama:**
//-Koşul(i < 5) * *yanlış * *olmasına rağmen, **işlem en az 1 kere** çalıştığı için "10" ekrana yazdırılır.  

//---

//## **6. Sonuç**  

//- **While döngüsü** koşul sağlanırsa çalışır, baştan yanlışsa çalışmaz.  
//- **Do-while döngüsü** her durumda en az bir kere çalışır, sonra koşulu kontrol eder.  
//- Programlamada her iki döngü de uygun yerde kullanılır.  

