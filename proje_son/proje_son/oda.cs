using System;
namespace proje_son
{
    public class oda:otel
    {
       


            
     public void RezYap(int x)  //Rezervasyon gerçekleştiriliyor.
        {
            for (int i = 0; i < 10; i++)   //
            {
                if (x == TekKisilik[i]) //oda rezerve ediliyor. ve 100 e esitleniyor.
                {

                  

                    if (TekKisilik[i] == 100)
                    {
                        Console.WriteLine("Sectiginiz" + "" + i + "" + " numaralı oda rezerve EDİLEMEZ!!!");
                    }
                    else
                    {
                        Console.WriteLine("Sectiginiz" + "" + i + "" + "numaralı odayı rezerve ettiniz :)");
                    }

                    TekKisilik[i] = 100;
                }


            }

            Console.WriteLine(TekKisilik[5]);
            for (int  j= 0; j < 10; j++)//
            {
                if (x == CiftKisilik[j])
                {
                    CiftKisilik[j] = 100;
                    Console.WriteLine("Sectiginiz" + j + "numaralı odayı rezerve ettiniz...");
                }
                   
                }


        }


        public void Rezİptal(int m)// rez iptali gerçekleştiriliyor.
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
           

        }

    }
}
