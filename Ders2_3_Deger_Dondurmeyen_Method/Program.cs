namespace Ders2_3_Deger_Dondurmeyen_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method tanımı yaparken içinde void anahtar kelimesi varsa kesinlikle DEĞER DÖNDÜRMEYEN METHOD tur denilir

            Console.WriteLine("Merhaba cw");

            EkranYaz("Merhaba ekrana yaz methodum");
            Toplam(15, 7);
            KaresiniVer(11);
            KaresiniVer(-9);
        }
        static void EkranYaz(string yazi)
        {
            Console.WriteLine(yazi);
        }
        static void Toplam(int say1 , int say2)
        {
            int toplam = say1+ say2;
            EkranYaz("İki Sayının Toplamı: "+toplam);
        }
        static void KaresiniVer(int say1)
        {
            int kare = say1 * say1;
            EkranYaz("Girilen Sayının Karesi: " + kare);
            
        }
    }
}
