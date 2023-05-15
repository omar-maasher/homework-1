using Microsoft.AspNetCore.Mvc;
using rev_omar.Models;
using System.Diagnostics;

namespace rev_omar.Controllers;



public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Reverse(string n1)
    {
        
        
            
        if(n1 == null)
        {
            ViewBag.bag = "123";


        }
        else 
        {
            string rearay = "";

            for (int i = n1.Length - 1; i >= 0; i--)
            {
                rearay += n1[i];

            }

             ViewBag.bag = rearay;


        }
        return View("Index");

    }

}


