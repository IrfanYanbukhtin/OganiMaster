using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiMaster.DataAccessLayer;
using OrganiMaster.ViewModels;

namespace OrganiMaster.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var product = _dbContext.Products.ToList();
            var department = _dbContext.Departments.ToList();

            var homeViewModel = new HomeViewModel
            {
                Departments = department,
                Products = product,
            };


            return View(homeViewModel);
        }
    }
}
