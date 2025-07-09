using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Student : BaseEntity
    {
        public String Gender { get; }
        public List<Course>? Courses;
        public Student(String name, String gender) : base(name)
        {
            Gender = gender;
        }
    }
}
