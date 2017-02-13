using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FisherInsurance.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsurance.Controllers
{
    public class AutoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //return Ok("This is the index of the AutoController");
        }

        // GET: /Auto/Quote
        public IActionResult Quote()
        {
            Quote quote = new Quote
            {
                Id = 345,
                Product = "Auto Insurance",
                ExpireDate = DateTime.Now.AddDays(45),
                Price = 45.00M

            };
            return View(quote);
            //return Ok("This is the auto/quote of the AutoController");
        }
    }
}
