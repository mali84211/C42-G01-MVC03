using C42_G01_MVC03.Models;
using Microsoft.AspNetCore.Mvc;

namespace C42_G01_MVC03.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly DepartmentsRepository _departmentRepository;
        public DepartmentsController(DepartmentsRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            var departments= _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
