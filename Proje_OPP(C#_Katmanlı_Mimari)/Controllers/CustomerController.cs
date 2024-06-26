﻿using Microsoft.AspNetCore.Mvc;
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
            if (p.CustomerName.Length>=6 && p.City != "" && p.City.Length >= 3)
            {
                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı Kullanım"; 
                return View();
            }
           
        }
        public IActionResult DeleteCustomer(int id) 
        {
            var delete = context.Customers.Where(x=>x.CustomerId == id).FirstOrDefault();
            context.Remove(delete);
            context.SaveChanges();
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
            value.City= p.City;
            value.CustomerName= p.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
