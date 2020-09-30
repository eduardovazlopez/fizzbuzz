using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzProject.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzzProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/api/fizzbuzz")]
        public ActionResult<IList<string>> Get()
        {
            List<string> result = new List<string>();
            FizzBuzzService.ExecuteFizzBuzz(result);
            return Ok(result);
        }

    }
}
