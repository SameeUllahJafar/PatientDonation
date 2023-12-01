using Microsoft.AspNetCore.Mvc;
using PatientDonation.web.Models;

namespace PatientDonation.web.Controllers
{
    public class Donations : Controller
    {
        private PDContext _context;


        public Donations(PDContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Donation()
        {
            var data = _context.Needies.ToList();

            return View(data);

        }
        [HttpGet]
        public IActionResult Donar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donar(Donar donar)
        {
         
            // Add Donar record
            _context.Donars.Add(donar);
            _context.SaveChanges();

            return RedirectToAction("Index", "Donations");

        }

    }
}

