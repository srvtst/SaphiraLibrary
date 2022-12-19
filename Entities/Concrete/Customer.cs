using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Job { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}