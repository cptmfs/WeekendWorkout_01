internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan alınan sayısal değere göre uygun olan uzunlukta şifre üreten bir kod geliştiriniz (Örneğin kullanıcı 5 girecek buna uygun olarak rastgele olacak şekilde 5 karakterlik şifre oluşturulacak. Maksimum karakter sayısı 10 olacak ve kullanıcı 10 üzerinde bir değer verirse uyarı verilerek uygun değer girilene kadar kullanıcıdan değer alınacak.)

        Random rndm = new Random();
        int deger;
        string sifreKarakter = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz0123456789";
        string randomSifre = "";
        step1:
        Console.WriteLine("Lütfen 10 Karakter uzunluğuna kadar şifrenizin kaç karakterden oluşacağını giriniz : ");
        deger = Int32.Parse(Console.ReadLine());

        if (deger>0 && deger<=10)
        {
            for (int i = 0; i < deger; i++)
            {
                randomSifre += sifreKarakter[rndm.Next(sifreKarakter.Length)];
            }
            Console.WriteLine(deger + " karakterden oluşan şifreniz : {0} ", randomSifre);
        }
        else
        {
            Console.WriteLine("Lütfen Geçerli bir Değer Giriniz .. ");
            goto step1;
        }
        
        Console.ReadKey();
    }
}