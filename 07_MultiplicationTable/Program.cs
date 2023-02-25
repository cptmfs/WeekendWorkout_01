internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrana 10’a kadar olan sayıların çarpım tablosunu satır satır yazdıran programı geliştiriniz. (örneğin 6x2=12,6x3=18..)

        int carpimSonuc;
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                carpimSonuc = i * j;
                Console.WriteLine("Carpim İslemi : {0} x {1} = {2}",i,j,carpimSonuc);
            }
        }
        Console.ReadKey();
    }
}