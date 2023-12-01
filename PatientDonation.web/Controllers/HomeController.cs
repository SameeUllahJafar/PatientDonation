using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NuGet.Packaging.Signing;
using NuGet.Protocol.Plugins;
using PatientDonation.web.Models;
using System;
using System.Diagnostics;


namespace PatientDonation.web.Controllers
{
    public class HomeController : Controller
    {

        private PDContext _context;


        public HomeController(PDContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {


            return View();
        }
        public IActionResult Contact(Contact contact)
        {
            _context.contacts.Add(contact);
            _context.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            return View("About");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}