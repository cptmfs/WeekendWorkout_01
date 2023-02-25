internal class Program
{
    private static void Main(string[] args)
    {
        //Bir çalışanın aylık maaşı 8.500 TL’dir. Anlaşması dahilinde çalıştığı her yıl için maaşına %15 zam alacaktır.  Bu kişinin 5 yıl sonraki maaşını hesaplayan programı hazırlayınız.

        double maas = 8500; 
        float zamOrani = 1.15f;
        Console.WriteLine("Şuanki maaşınız : {0} 'TL dir.. ",maas); // Şuanki maaşı ekrana yazdırıyoruz..
        Console.WriteLine("\n\nYıllık Zam Oranınız %15'dir.."); // Zam oranını ekrana yazdırıyoruz ..
        for (int i = 0; i < 5; i++)
        {
            maas *= zamOrani; // Döngü içerisinde 5 yıl olana kadar maaşı %15 arttırıyoruz..
        }
        Console.WriteLine("\n\n5 Yıl Sonra Alacağınız Maaş : {0} TL dir..",Convert.ToInt32(maas)); // çıkan sonuc küsüratlı bir deger oldugu için int'e çevirip ekrana yazdırıyoruz..

        Console.ReadKey();
    }
    
}