using Microsoft.AspNetCore.Mvc;
using Proje_OPP_C__Katmanlı_Mimari_.Entity;
using Proje_OPP_C__Katmanlı_Mimari_.ProjeContext;

namespace Proje_OPP_C__Katmanlı_Mimari_.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
           
            var values=context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct() 
        { 
        
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p) 
        {
            context.Add(p);   
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
