internal class Program
{
    private static void Main(string[] args)
    {
        // Bir mağaza müşterilerine yaptıkları alışveriş tutarına göre indirim yapmaktadır. 200 TL ye kadar olan alışverişler için %10, 200-400 TL arası olan alışverişler için %15, 400 TL den fazla olan alışverişler için %20 indirim uygulamaktadır. Buna göre bir kişinin ödeyeceği net miktarı hesaplayan programın kodunu yazınız.

        int tutar;
        float indirim200 = 0.10f;
        float indirim400 = 0.15f;
        float indirimMax = 0.20f;
        step1:
        Console.WriteLine("Lütfen Alışveriş Yaptığınız Tutarı Giriniz : ");
        tutar = Int32.Parse(Console.ReadLine());

        if (tutar>0 && tutar <= 200 )
        {
            tutar = (int)(tutar - (tutar * indirim200));

            Console.WriteLine("Ödeyeceğiniz Tutar :{0} 'TL dir... " ,tutar);
        }
        else if (tutar>200 && tutar<=400)
        {
            tutar = (int)(tutar - (tutar * indirim400));
            Console.WriteLine("Ödeyeceğiniz Tutar :{0} 'TL dir... ", tutar);
        }
        else if (tutar > 400)
        {
            tutar = (int)(tutar - (tutar * indirimMax));

            Console.WriteLine("Ödeyeceğiniz Tutar :{0} 'TL dir... ", tutar);
        }
        else
        {
            Console.WriteLine("Geçerli bir  alışveriş tutarı girmediniz...");
            goto step1;
        }
        Console.ReadKey();

    }
}