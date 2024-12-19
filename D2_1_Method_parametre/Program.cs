namespace D2_1_Method_parametre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.soru

            //int sayi1 = 10;
            //int sayi2 = 5;

            //int topla = sayi1 + sayi2;

            //Console.WriteLine("2 sayının toplamı:" + topla);
            SayilarinToplami(10,5);
            #endregion

            #region 2.soru
            Console.WriteLine("---------------");
            //int sayi3 = 11;
            //int sayi4 = 35;

            //int topla2 = sayi3+ sayi4;

            //Console.WriteLine("2 sayının toplamı:" + topla2);
            SayilarinToplami(11, 35);
            #endregion

        }


        static void SayilarinToplami(int sayi1,int sayi2)//sayi1,sayi2 parametredir
        {
            int topla = sayi1 + sayi2;
            Console.WriteLine("2 sayının toplamı:" + topla);
        }
    }
}
