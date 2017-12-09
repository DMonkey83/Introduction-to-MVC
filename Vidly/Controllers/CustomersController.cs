using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
  public class CustomersController : Controller
  {
    // GET: Customers
    public ActionResult Index()
    {
      var customers = GetCustomers();


      return View(customers);
    }

    public ActionResult Details(int id)
    {
      var customer = GetCustomers().SingleOrDefault(person => person.Id == id);

      if (customer == null)
      {
        return HttpNotFound();
      }

      return View(customer);
    }

    private IEnumerable<Customer> GetCustomers()
    {
      return new List<Customer>()
      {
        new Customer(){Id = 0, Name = "Einars"},
        new Customer(){Id = 1, Name = "Edite"},
        new Customer(){Id = 2, Name = "Daniels"},
        new Customer(){Id = 3, Name = "Alise"},
        new Customer(){Id = 4, Name = "Kristians"}
      };
    }
  }
}