namespace Ders3_3_overload_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiIste("1.sayıyı giriniz");
            int s1 = TamSayiAl();
            Console.WriteLine();
            SayiIste("2.sayıyı giriniz");
            int s2 = TamSayiAl();
            //2 sayıyı topla
            Islem(s1, s2);
            //1.sayının 0 dan büyük olup olmadığını hesaplayınız

            Console.WriteLine(Islem(s1));
            //
            /*

           Kullanıcıdan alınan maaş, yaş,Cinsiyet ve çalıştığı gün sayısına göre emekli edilmek istenecektir
            Eğer Cinsiyet kadın ise 
            yaş 60 ve üstü ve prim gün sayısı 6200 üstünde ise emekli olabilir ve maaşının 13 katı kadar ikramiye verilerek emekli edilecektir. Eğer yaş 55 üstünde ise prim gün sayısı 7000 üstünde ise maaşının 12 katı kadar ikramiye alarak emekli edilecek. Bu şartlar dışında olanlar emekli edilemeyecek

            Eğer Cinsiyet Erkek ise 
            yaş 65 ve üstü ve prim gün sayısı 6500 üstünde ise emekli olabilir ve maaşının 14 katı kadar ikramiye verilerek emekli edilecektir. Eğer yaş 59 üstünde ise prim gün sayısı 7300 üstünde ise maaşının 13 katı kadar ikramiye alarak emekli edilecek. Bu şartlar dışında olanlar emekli edilemeyecek
            ÖNEMLİ: Mutlaka overload method kullanılacak. Main method içinde kod sadece method çağırma işlemi yapılacak
             */


        }




        /// <summary>
        /// 2 sayının toplam sonucu verir
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        static int Islem(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// <summary>
        /// girilen sayının pozitif mi,negatif mi, 0 mı  olduğunu hesaplar
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        /// 

        static double Islem(int d1, decimal d2)
        {
            return 0;
        }
        static double Islem(int d1, int d2, int d3)
        {
            return 0;
        }
        static double Islem(byte d1, int d2, int d3)
        {
            return 0;
        }
        static double Islem(string d1, int d2, int d3)
        {
            return 0;
        }
        static double Islem(DateTime d1, int d2, int d3)
        {
            return 0;
        }
        static string Islem(int sayi)
        {
            if (sayi > 0)
            {
                return "0 dan büyük";
            }
            else if (sayi == 0)
            {
                return "sayı 0 dır";
            }
            else
            {
                return "Sayı 0 dan küçük";
            }

        }

        /// <summary>
        /// Sayı istemek için kullanılır
        /// </summary>
        /// <param name="deger"></param>
        static void SayiIste(string deger)
        {
            Console.WriteLine(deger);
        }

        static int TamSayiAl()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }

}

