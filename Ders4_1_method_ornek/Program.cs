namespace Ders4_1_method_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Bir ülkede elektrik fatura kategorilere göre ayrılmıştır

            Eğer konut için bir elektrik faturası varsa
                        
            0(dahil)-100 kilowatt(kw) harcandıysa kw başına 1.45 kr 
            100(dahil)-400 kilowatt(kw) harcandıysa kw başına 1.51 kr 
            40(dahil)-700 kilowatt(kw) harcandıysa kw başına 1.55 kr 
            770(dahil)-1200 kilowatt(kw) harcandıysa kw ilk 1000 için 1550 tl alınacak, 1000 kw üstündeki harcama içinde 1.60 kr 
            1200(dahil)  ve üstünde kw harcandıysa ilk 1500kw için 2000 tl, 1500 ve üstü kw için kw  başına 1.95 kr 
             olarak hesaplanacaktır

            Eğer Sanayi için bir elektrik faturası varsa
             
            0(dahil)-100 kilowatt(kw) harcandıysa kw başına 1.25 kr 
            100(dahil)-400 kilowatt(kw) harcandıysa kw başına 1.32 kr 
            40(dahil)-700 kilowatt(kw) harcandıysa kw başına 1.43 kr 
            770(dahil)-1200 kilowatt(kw) harcandıysa kw ilk 1000 için 1350 tl alınacak, 1000 kw üstündeki harcama içinde 1.54 kr 
            1200(dahil)  ve üstünde kw harcandıysa ilk 1500kw için 1750 tl, 1500 ve üstü kw için kw  başına 1.85 kr 
             olarak hesaplanacaktır

             Eğer Ağır Sanayi için bir elektrik faturası varsa
             
            0(dahil)-100 kilowatt(kw) harcandıysa kw başına 1.21 kr 
            100(dahil)-400 kilowatt(kw) harcandıysa kw başına 1.28 kr 
            40(dahil)-700 kilowatt(kw) harcandıysa kw başına 1.39 kr 
            770(dahil)-1200 kilowatt(kw) harcandıysa kw ilk 1000 için 1290 tl alınacak, 1000 kw üstündeki harcama içinde 1.50 kr 
            1200(dahil)  ve üstünde kw harcandıysa ilk 1500kw için 1650 tl, 1500 ve üstü kw için kw  başına 1.79 kr 
             olarak hesaplanacaktır
             
             
             */

            string faturaTuru;
            int kwHarcanan;


            faturaTuru = KullanicidanIste("Fatura türü yazınız");
            kwHarcanan = KwHarcama();

          double odenecek=  FaturaHesapla(faturaTuru, kwHarcanan);

            KullanicidanIste("ÖDENECEK-" + odenecek);
        }

        /// <summary>
        /// Kullanıcıdan istenilen Fatura türü hesabı için fatura türü verir(Konut, sanayi, ağır sanayi)
        /// </summary>
        /// <param name="yazi"></param>
        /// <returns></returns>
        static string KullanicidanIste(string yazi)
        {
            Console.WriteLine(yazi);
            string tur = Console.ReadLine();
            return tur;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="metin"></param>
        /// <returns></returns>
        static int KwHarcama(string metin = "Harcanan elektriği kw cinsinden giriniz")
        {
            //Console.WriteLine("Harcanan elektriği kw cinsinden giriniz");
           string yazilanYazi= KullanicidanIste(metin);
            int kw = Convert.ToInt32(yazilanYazi);
            return kw;
        }



        static double FaturaHesapla(string faturaTuru, int harcanan)
        {

            if (faturaTuru.ToLower() == "konut")
            {
                return Konut(harcanan);
            }
            return 0;

        }


        static double Konut(int kw)
        {

            if (kw >= 0 && kw < 100)
            {
                return kw * 1.45;
            }
            return 1;
        }


        static void Sanayi()
        {

        }
        static void AgirSanayi()
        {

        }


    }
}
