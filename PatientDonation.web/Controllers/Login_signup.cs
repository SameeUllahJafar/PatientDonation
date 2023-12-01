using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using PatientDonation.web.Models;

namespace PatientDonation.web.Controllers
{
    public class Login_signup : Controller
    {
        private PDContext _context;

        
        public Login_signup(PDContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Login login)
        {
            if (ModelState.IsValid)
            {
                _context.Logins.Add(login);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View();
           
        }
    }
       
    
}
