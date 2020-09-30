using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzzProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/api/fizzbuzz")]
        public ActionResult<string> Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

    }
}
