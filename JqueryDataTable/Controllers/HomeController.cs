using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JqueryDataTable.Models;
using JqueryDataTable.EntityDbContext;
using Newtonsoft.Json;

namespace JqueryDataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public HomeController(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetData()
        {
            List<Customer> customers = applicationDbContext.Customers.ToList();
            return Json (new { data = customers });
        }

    }
}
