using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Lesson : BaseEntity
    {

        public Lesson(String name) : base(name)
        {
        }
    }
}
