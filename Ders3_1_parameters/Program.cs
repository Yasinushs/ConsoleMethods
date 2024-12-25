namespace Ders3_1_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 2, 34, 2, 3, 4, 56, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            int toplaDizi1 = 0;

            //for (int i = 0; i < dizi1.Length; i++)
            //{
            //    toplaDizi1 =toplaDizi1+ dizi1[i];
            //}
            toplaDizi1 = Topla(dizi1);

            int[] dizi2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 30, 40, 41 };
            int toplaDizi2 = Topla(dizi2);
            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    toplaDizi2 = toplaDizi2 + dizi2[i];
            //}


            int[] dizi3 = { 1, 2, 3, 5, 6, 7, 8, 9, 11, 12, 13, 14, 15 };
            int toplaDizi3 = Topla(dizi3);
            //for (int i = 0; i < dizi3.Length; i++)
            //{
            //    toplaDizi3 = toplaDizi3 + dizi3[i];
            //}

            Console.WriteLine("Dizi-1:" + toplaDizi1);
            Console.WriteLine("Dizi-2:" + toplaDizi2);
            Console.WriteLine("Dizi-3:" + toplaDizi3);
        }


        /// <summary>
        /// Verilen int dizisinin elemanlarını toplar
        /// </summary>
        /// <param name="dizi"></param>
        /// <returns></returns>
        static int Topla(int[] dizi)
        {
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
            }

            return toplam;
        }
    }
}
