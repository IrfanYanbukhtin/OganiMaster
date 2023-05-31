using OrganiMaster.DataAccessLayer.Entities;

namespace OrganiMaster.ViewModels
{
    public class HomeViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Department>? Departments { get; set; }
    }
}
