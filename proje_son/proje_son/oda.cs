using System;
namespace proje_son
{
    public class oda:otel
    {
        otel o = new otel();
        public void RezYap(int x)  //Rezervasyon gerçekleştiriliyor.
        {
            for (int i = 0; i < 10; i++)   //
            {
                if (x == TekKisilik[i]) //oda rezerve ediliyor. ve 100 e esitleniyor.
                {
                    rezervasyon r = new rezervasyon();
                    TekKisilik[i] = 100;
                    Console.Write("Sectiginiz" + i + "numaralı odayı rezerve ettiniz...");
                    Console.WriteLine(i);
                }
               
            }

            for (int  j= 11; j < 20; j++)//
            {
                if (x == CiftKisilik[j])
                {
                    CiftKisilik[j] = 100;
                    Console.Write("Sectiginiz" + j + "numaralı odayı rezerve ettiniz...");
                }
                   
                }

            Console.WriteLine("Rezerve Etmek İstediğiniz Oda Doludur!!");

        }
        public int Rezİptal(int m)// rez iptali gerçekleştiriliyor.
        {
            for (int i = 0; i < 10; i++)
            {
                if (m == i)
                {
                    TekKisilik[i] = i;//m ile kullanıcı kacinci odayı rezerve etmiş oldugunu giriyor.
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (m == i)
                {
                    CiftKisilik[i] = i;
                }
            }
            return 0;
        }

    }
}
