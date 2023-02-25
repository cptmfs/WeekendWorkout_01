internal class Program
{
    private static void Main(string[] args)
    {
        // Klavyeden 0 (sıfır) değeri girilinceye kadar klavyeden okutulan değerlerin ortalamasını hesaplayıp ekrana yazan programı yazınız.
        int sayi, toplam=0,sayac=0;
        do
        {
            Console.WriteLine("Lütfen bir sayi giriniz : "); 
            sayi = Convert.ToInt32(Console.ReadLine()); // Klavyeden girilen degeri okuyoruz..
            sayac++; // Her girilen degerde sayacımızı 1 arttırıyoruz ki ortalama bulmak için kaç adet sayı girildiğini tutmus olalım..

            toplam += sayi; // girilen sayıları toplam degiskenine toplayarak atıyoruz..
            
        } while (sayi>0);// sayi 0 dan büyük oldugu sürece kosulu atıyoruz.
        sayac--; // sayimiz sıfır girildiğinde onuda sayaca ekleyeceği için sayacı 1 eksiltiyoruz..
        Console.WriteLine("Girilen sayıların  Ortalaması : {0} ' dır..", toplam / sayac); // toplam degeri sayac degerine bolup ortalamayı yazdırıyoruz..

        Console.ReadKey();  

    }
}