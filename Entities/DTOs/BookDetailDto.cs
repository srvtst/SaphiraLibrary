using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BookDetailDto : IDto
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
    }
}