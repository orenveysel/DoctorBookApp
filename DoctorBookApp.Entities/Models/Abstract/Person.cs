namespace DoctorBookApp.Entities.Models.Abstract
{
    public abstract class Person : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
