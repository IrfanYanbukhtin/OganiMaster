using OrganiMaster.DataAccessLayer.Entities;
namespace OrganiMaster.ViewModels
{
    public class ProductViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Department>? Departments { get; set; }
    }
}
