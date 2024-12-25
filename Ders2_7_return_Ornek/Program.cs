using System.Security.Cryptography;

namespace Ders2_7_return_Ornek
{
    internal class Program
    {
        private static readonly string d1;

        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 2 sayı için
            //1.Topla adında return method
            //2. Fark adında return method
            //3. Bol adında method
            //4. Carp adında method
            //5. ModAl adında method larını ilgili işlemleri yapmak için kullanınız
            //Yukardaki 5 işlemde hiç bir kodlama ana method içinde olmadan işlemler gerçekleştirilecektir;(Ana method içinde sadece yardımcı methodlar çağrılarak işlemler gerçekleştirilecektir)
            EkranYaz("1.sayı");
            int say1 = DonusturInt();
            EkranYaz("2.sayı");
            int say2 = DonusturInt();
           int toplaSonuc= Topla(say1, say2);
            EkranYaz("2 sayının toplamı:" + toplaSonuc);
            EkranYaz("2 sayının fark:" + Fark(say1, say2)); 

            Fark(say1 , say2);
            Bol(say1 , say2);
            Carp(say1 , say2);  
            ModAl(say1 , say2);








        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yazi"></param>
        static void EkranYaz(string yazi)
        {
            Console.WriteLine(yazi);

        }

        /// <summary>
        /// 2 sayının ...
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int Topla(int d1, int d2)
        {
            return d1 + d2;
        }
        static int Fark(int d1, int d2)
        {
            return d1 - d2;


        }
        /// <summary>
        /// 1. Sayıyı 2. sayıya böler, bölüm sonucunu verir
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int Bol(int d1, int d2)
        {


            return d1 / d2;
        }
        /// <summary>
        /// 1. Sayıyı ve 2. Sayıyı Çarpar, Çarpım Sonucunu Verir
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int Carp(int d1, int d2)
        {
            return d1 * d2;
        }
        /// <summary>
        /// 1. Sayıyı 2. Sayıya Böldüğünde Kalanı Verir
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int ModAl(int d1, int d2)
        {
            return d1 % d2;
        }
        
        static int DonusturInt()
        {
            return Convert.ToInt32(Oku());
        }

        

        static string Oku()
        {
            return Console.ReadLine();
        }

    }
}
