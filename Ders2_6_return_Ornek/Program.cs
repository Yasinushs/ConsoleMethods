using System.Text.Json.Serialization;

namespace Ders2_6_return_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 2 sayı için
            //1.Topla adında return method
            //2. Fark adında return method
            //3. Bol adında method
            //4. Carp adında method
            //5. ModAl adında method larını ilgili işlemleri yapmak için kullanınız
            Console.WriteLine("1. Sayıyı Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int resultSum=Topla(s1 , s2);

            Console.WriteLine("sayıların toplamı: " + resultSum);
            Console.WriteLine("2 sayının toplamı:"+Topla(s1,s2));
            Console.WriteLine("2 sayının toplamı:"+Fark(s1,s2));
            Console.WriteLine("2 sayının toplamı:"+Carp(s1,s2));
            Console.WriteLine("2 sayının toplamı:"+Bol(s1,s2));
            Console.WriteLine("2 sayının toplamı:"+ModAl(s1,s2));
        }
        /// <summary>
        /// İki Sayının Toplamı
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int Topla(int d1, int d2)
        {
            return d1 + d2;
        }
        /// <summary>
        /// İki Sayının Farkı
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
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
        static int Bol (int d1, int d2) 
        { 


            return d1 / d2;
        }
        /// <summary>
        /// 1. Sayıyı ve 2. Sayıyı Çarpar, Çarpım Sonucunu Verir
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static int Carp(int d1 , int d2)
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
    }
}
