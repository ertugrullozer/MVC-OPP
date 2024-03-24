using Microsoft.AspNetCore.Mvc;
using Proje_OPP_C__Katmanlı_Mimari_.Ornekler;

namespace Proje_OPP_C__Katmanlı_Mimari_.Controllers
{
    public class DefaultController1 : Controller
    {

        //void İslemeler()
        //{
        
        //    Class1 c = new Class1();
        //    c.Topla();
        //}
        void mesajlar() 
        {

            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "merhaba proje denemeleri";
            ViewBag.m3 = "selamlar hi hello bonjour";
        }
        //Geriye değer döndüren metotlar

        int topla()
        {
            int s1 = 20;
            int s2 = 20;
            int sonuc =s1 + s2;
            return sonuc;
        }

        int cevre() 
        {
            int kısa = 10;
            int uzun= 20;
            int c = 2 * (kısa + uzun);
            return c;
        }

        public IActionResult Index() 
        { 
            mesajlar();
            return View();
        }

        public IActionResult Urunler() 
        {
            mesajlar(); 
            ViewBag.t=topla();
            ViewBag.c=cevre();
            return View();
        }

       

    }
}
