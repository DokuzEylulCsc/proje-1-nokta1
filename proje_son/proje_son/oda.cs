using System;
namespace proje_son
{
    public class oda:otel
    {
       


            
     public  int  RezYap(int x)  //Rezervasyon gerçekleştiriliyor.
        {
            int a;
            for (int i = 0; i < 10; i++)   //
            { if(TekKisilik[i]==100&&i==x)
                {
                    Console.WriteLine("Maalesef  "+  x  + ". odamız doludur... REZERVE EDİLEMEZ" );
                }

                if (x == TekKisilik[i]) //oda rezerve ediliyor. ve 100 e esitleniyor.
                {   
                    TekKisilik[i] = 100;
                    Console.WriteLine("Odamız müsait..");
                    Console.WriteLine("***Sectiginiz " + "" + i +" numaralı odayı rezerve ettiniz ***");
                    a = i;
                }


            }
            
           

            for (int j = 0; j < 10; j++)//
                {
                    if (x == CiftKisilik[j])
                    {
                        CiftKisilik[j] = 100;
                        Console.WriteLine("***Sectiginiz " + x + " numaralı odayı rezerve ettiniz...***");

                    }

                }

            return 0;

            }









        public void Rezİptal(int m)// rez iptali gerçekleştiriliyor.
        {

            for (int i = 0; i < 10; i++)
            {
                if (m == i && TekKisilik[i] == 100)
                {
                    TekKisilik[i] = i;//m ile kullanıcı kacinci odayı rezerve etmiş oldugunu giriyor.
                    Console.WriteLine("Rezervasyonunuzu iptal ettiniz..");

                }

            }
            for (int i = 11; i < 20; i++)
            {
                int a = 1;
                if (m == i && CiftKisilik[i] == 100)
                {
                    CiftKisilik[a] = i;
                    Console.WriteLine("Rezervasyonunuzu iptal ettiniz..");
                }
            }
           

        }

    }
}
