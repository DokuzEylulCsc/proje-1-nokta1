using System;

namespace proje_son
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            String A;
            int secim;
            do
            {
                Console.WriteLine("Hosgeldiniz:");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz..");
                Console.WriteLine("1-Yeni Rezervasyon");
                Console.WriteLine("2-Rezervasyon Sil:");
                Console.WriteLine("3-Odaların Doluluk Oranlarını Göster");
                Console.WriteLine("Çıkmak İcin 0 a  Basınız.");
                secim = Convert.ToInt16(Console.ReadLine());

                if (secim == 1)  // rezervasyon yapma seceneği
                {

                    rezervasyon r = new rezervasyon();
                    Console.WriteLine("Adınızı ve Soyadınızı Giriniz:");
                    A = Console.ReadLine();


                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("***Tek yataklı odalarımızın numaraları 1-10 arasındadır.***");
                    Console.WriteLine("***Cift yataklı odalarımızın numaraları 11-20 arasındadır.***");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Secmek istediginiz oda numarasını giriniz");
                    int x;
                    x = Convert.ToInt16(Console.ReadLine());
                    r.Rezerve(x);


                }
                if (secim == 2)//rezervasyon iptal
                {
                    rezervasyon r = new rezervasyon();
                    Console.WriteLine("Rezerve ettiğinin oda numarasını giriniz");
                    int x;
                    x = Convert.ToInt16(Console.ReadLine());
                    r.Rezİp(x);
                }
                if (secim == 3)
                {
                    rezervasyon r1 = new rezervasyon();
                    r1.DolulukSor();
                }

            } while (secim != 0);

        }
    }
}
