using Entities.Concrete;
using FluentValidation;

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