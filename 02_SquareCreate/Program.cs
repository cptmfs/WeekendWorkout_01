internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan ekrandan 1 ile 10 arasında bir değer girmesini isteyiniz ve bu girilen değere göre kenarları “*” karakterlerinden oluşan bir kare şeklini ekrana çizdiriniz.
        int deger;
        char yildiz = '*';
        adim1: // hatalı deger girdiginde geri döndüreceğimiz yeri tanımladık..
        Console.WriteLine("Lütfen 1 ile 10 arasında bir deger giriniz : ");

        deger = Convert.ToInt32(Console.ReadLine()); // Klavyeden girilen degeri okuduk...

            if (deger >= 1 && deger <= 10) // Koşul Kontrolü..
            {
                for (int i = 1; i <= deger; i++)
                {
                    for (int j = 1; j <= deger; j++)
                    {
                        if (i == 1 || i == deger || j == 1 || j == deger) // Burada yıldız şekli çizdirmek için kolon ve sutün olarak ilerlemesi için içiçe for döngüsü olusturup bu her iki döngüde koyacagım yıldız adedine göre kontrol saglıyorum..
                        {
                            Console.Write(yildiz); // Diyelimki kullanıcı 6 degerini girdi , kosulumuzda i ve j 1 den baslıyor ve j degeri 6 degerine gelene kadar i == 1 kosulu saglandıgı icin Console.Write komutu oldugu icin yanyana 6 defa yıldız koyulacak ekrana sonra kosul saglanmadıgı için Console.WriteLine ' a düşüp alt satıra geçeceğiz.
                        }
                        else
                        {
                            Console.Write(" "); // i 1 ve 6 dısında bir sayı geldiğinde , sadece j ==1 yada j == deger oldugunda yıldız yazdıracak ve diger durumlarda else satırına girip sadece bosluk atacak ekrana .
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!! Lütfen 1 ile 10 arasında bir sayı giriniz..");
            goto adim1; // hatalı girişte tekrar yukarıda tanımladıgım adim1'e yani tekrar deger alma ekranına yönlendireceğiz..
            }
        
        
        Console.ReadKey();
    }  
}