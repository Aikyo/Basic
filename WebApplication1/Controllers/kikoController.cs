using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class kikoController : Controller
    {
        public IActionResult Index()
        {
            var context = new context();
            HealthCheckOrder order = context.Order.First();
            return View(order);
        }
    }
}