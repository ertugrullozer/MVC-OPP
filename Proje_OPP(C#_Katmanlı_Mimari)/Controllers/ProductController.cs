using Microsoft.AspNetCore.Mvc;
using Proje_OPP_C__Katmanlı_Mimari_.ProjeContext;

namespace Proje_OPP_C__Katmanlı_Mimari_.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            var values=context.Products.ToList();
            return View(values);
        }
    }
}
