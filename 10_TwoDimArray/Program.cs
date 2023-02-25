internal class Program
{
    private static void Main(string[] args)
    {
        // İki boyutlu bir dizinin tüm elemanlarının değerini iki katına çıkartan ve sonra bu diziyi ekrana yazdıran kodu geliştiriniz.

        int[,] dizi = { { 3, 4 }, { 5, 6 }, { 7, 8 } };
        Console.WriteLine("Dizi Elemanlarının 2 Katı Alındıktan Sonra Yeni Değerleri Aşağıdaki Gibidir  :");
        foreach (var item in dizi)
        {
            Console.Write(item * 2 + " "); //Her bir dizi elemanı sırasıyla {(0,0),(0,1)..vb} dolaşılıp item içerisine atılıyor ve 2  ile çarpıp ekrana                                         yazdırıyoruz..
        }
        Console.ReadKey();
    }
}