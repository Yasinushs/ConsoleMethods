namespace D2_5_deger_donduren_return_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayı");
            int s1=Convert.ToInt32(Console.ReadLine());
            //------------------------------------------------
            Console.WriteLine("2.sayı");
            int s2 = Convert.ToInt32(Console.ReadLine());


            int sumNumbers = Topla(s1, s2);

            Console.WriteLine("2 sayının toplamı:"+sumNumbers);

        }

        //Summary yorum satırı method okumaları için yapılır. Genelde methodun ne i yaptığını anlatmak için yazı yazılır
        /// <summary>
        /// Bu method 2 sayının toplamını yapar
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        static  int Topla(int d1,int d2)
        {
            int result = d1 + d2;
            return result;
            //return d1 + d2;

        }
    }
}
