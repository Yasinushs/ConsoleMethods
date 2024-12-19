namespace Ders2_2_Method_Parametre_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 sayının farkını hesaplayan method kjodlayınız
            //BÜYÜK OLAN SAYIDAN KÜÇÜK SAYI ÇIKARTILARAK FARKI HESAPLAYAN YAPIYI KENDN HESAPLA= D2_2_method_parametre_ornek   Hocanın projesnde mevcut
            SayilarinFarki(25, 10);
        }
        static void SayilarinFarki(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            Console.WriteLine("2 Sayının Farkı: "+ fark);

        }
    }
}
