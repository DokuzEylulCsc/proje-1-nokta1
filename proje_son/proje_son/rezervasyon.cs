using System;
namespace proje_son
{
    public class rezervasyon
    {
       
        public void Rezerve(int x)
        {
            otel o1 = new otel();
          o1.Rezgonder(x);

        }
        public  void Rezİp(int x)
        {
            otel o1 = new otel();
            o1.Rezİptalgonder(x);

        }

        public void DolulukSor()
        {
            otel o1 = new otel();
            o1.DolulukOrani();
        }

    }
}
