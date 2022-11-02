using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
    }
}