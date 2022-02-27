using FluentValidation;
using FluentValidation.Results;
using LibApp.Application.UseCases.Customers.Commands;
using LibApp.Domain.Entities;
using System;

namespace LibApp.Application.Core.Validators
{
    public class UpdateCustomerValidator : AbstractValidator<UpdateCustomer.Command>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(a => a.Id).NotEmpty().WithMessage("Field 'Id' is required.");
            RuleFor(a => a.Name)
                .NotEmpty().WithMessage("Field 'Name' is required");
            RuleFor(a => a.Name)
                .MaximumLength(255).WithMessage("The name field can contain up to 255 characters.");

        }

        protected override bool PreValidate(ValidationContext<UpdateCustomer.Command> context, ValidationResult result)
        {
            var customer = context.InstanceToValidate;
            if (customer.MembershipTypeId == MembershipType.Unknown ||
                        customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return true;
            }

            if (customer.Birthdate == null)
            {
                result.Errors.Add(new ValidationFailure("", "Birthdate is required"));
                return false;
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            if (age >= 18)
                return true;
            else
            {
                result.Errors.Add(new ValidationFailure("", "Customer shoudl be at least 18 years old to subscribe"));
                return false;
            }
        }
    }
}
