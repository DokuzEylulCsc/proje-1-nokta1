using System;

namespace proje_son
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            String A;
            int secim;
            int kacinci=0;
            Console.WriteLine("Hosgeldiniz:");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz..");
            Console.WriteLine("1-Yeni Rezervasyon");
            Console.WriteLine("2-Rezervasyon Sil:");
            Console.WriteLine("3-Odaların Doluluk Oranlarını Göster");
            secim = Convert.ToInt16(Console.ReadLine());

            if(secim==1)  // rezervasyon yapma seceneği
            {    int x;
                rezervasyon r =  new rezervasyon();
                Console.WriteLine("Adınızı ve Soyadınızı Giriniz:");
                A = Console.ReadLine();
               
                kacinci++; //kacıncı rezervasyon oldugunu tutuyor.
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("***Tek yataklı odalarımızın numaraları 1-10 arasındadır.***");
                Console.WriteLine("***Cift yataklı odalarımızın numaraları 11-20 arasındadır.***");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Secmek istediginiz oda numarasını giriniz");

                x = Console.Read();
                r.Rezerve(x);


            }
            if(secim==2)//rezervasyon iptal
            {

                Console.WriteLine("Rezerve ettiğinin oda numarasını giriniz");
               
                otel o1 = new otel();
               
            }
            if(secim==3)
            {
                rezervasyon r1 = new rezervasyon();
                r1.DolulukSor();
            }
        }
    }
}
