using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using club;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Class1.GetUser();
        }
        //public IActionResult Index()
        //{
        // return View();
        //}
    }
}
