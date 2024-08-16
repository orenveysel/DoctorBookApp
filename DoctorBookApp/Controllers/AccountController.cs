using DoctorBookApp.Entities.DbContexts;
using DoctorBookApp.Entities.Models.Concrete;
using DoctorBookApp.Models;
using DoctorBookApp.WebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorBookApp.WebMvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = _context.Customers.SingleOrDefault(c => c.NationalId == model.NationalId && c.Password == model.Password);
                if (customer != null)
                {
                    // Oturum açma işlemi
                    return RedirectToAction("Index", "Appointment");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Customers.Any(c => c.NationalId == model.NationalId))
                {
                    var customer = new Customer
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Password = model.Password, // Şifre hashleme eklenecek
                        BirthDate = model.BirthDate,
                        Gender = model.Gender,
                        NationalId = model.NationalId,
                        PhoneNumber = model.PhoneNumber
                    };

                    _context.Customers.Add(customer);
                    _context.SaveChanges();

                    return RedirectToAction("Login", "Account");
                }
                ModelState.AddModelError("NationalId", "This NationalId is already registered.");
            }

            return View(model);
        }
    }
}
