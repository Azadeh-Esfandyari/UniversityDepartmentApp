namespace UniversityDepartmentApp.Models
{
    public class University
    {
        public int Id { get; set; }
        public string UniversityName { get; set; } = null!;
        public String? Address { get; set; }
      public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
    
}
