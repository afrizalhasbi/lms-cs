using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Course : BaseEntity
    {
        public List<Lesson> Lessons;
        public float Progress = 0;

        public Course(String name) : base(name)
        // course constructors load from the database
        // implement orm here
        {
        }
    }
}
