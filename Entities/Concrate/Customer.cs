using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
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