using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganiMaster.DataAccessLayer;
using OrganiMaster.ViewModels;

namespace OrganiMaster.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ProductsController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _dbContext.Products.ToListAsync();
            var department = await _dbContext.Departments.ToListAsync();


            var productViewModel = new ProductViewModel
            {
                Products = products,
                Departments = department,
            };
            

            return View(productViewModel);
        }

        public IActionResult Details(int? id)
        {
            return View();
        }
    }
}
