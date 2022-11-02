using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori ismi boş olamaz.");
            RuleFor(c => c.Name).MinimumLength(5).WithMessage("Kategori ismi minimum 5 karakterden oluşmalıdır.");
        }
    }
}