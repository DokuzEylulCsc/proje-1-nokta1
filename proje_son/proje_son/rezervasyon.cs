using System;
namespace proje_son
{
    public class rezervasyon
    {
       
        public static void Rezerve(int x)
        {
            // rezervasyon istediğini otele iletiyor.
            otel.Rezgonder(x);

        }
        public static void Rezİp(int x)
        {
            otel.Rezİptalgonder(x);
            // rezervasyon iptal isteğini otele iletiyor.

        }

        public static void DolulukSor()
        {

            otel.DolulukOrani();
        }
        public static void RezGöster()
        {
            otel.RezGöster();
        }
    }
     
}
