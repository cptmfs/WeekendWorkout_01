internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan alınan 2 sayıya yine kullanıcıdan alınacak işlem seçimine göre dört işlem uygulayan program kodunu yazınız. (Toplama için T veya t, Çıkartma için E/e, Çarpma için Ç/ç, Bölme için B/b kodlarını kullanınız. Eğer bu işlem kodları dışındaki girişler için hatalı giriş yapıldığına dair bir mesaj verdirebilirsiniz)

        int sayi1, sayi2;
        char[] islem = { 'b', 'ç', 't', 'e' };
        char girilenDeger;

        Console.WriteLine("Lütfen sayi1'i giriniz : ");
        sayi1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen sayi2'yi giriniz : ");
        sayi2 = Int32.Parse(Console.ReadLine());
        adim1:
        Console.Write("\n Bölme İşlemi için :b \n Çarpma İşlemi için :ç \n Toplama İşlemi için :t \n Çıkarma İşlemi için :e yazınız..\nLütfen yapmak istediğiniz işlemi yazınız : ");

        girilenDeger = Convert.ToChar(Console.ReadLine());

        if (girilenDeger=='b')
        {
            Console.WriteLine("\nBölme İşleminizi sonucu : " + (sayi1 / sayi2)); 
        }
        else if (girilenDeger == 'ç')
        {
            Console.WriteLine("\nÇarpma İşleminizi sonucu : " + (sayi1 * sayi2));
        }
        else if (girilenDeger == 't')
        {
            Console.WriteLine("\nToplama İşleminizi sonucu : " + (sayi1 + sayi2));
        }
        else if (girilenDeger == 'e')
        {
            Console.WriteLine("\nÇıkarma İşleminizi sonucu : " + (sayi1 - sayi2));
        }
        else
        {
            Console.WriteLine("\nLütfen Geçerli bir İşlem degeri giriniz..");
            goto adim1; // Hatalı degerde programı kapatmamak için tekrar yapmak istenilen işlemi yazma ekranına yönlendiriyoruz..
        }




        Console.ReadKey();
    }
}