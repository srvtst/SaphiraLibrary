using Entities.Concrete;
using FluentValidation;

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