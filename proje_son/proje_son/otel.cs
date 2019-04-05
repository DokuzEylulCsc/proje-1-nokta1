using System;
namespace proje_son
{
    public class otel
    {
         
        public int[] TekKisilik = new int[10];
         
      public  int[] CiftKisilik = new int[10];
      

       public void Odadoldur()
        { int a = 1;
            int b =1;
            for(int i=1;i<=10;i++)//tek yataklı odalar  1 den 10 kadar çift yataklı odalar 11 den 20 ye kadar değer alıyor.
            {
                TekKisilik[i] = a;
                a++;
            }
            for(int j=11;j<=20;j++)//
            {
                CiftKisilik[j] = b;
                b++;
            }
        }


        public int Rezgonder(int x)  //Rezervasyon oda classına  gönderiliyor.
        {
            oda o = new oda();
            o.RezYap(x);
            Console.WriteLine("hello");
            return 0;
        }
        public int Rezİptalgonder(int m)//rez iptali oda classına gönderiliyor.(m hangi oda oldugu)
        {
            oda o1 = new oda();
            o1.Rezİptal(m);
            return 0;
        }

        public int DolulukOrani()
        {
            int sayac=0; //tek yataklı dolu oda sayısı
            int sayac2 = 0;//cift
            int oran1;//toplam doluluk oranı
            int oran2;//tek kisilik
            int oran3;//cift kisilik
            for(int i=0;i<10;i++)
            {
                if (TekKisilik[i] == 100)   //oda dolu ise
                {
                    sayac++;

                }
             }
            oran2 = sayac / 10;
            for (int i = 0; i < 10; i++)
            {
                if (CiftKisilik[i] == 100)
                {
                    sayac2++;

                }
            }
            oran3 = sayac2 / 10;
            oran1 = (sayac + sayac2) / 20;

            Console.WriteLine("Oteldeki genel doluluk orani:" + +oran1);
            Console.WriteLine("Tek kisilik odalardaki doluluk orani:" + +oran2);
            Console.WriteLine("Cift kisilik odalardaki doluluk orani:" + +oran3);

            return 0;
        }
    }
}
