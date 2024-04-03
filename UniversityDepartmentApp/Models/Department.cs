namespace UniversityDepartmentApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string departmentName { get; set; } = null!;
        public int? NumberOfStudents { get; set; }
        public int? NumberOfStaff { get; set; }
       public int UniversityId { get; set; }
        public University? University { get; set; } 
    }
}
