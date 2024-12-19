namespace Ders2_4_Void_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 2 adet sayıdan büyük olanı method ile hesaplayıp kullanıcıya gösteren void BuyukSayi adında method ile kodlayınız

            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            BuyukSayi(s1 , s2);
        }
        static void BuyukSayi(int s1, int s2)
        {
            if (s1 > s2)
            {
                Console.WriteLine("Büyük sayı: " + s1);
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Büyük Sayı" + s2);
            }
            else
            {

                Console.WriteLine("İki Sayı Eşittir");



            }

        }
       
    }
}
