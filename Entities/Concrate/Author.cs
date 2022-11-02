using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Writer { get; set; }
    }
}