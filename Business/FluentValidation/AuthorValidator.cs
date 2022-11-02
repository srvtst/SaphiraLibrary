using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.Writer).NotEmpty().WithMessage("Yazar ismi boş olamaz.");
            RuleFor(a => a.Writer).MinimumLength(5).WithMessage("Yazar ismi minimum 5 karakterden oluşmalıdır.");
        }
    }
}