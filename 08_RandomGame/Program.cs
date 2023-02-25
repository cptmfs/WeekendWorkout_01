internal class Program
{
    private static void Main(string[] args)
    {
        //Bilgisayar tarafından belirlenen 1 ile 200 arasında rastgele bir sayıyı tahmin edeceğiniz şekilde sizi yönlendiren bir oyun programı yazınız. Yani girdiğiniz değer tutulan değerden büyükse/küçükse uygun bir mesaj vererek yeni sayı girmesini isteyebilirsiniz. Maximum sayıyı tahmin etme sınırı 10 olsun. Eğer bu sınır geçilirse ekranın geriplan rengi kırmızı olsun ve bir mesaj vererek programdan çıksın.

        Random rnd = new Random(); // random classını cagirdik


        int randomSayi = rnd.Next(1, 200); //1 ile 200 arası bir sayı olusturup randomSayiya atamasını istedik..


        Console.WriteLine("Oyunumuza hoşgeldiniz..\nBilgisayar tarafında 1 ile 200 arası rastgele bir sayı üretildi..\nBu sayıyı tahmin etmek için 10 adet hakkınız vardır..");
        for (int i = 1; i <= 10; i++) //Kullanıcının 10 hakkı oldugu için bir for döngüsü içerisinde 10 defa tahmin girmesini istedik..
        {
        step1:
            Console.WriteLine("Lütfen {0} 'inci tahmininizi giriniz :  ", i);
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == randomSayi) 
            {
                Console.BackgroundColor = ConsoleColor.Green; // tahmin dogru ise çıkacak mesajın arka planını yeşil yapma komutu..
                Console.ForegroundColor = ConsoleColor.Black; // tahmin dogru ise çıkacak mesajın yazı rengini siyah yapma komutu..
                Console.WriteLine("Bilgisayar Tarafından Tutulan Sayı : {0} \n Sizin Tahmininiz : {1} \nTebrikler.. Doğru tahminde bulundunuz. ", randomSayi, tahmin);
            }
            else if (tahmin < randomSayi)
            {
                Console.WriteLine("Çok yaklaştınız.. Bir İpucu :  Bilgisayar tarafından üretilen sayıdan küçük bir tahminde bulundunuz..  ");

            }
            else if (tahmin > randomSayi)
            {
                Console.WriteLine("Çok yaklaştınız.. Bir İpucu :  Bilgisayar tarafından üretilen sayıdan büyük bir tahminde bulundunuz..  ");

            }
        }

        Console.BackgroundColor = ConsoleColor.Red; //10 Hakkı kullandıktan sonra ekran rengini kırmızı yapma komutu..
        Console.ForegroundColor = ConsoleColor.DarkBlue; //10 Hakkı kullandıktan sonra yazı rengini koyu mavi yapma komutu..
        Console.Clear(); //Ekranı komple temizleme komutu..
        Console.WriteLine("\n\n\t\t\t\tMalesef başaramadınız 10 hakkınızıda kullandınız..\n\n\t\t\t\t\t\t Ama pes etmek yok!\n\n\t\t\t\t\t Bir dahaki sefere başaracaksınız.. ");

        Console.ReadKey();

    }
}