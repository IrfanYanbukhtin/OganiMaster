using OrganiMaster.DataAccessLayer.Entities;

namespace OrganiMaster.ViewModels
{
    public class ContactViewModel
    {
        public List<Department>? Departments { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
