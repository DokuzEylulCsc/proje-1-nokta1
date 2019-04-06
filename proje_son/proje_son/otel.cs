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
            double oran1=0;//toplam doluluk oranı
            double oran2=0;//tek kisilik
            double oran3=0;//cift kisilik
            for (int i = 1; i < 11; i++)
            {

                if (TekKisilik[i] == 100)   //oda dolu ise
                {
                    sayac++;

                }


            }
            oran2 = (sayac/10.0)*100;
            for (int i = 1; i < 11 ; i++)
            {
                if (CiftKisilik[i] == 100)
                {
                    sayac2++;

                }

            }

           oran3 = (sayac2/10.0)*100;
            oran1 =(sayac+sayac2)/20.0*100;

            Console.WriteLine("Oteldeki genel doluluk orani:%" +oran1);
            Console.WriteLine("Tek kisilik odalardaki doluluk orani:%" +oran2);
            Console.WriteLine("Cift kisilik odalardaki doluluk orani:%" +oran3);
            return 0;
        }

    }
   
        }






