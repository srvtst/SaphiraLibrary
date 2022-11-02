using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.CustomerName).NotEmpty().WithMessage("Müşteri adı boş olamaz.");
            RuleFor(customer => customer.CustomerName).MinimumLength(5).WithMessage("Müşteri adı 5 karakterden boş olamaz.");
            RuleFor(customer => customer.Age).NotEmpty().WithMessage("Müşteri yaşı boş olamaz.");
        }
    }
}