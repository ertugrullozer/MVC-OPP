using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Proje_OPP_C__Katmanlı_Mimari_.Entity;

namespace Proje_OPP_C__Katmanlı_Mimari_.Ornekler
{
    //Sınıfların içerisindeki Öğeleri erişim sağlamak için 
    //Sınıftan bir nesne türetilir
    //sınıfadı nesneadı=new sınıfadı();
    public class Class1
    {
       public void Topla()
        {
            int sayi1 = 10;
            int sayi2=20;
            int sonuc=sayi2 + sayi1;

        }
        void Carp()
        {
            int s1 = 10;
            int s2 = 20;
            int carp= s1 * s2;
        }
      
        
    }
}
