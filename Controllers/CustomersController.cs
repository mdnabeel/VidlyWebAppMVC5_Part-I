using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;

namespace VidlyWebApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }



        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private IEnumerable<Customers>GetCustomers()
        {
            return new List<Customers>
            {
                new Customers{Id=1, CustomerName="Alvaro Morte"},
                new Customers{Id=2, CustomerName="Will Smith"},
                new Customers{Id=3, CustomerName="Steve Smith"},
                new Customers{Id=4, CustomerName="Alba Flores"},
                new Customers{Id=5, CustomerName="Tony Stark"},
                new Customers{Id=6, CustomerName="Pedro Alonso"},
                new Customers{Id=7, CustomerName="Mary Williams"}
            };
        }



    }
}