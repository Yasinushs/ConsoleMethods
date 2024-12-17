namespace D1_1_methods_nedir//Proje
{
    internal class Program//Sayfa
    {
        static void Main(string[] args)//Method
        {
            Console.WriteLine("Hello, World!");
            //Method Nedir=> 
            //2+3=> sayi1+sayi2
            //Her defasında lazım olan kodları tekrar tekrar yazmak yerine onu bir method kod parçacığınıın içine dinamik olarak kolarız ve bu kod her lazım olduğunda yeniden yazmak yerine Methodu çağırıp kullanırız

            //Console.WriteLine("Yasin");
            //Console.WriteLine("Yasin");
            //Console.WriteLine("Yasin");
            //Console.WriteLine("Yasin");
            //Console.WriteLine("Yasin");
            AdYaz();
            AdYaz();
            AdYaz();
            AdYaz();
            //Main ana methodtur. Yardımcı method yazarken , yardımcı methodların çalışması için ana metgod içinde çağrılması gereklidir
            /*
             static void Main(string[] args)=> Ana Method yapısını tanıyalım!!!
            static=> Ram bölgesidir. Ram in dinamik alanını temsil eder. static bazı özelliklere sahiptir
            1) static bir method içinde ancak static bir method çağrılabilir.static olmayan bir method içinde static method çağrılabilir
            2)void=> method biçimini/tipini ifade eder. 2 tür method vardır. Değer döndürmeyen(void) ve değer döndüren(return) methodlar vardır
            3)(string[] args)=> methodun parametresidir. Parametre dışarıdan girilen değer demektir. Parametre konunun içinde bakılacaktır
            4)süslü parantezler {} methodun kod gövdesini gösterir
             
             */


        }


        static void AdYaz()
        {
            Console.WriteLine("Yasin");
        }

        void Toplama()//Method
        {
            AdYaz();
        }

        static void Fark()
        {

        }

    }
}
