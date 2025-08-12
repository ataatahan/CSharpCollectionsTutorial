using System.Collections;

namespace koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodlar

            /*

            * Koleksiyonlarda sık kullanılan temel metotlar:

              Add(item)       : Koleksiyona yeni bir eleman ekler.
              Remove(item)    : Koleksiyondan belirli bir elemanı siler.
              RemoveAt(index) : Belirtilen indisteki elemanı siler (List gibi indeksli koleksiyonlarda).

              Insert(index, item) : Belirtilen indise eleman ekler, diğerleri kayar.

              Count           : Koleksiyonlarda eleman sayısını verir. (List, Dictionary, vb.)

              Length          : Dizilerde (Array) kullanılır, eleman sayısını verir.

              Clear()         : Koleksiyondaki tüm elemanları siler.

              Contains(item)  : Koleksiyonda belirli bir elemanın olup olmadığını kontrol eder (bool döner).

           -> Queue (Kuyruk) Metotları (FIFO)

              Enqueue(item)   : Kuyruğun sonuna eleman ekler.
              Dequeue()       : Kuyruğun başındaki elemanı çıkarır ve döner.
              Peek()          : Kuyruğun başındaki elemanı çıkarmaz, sadece gösterir.

           -> Stack (Yığın) Metotları (LIFO)

              Push(item)      : Yığının üstüne eleman ekler.
              Pop()           : Yığının üstündeki elemanı çıkarır ve döner.
              Peek()          : Yığının üstündeki elemanı çıkarmaz, sadece gösterir.

            */


            #endregion

            #region List<T>

             // List<T> -> Aynı türde verileri sıralı şekilde tutar
            Console.WriteLine("=== List<T> ===");

            List<string> sehirler = new List<string>();

            sehirler.Add("Kocaeli"); // Listeye eleman eklenir
            sehirler.Add("Korfez");
            sehirler.Add("İzmit");
            sehirler.Insert(1, "İstanbul"); // 1. index'e İstanbul eklenir, diğerleri kayar.

            Console.WriteLine("List içeriği:");

            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            #endregion

            #region ArrayList

            // ArrayList -> Farklı türde verileri bir arada tutabilir
            Console.WriteLine("\n=== ArrayList ===");

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Merhaba"); // string
            arrayList.Add(123);       // int
            arrayList.Add(true);      // bool

            Console.WriteLine("ArrayList içeriği:");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i] + " (" + arrayList[i].GetType().Name + ")");
            }

            #endregion

            #region Dictionary

            // Dictionary<TKey, TValue> -> Anahtar-değer çifti şeklinde veri tutar
            Console.WriteLine("\n=== Dictionary ===");

            Dictionary<string, int> notlar = new Dictionary<string, int>();

            notlar.Add("Atahan", 85);  // "Atahan" anahtarı, 85 değeri
            notlar.Add("ATA", 92);

            Console.WriteLine("Dictionary içeriği:");
            
            foreach (var not in notlar)
            {
                Console.WriteLine($"{not.Key}: {not.Value}");
            }
            
            #endregion

            #region Queue

            // Queue: FIFO (First In First Out) mantığı ile çalışır
            Console.WriteLine("\n=== Queue ===");

            Queue<string> kuyruk = new Queue<string>();

            kuyruk.Enqueue("Ahmet"); // Kuyruğa ekleme
            kuyruk.Enqueue("Fatma");
            kuyruk.Enqueue("Hayriye");

            Console.WriteLine("İlk kişi: " + kuyruk.Peek()); // İlk sıradaki kişiyi gösterir

            kuyruk.Dequeue();  // İlk sıradakini çıkarır

            Console.WriteLine("Kuyruk içeriği:");

            foreach (string kisi in kuyruk)
            {
                Console.WriteLine(kisi);
            }

            #endregion

            #region Stack

            // Stack -> LIFO: Son giren ilk çıkar mantığı
            Console.WriteLine("\n=== Stack ===");

            Stack<string> yigin = new Stack<string>();

            yigin.Push("Veri1"); // Yığına ekleme
            yigin.Push("Veri2");
            yigin.Push("Veri3");

            Console.WriteLine("En üstteki: " + yigin.Peek()); // En son ekleneni gösterir

            yigin.Pop(); // son gireni çıkarır

            Console.WriteLine("Stack içeriği:");

            foreach (string veri in yigin)
            {
                Console.WriteLine(veri);
            }

            #endregion

            #region HashSet

            // HashSet -> Aynı veri birden fazla kez eklenemez
            Console.WriteLine("\n=== HashSet ===");

            HashSet<string> mailler = new HashSet<string>();

            mailler.Add("ata@ata.com");
            mailler.Add("korfez@korfez.com");
            mailler.Add("ata@ata.com"); // Bu veri zaten var, tekrar eklenmez

            Console.WriteLine("HashSet içeriği: ");

            foreach (string mail in mailler)
            {
                Console.WriteLine(mail);
            }

            #endregion

            #region theAnd

            Console.WriteLine("\nKoleksiyonlar konusunda temel bilgiler tamamlandı. İyi çalışmalar:=)");
            Console.WriteLine("\nÇOKOMELLİ BİLGİLER:))");

            #endregion
        }
    }
}
