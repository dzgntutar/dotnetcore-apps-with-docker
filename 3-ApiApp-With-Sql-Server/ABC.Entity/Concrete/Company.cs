using ABC.Core.Entities;

namespace ABC.Entity.Concrete
{
    public class Company : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
