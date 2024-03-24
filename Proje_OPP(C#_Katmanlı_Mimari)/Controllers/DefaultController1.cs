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
        public IActionResult Index() 
        { 
            mesajlar();
            return View();
        }
    }
}
