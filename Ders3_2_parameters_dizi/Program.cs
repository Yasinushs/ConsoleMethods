namespace Ders3_2_parameters_dizi
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*
             Eleman sayısı kullanıcıdan alan 4 tam sayı dizisi için, girilen dizi eleman sayısına göre elemanlarını bir random ile alan ve elemanlarının toplamların ekranda gösteren uygulamayı tam method method yapısı uygulayarak kodlayınız
             */

            int[] dizi1 = new int[DiziElemanSayisi()];
            int[] dizi2 = new int[DiziElemanSayisi()];
            int[] dizi3 = new int[DiziElemanSayisi()];
            int[] dizi4 = new int[DiziElemanSayisi()];

            //dizi1 = DiziyeElemanEkle(dizi1);
            //DiziElemanlariListele(dizi1);
            //Console.WriteLine("Dizi-1 için eleman toplamı:" + DiziElemanlariTopla(dizi1));
            DiziIslemi(dizi1, 1);
            Console.WriteLine("---------------------------------------------");
            //dizi2 = DiziyeElemanEkle(dizi2);
            //DiziElemanlariListele(dizi2);
            //Console.WriteLine("Dizi-1 için eleman toplamı:" + DiziElemanlariTopla(dizi2));
            DiziIslemi(dizi2, 2);

            Console.WriteLine("---------------------------------------------");
            //dizi2 = DiziyeElemanEkle(dizi3);
            //DiziElemanlariListele(dizi3);
            //Console.WriteLine("Dizi-1 için eleman toplamı:" + DiziElemanlariTopla(dizi3));
            DiziIslemi(dizi3, 3);

            Console.WriteLine("---------------------------------------------");
            //dizi2 = DiziyeElemanEkle(dizi4);
            //DiziElemanlariListele(dizi4);
            //Console.WriteLine("Dizi-1 için eleman toplamı:" + DiziElemanlariTopla(dizi4));
            DiziIslemi(dizi4, 4);


        }

        /// <summary>
        /// Dizi formatına göre işlemi ele alır
        /// </summary>
        /// <param name="dizi"></param>
        /// <param name="sayi"></param>
        static void DiziIslemi(int[] dizi, int sayi)
        {
            dizi = DiziyeElemanEkle(dizi);
            DiziElemanlariListele(dizi);
            Console.WriteLine($"Dizi-{sayi} için eleman toplamı:" + DiziElemanlariTopla(dizi));
        }

        /// <summary>
        /// Dizi Eleman sayısı  verir
        /// </summary>
        /// <returns></returns>
        static int DiziElemanSayisi()
        {
            Console.WriteLine("Dizi için eleman sayısı giriniz");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            return elemanSayisi;
        }


        //Diziye eleman ekler
        static int[] DiziyeElemanEkle(int[] dizi)
        {
            Random random = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(-500, 500);
            }
            return dizi;

        }

        /// <summary>
        /// Dizini eleman değerlerini toplar
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        static int DiziElemanlariTopla(int[] dizi)
        {
            int topla = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                topla = topla + dizi[i];
            }

            return topla;
        }

        /// <summary>
        /// Dizi elemanlarını listeler
        /// </summary>
        /// <param name="dizi"></param>
        static void DiziElemanlariListele(int[] dizi)
        {
            for (int i = 0; i < dizi.Count(); i++)
            {
                Console.Write(dizi[i] + ",");
            }
        }
    }
}
