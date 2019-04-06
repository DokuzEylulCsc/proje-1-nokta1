using System;
namespace proje_son
{
    public class rezervasyon
    {
       
        public void Rezerve(int x)
        {
            otel o1 = new otel(); // rezervasyon istediğini otele iletiyor.
          o1.Rezgonder(x);

        }
        public  void Rezİp(int x)
        {
            otel o1 = new otel();
            o1.Rezİptalgonder(x);// rezervasyon iptal isteğini otele iletiyor.

        }

        public void DolulukSor()
        {
            otel o1 = new otel();
            o1.DolulukOrani();
        }

    }
}
