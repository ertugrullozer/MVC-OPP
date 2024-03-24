using Microsoft.AspNetCore.Mvc;
using Proje_OPP_C__Katmanlı_Mimari_.Entity;
using Proje_OPP_C__Katmanlı_Mimari_.ProjeContext;

namespace Proje_OPP_C__Katmanlı_Mimari_.Controllers
{
    public class CustomerController : Controller
    {
      Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet] 
        public IActionResult AddCustomer() 
        {
         return View();
        }

        [HttpPost] 
        public IActionResult AddCustomer(Customer p) 
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCustomer(int id) 
        {
            var delete = context.Customers.Where(x=>x.CustomerId == id).FirstOrDefault();
            context.Remove(delete);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) 
        {
            var value = context.Customers.Where(x=>x.CustomerId==id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var value = context.Customers.Where(x=>x.CustomerId==p.CustomerId).FirstOrDefault();
            value.CustomerName= p.CustomerName;
            value.City= p.City;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
