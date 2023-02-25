internal class Program
{
    private static void Main(string[] args)
    {
        //Klavyeden girilen sayıdan başlayıp 1’e kadar sayıları 5’er 5’er azaltarak ekrana yazdıran programı hazırlayınız. (Tabii ki gerekli kontrolleri yaparaktan...)
        int sayi;
        adim1:
        Console.Write("Lütfen bir sayı giriniz : ");
        sayi = Convert.ToInt32(Console.ReadLine());

        
        if (sayi > 0) // sayının negatiflik kontrolünü yapıyoruzz..
        {
            Console.WriteLine("\n Hadi Sayıyı 5'er 5'er azaltalım .. \n");
            for (int i = sayi; sayi > 0; sayi-=5) //for döngüsü ile önce kullanıcının girdigi degeri i ye atayip 5'er 5'er eksiltiyoruz..
            {
                Console.WriteLine(sayi);
            }
        }
        else
        {
            Console.WriteLine("Negatif bir sayı girdiniz.!! ");
            goto adim1;  // hatalı deger girdiğinde programı kapatmamak için tekrar sayi girme ekranına yönlendiriyoruz..
        }

        Console.ReadKey();
    }
}