using Entities.Abstract;

namespace Entities.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Writer { get; set; }
    }
}