namespace D2_2_method_parametre_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 sayının farkını hesaplayan method kodlayınız
            //BÜYÜK OLAN SAYIDAN KÜÇÜK SAYI ÇIKARTILARAK FARKI HESAPLAYINIZ
            SayilarinFarki(10, 5);
            Console.WriteLine("--------------------");
            SayilarinFarki(10, 50);
            Console.WriteLine("--------------------");
            SayilarinFarki(50, 50);

        }

        static void SayilarinFarki(int sayi1, int sayi2)
        {
            int fark;
            if (sayi1 > sayi2)
            {
                fark = sayi1 - sayi2;
            }
            else if (sayi1 < sayi2)
            {
                fark = sayi2 - sayi1;
            }
            else
            {
                fark = sayi2 - sayi1;
            }

            Console.WriteLine("2 Sayının Farkı: " + fark);

        }
    }
}
