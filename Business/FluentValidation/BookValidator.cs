using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookName).NotEmpty().WithMessage("Kitap ismi boş olamaz.");
            RuleFor(b => b.CategoryId).NotEmpty().WithMessage("Kategori ismi boş olamaz.");
            RuleFor(b => b.AuthorId).NotEmpty().WithMessage("Yazar ismi boş olamaz.");
        }
    }
}