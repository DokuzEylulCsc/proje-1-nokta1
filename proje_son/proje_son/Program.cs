using System;

namespace proje_son
{
    class MainClass
    { 
        public static void Main(string[] args)
        {

            String A;
            

            int secim;
            //int Manzaralimi;
            do
            {
                Console.WriteLine("Hosgeldiniz:");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz..");
                Console.WriteLine("1-Yeni Rezervasyon");
                Console.WriteLine("2-Rezervasyon Sil:");
                Console.WriteLine("3-Odaların Doluluk Oranlarını Göster");
                Console.WriteLine("4-Rezervasyonları Görüntüle");
                Console.WriteLine("Çıkmak İcin 0 a  Basınız.");
                secim = Convert.ToInt16(Console.ReadLine());// yapmak istediğimiz işlemi giriyoruz.

                if (secim == 1)  // rezervasyon yapma seceneği
                {

                   
                    Console.WriteLine("Adınızı ve Soyadınızı Giriniz:");
                    A = Console.ReadLine();

                    Console.WriteLine("Secenekli oda numaraları:");
                    Console.WriteLine("Tek kisilik Manzarasiz---->1-2");
                    Console.WriteLine("Tek kisilik Havuz Manzarali----->3-6");
                    Console.WriteLine("Tek kisilik Deniz Manzarali----->7-10");
                    Console.WriteLine("Cift kisilik Manzarasiz---->11-12");
                    Console.WriteLine("Cift kisilik Havuz Manzarali----->13-16");
                    Console.WriteLine("Cift kisilik Deniz Manzarali----->17-20");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Secmek istediginiz oda numarasını giriniz");
                    int x;
                    x = Convert.ToInt16(Console.ReadLine());// hangi odayı rezerve etmek istediğimizi giriyoruz.
                    rezervasyon.Rezerve(x);
                    Console.WriteLine("--------------------------------------------------------------");
                   
                   


                }
                if (secim == 2)//rezervasyon iptal
                {
                   
                    Console.WriteLine("Rezerve ettiğinin oda numarasını giriniz");
                    int x;
                    x = Convert.ToInt16(Console.ReadLine());
                    rezervasyon.Rezİp(x);
                }
                if (secim == 3)
                {

                    rezervasyon.DolulukSor();
                }
                if(secim==4)
                {

                    rezervasyon.RezGöster();
                }

            } while (secim != 0);
        }
    }
}
