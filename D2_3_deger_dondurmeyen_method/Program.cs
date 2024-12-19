namespace D2_3_deger_dondurmeyen_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method tanımı yaparken içinde void anahtar kelimesi varsa kesinlikle DEĞER DÖNDÜRMEYEN METHOD tur denilir

            Console.WriteLine("Merhaba cw");

            EkranYaz("Merhaba ekrana yaz methodum");

            EkranYaz("Bir sayı giriniz");
            int s1 = Convert.ToInt32(Console.ReadLine());

            EkranYaz("Bir sayı giriniz");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Toplam(s1, s2);
            Toplam(20, 21);


        }

        static void Toplam(int s1, int s2)
        {
            int topla = s1 + s2;
            EkranYaz("Sayıların toplamı:" + topla);
        }

        static void EkranYaz(string yazi)
        {
            Console.WriteLine(yazi);
        }

    }
}
