using Microsoft.AspNetCore.Mvc;
using DoctorBookApp.BL.Manager.Abstract;
using DoctorBookApp.Entities.Models.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
//using DoctorBookApp.WebMvc.Models;
//using Microsoft.AspNetCore.Identity;

namespace DoctorBookApp.Controllers
{
    [Authorize(Roles = SD.Role_Customer)]
    public class AppointmentController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAppointmentManager _appointmentManager;
        private readonly IDoctorManager _doctorManager;
        private readonly ICustomerManager _customerManager;

        public AppointmentController(IAppointmentManager appointmentManager, IDoctorManager doctorManager, ICustomerManager customerManager) //, UserManager<ApplicationUser> userManager
        {
            //_userManager = userManager;
            _appointmentManager = appointmentManager;
            _doctorManager = doctorManager;
            _customerManager = customerManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            //var userId = User.Identity.Name;
            //var user = _userManager.FindByIdAsync(userId);
            ViewBag.Doctors = _doctorManager.GetAll();
            ViewBag.Customers = _customerManager.GetAll();
            //ViewBag.UserName = user.FirstName + " " + user.LastName; // Kullanıcı adı soyadı
            //ViewBag.UserId = user.Id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                
                _appointmentManager.Insert(appointment);
                return RedirectToAction("Index");
            }
            ViewBag.Doctors = _doctorManager.GetAll();
            ViewBag.Customers = _customerManager.GetAll();
            return View(appointment);
        }
    }
}

//using Microsoft.AspNetCore.Mvc;

//namespace DoctorBookApp.WebMvc.Controllers
//{
//    public class AppointmentController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }
//    }
//}
