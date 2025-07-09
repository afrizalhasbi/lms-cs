
namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Uuid { get; }
        public String Name { get; set; }
        public DateTime CreatedAt { get; set; }

        protected BaseEntity(String name)
        {
            Uuid = Guid.NewGuid();
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
