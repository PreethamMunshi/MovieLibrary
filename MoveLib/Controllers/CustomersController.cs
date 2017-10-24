using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoveLib.Models;

namespace MoveLib.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new List<Customer>()
            {
                new Customer {Name = "Joe" },
                new Customer { Name = "Ben"}
            };


            return View(customer);
        }
    }
}