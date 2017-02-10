using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsurance.Controllers
{
    public class LifeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //return Ok("This is the index of the LifeController");
        }

        // GET: /Life/Quote
        public IActionResult Quote()
        {
            return View();
            //return Ok("This is the /Life/Quote of the LifeController");
        }
    }
}
