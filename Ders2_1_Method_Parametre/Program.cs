namespace Ders2_1_Method_Parametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayilarinToplami(20, 35);
        }
        static void SayilarinToplami(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların Toplamı " + toplam);
        }
    }
}
