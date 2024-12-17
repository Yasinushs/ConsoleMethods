namespace Ders1_methods_nedir
{
    internal class Program
    {
        static void Main(string[] args)//ANA METHOD
        {
            YaziGetir();
            Tire();
            Toplama();
            Tire();
            DiziListesi();

        }
        static void YaziGetir()// Yardımcı method
        {
            Console.WriteLine("C# method konusuna hoşgeldiniz");

        }
        static void Toplama()// Yardımcı Method
        {
            int sayi1 = 5;
            int sayi2 = 15;

            Console.WriteLine(sayi1 + sayi2);


        }
        static void Tire()
        {
            Console.WriteLine("---------------------------------");
        }
        static void DiziListesi()
        {
            Random random = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(1, 1500);
            }
            foreach (int i in sayilar) 
            {
                Console.WriteLine(i);
            }

        }





    }
}
