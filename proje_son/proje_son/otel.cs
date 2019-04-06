using System;
namespace proje_son
{
    public  class otel
    {

        public static int[] TekKisilik = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static int[] CiftKisilik = { 0, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

         

        public  void Rezgonder(int x)  //Rezervasyon oda classına  gönderiliyor.
        {
            oda o = new oda();
            o.RezYap(x);


        }
        public int Rezİptalgonder(int m)//rez iptali oda classına gönderiliyor.(m hangi oda oldugu)
        {
            oda o1 = new oda();
            o1.Rezİptal(m);
            return 0;
        }

        public int DolulukOrani()
        {
            int sayac = 0; //tek yataklı dolu oda sayısı
            int sayac2 = 0;//cift
            double oran1;//toplam doluluk oranı
            double oran2;//tek kisilik
            double oran3;//cift kisilik
            for (int i = 0; i < 10; i++)
            {

                if (TekKisilik[i] == 100)   //oda dolu ise
                {
                    sayac++;

                }
            }
            oran2 = 10 / sayac;
            for (int i = 0; i < 10; i++)
            {
                if (CiftKisilik[i] == 100)
                {
                    sayac2++;

                }
            }
            oran3 = 10 / sayac2;
            oran1 = 20 / (sayac + sayac2);

            Console.WriteLine("Oteldeki genel doluluk orani:" + +oran1);
            Console.WriteLine("Tek kisilik odalardaki doluluk orani:" + +oran2);
            Console.WriteLine("Cift kisilik odalardaki doluluk orani:" + +oran3);

            return 0;
        }

    }
   
        }






