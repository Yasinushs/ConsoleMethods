namespace Ders3_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan maaş, yaş,Cinsiyet ve çalıştığı gün sayısına göre emekli edilmek istenecektir
            //Eğer Cinsiyet kadın ise
            //yaş 60 ve üstü ve prim gün sayısı 6200 üstünde ise emekli olabilir ve maaşının 13 katı kadar ikramiye verilerek emekli edilecektir. Eğer yaş 55 üstünde ise prim gün sayısı 7000 üstünde ise maaşının 12 katı kadar ikramiye alarak emekli edilecek. Bu şartlar dışında olanlar emekli edilemeyecek

            //Eğer Cinsiyet Erkek ise
            //yaş 65 ve üstü ve prim gün sayısı 6500 üstünde ise emekli olabilir ve maaşının 14 katı kadar ikramiye verilerek emekli edilecektir. Eğer yaş 59 üstünde ise prim gün sayısı 7300 üstünde ise maaşının 13 katı kadar ikramiye alarak emekli edilecek. Bu şartlar dışında olanlar emekli edilemeyecek
            //ÖNEMLİ: Mutlaka overload method kullanılacak. Main method içinde kod sadece method çağırma işlemi yapılacak
            // */

            CinsiyetAl();







        }

        /// <summary>
        /// Cinsiyet girişi verir
        /// </summary>
        static void CinsiyetAl()
        {
            VeriIste("Cinsiyeti giriniz");
            string cinsiyetAl = TextAl();
            Hesapla(cinsiyetAl);
        }

        /// <summary>
        /// Kullanıcıdan yaş ister
        /// </summary>
        /// <returns></returns>
        static byte YasIste()
        {

            VeriIste("Yaşı giriniz");
            //byte yasAl = Convert.ToByte(Console.ReadLine());
            byte yasAl = ByteAl();
            return yasAl;
        }
        static short PrimIste()
        {
            VeriIste("Çalıştığınız gün sayısı giriniz");
            //short gunAl=Convert.ToInt16(Console.ReadLine());
            short gunAl = ShortAl();
            return gunAl;
        }

        static double MaasIste()
        {

            VeriIste("Maaş giriniz");
            // double maasAl=Convert.ToDouble(Console.ReadLine());
            double maasAl = DoubleAl();
            return maasAl;
        }

        static void Devam()
        {
            Console.WriteLine("Yeni hesaplama yapmak ister misiniz?\nEvet için e,evet,yes yazın ya da çıkmak için herhangi bir tuşa basın");
            string devamMi = Console.ReadLine();

            switch (devamMi.ToLower())
            {
                case "evet":
                case "yes":
                case "y":
                case "e":
                    Console.Clear();
                    CinsiyetAl();
                    break;
                default:
                    break;
            }
        }
        static void KadinEmekliHesapla(byte yas, short prim)
        {

            if (yas > 60 && prim > 6200)
            {
                double ikramiye = MaasIste() * 13;
                Console.WriteLine("Emekli olabilirsiniz ve ikramiyeniz:{0}", ikramiye);
                Devam();
            }
            else
            {

            }

        }
        static void Hesapla(string cinsiyetAl)
        {
            switch (cinsiyetAl.ToLower())
            {
                case "kadın":
                case "kadin":
                case "woman":
                case "k":
                    //byte yas = YasIste();
                    //short prim = PrimIste();
                    //KadinEmekliHesapla(yas, prim);
                    KadinEmekliHesapla(YasIste(), PrimIste());
                    break;

                case "erkek":
                case "man":
                case "bay":
                case "herif":
                case "e":



                    break;

                default:
                    break;
            }
        }

        static string TextAl()
        {
            return Console.ReadLine();
        }

        static byte ByteAl()
        {
            return Convert.ToByte(TextAl());
        }

        static double DoubleAl()
        {
            return Convert.ToDouble(TextAl());
        }
        static short ShortAl()
        {
            return Convert.ToInt16(TextAl());
        }
        static void VeriIste(string deger)
        {
            Console.WriteLine(deger);
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
