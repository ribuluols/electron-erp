﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using electron_poc.Models;

namespace electron_poc.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeModel _employeeModel = new EmployeeModel("Bill", "Developer");
        private readonly AddressModel _addressModel = new AddressModel("Two Microsoft Way", "Redmond","WA", "98052-6399", "425.555.0100");
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Workflow()
        {
            ViewData["Title"] = "Workflow";

            return View();

        }

        public IActionResult Summary()
        {
            ViewData["Title"] = "Summary";

            return View();
        }

        public IActionResult Inventory()
        {
            ViewData["Title"] = "Inventory";

            return View();
        }

        public IActionResult PurchaseOrders()
        {
            ViewData["Title"] = "Purchase Orders";

            return View();
        }

        public IActionResult ServiceCalls()
        {
            ViewData["Title"] = "Service Calls";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";
            ViewData["Message"] = "Your application description page.";
            ViewData["Name"] = _employeeModel.Name;
            ViewData["Position"] = _employeeModel.Position;
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["Message"] = "Your contact page.";
            ViewData["Address1"] = _addressModel.AddressLine1;
            ViewData["City"] = _addressModel.City;
            ViewData["State"] = _addressModel.State;
            ViewData["Zip"] = _addressModel.Zip;
            ViewData["Phone"] = _addressModel.Phone;
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}