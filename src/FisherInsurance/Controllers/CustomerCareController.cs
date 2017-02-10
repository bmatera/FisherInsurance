using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsurance.Controllers
{
    
    public class CustomerCareController : Controller
    {
        [Route("customer")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //return Ok("This is the index of the CustomerCareController");
        }

        [Route("customer/claims")]
        // GET: /Customercare/Claims
        public IActionResult Claims()
        {
            return View();
            //return Ok("This is the /Customercare/Claims of the CustomercareController");
        }

        [Route("customer/fileclaim")]
        // GET: /Customercare/Claims
        public IActionResult NewClaim()
        {
            return View();
            //return Ok("This is the /Customercare/FileClaim of the CustomercareController");
        }


        [Route("customer/claimstatus")]
        // GET: /Customercare/Claims
        public IActionResult ClaimHistory()
        {
            return View();
            //return Ok("This is the /Customercare/claimstatus of the CustomercareController");
        }
    }
}
