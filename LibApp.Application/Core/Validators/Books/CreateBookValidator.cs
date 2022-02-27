using FluentValidation;
using LibApp.Application.UseCases.Books.Commands;

namespace LibApp.Application.Core.Validators
{
    public class CreateBookValidator : AbstractValidator<CreateBook.Command>
    {
        public CreateBookValidator()
        {
            RuleFor(a => a.Name)
               .NotEmpty().WithMessage("Field 'Name' is requried.");

            RuleFor(a => a.GenreId)
                .NotEmpty().WithMessage("Field 'Genre' is requried..");

            RuleFor(a => a.AuthorName)
               .NotEmpty().WithMessage("Field 'Author' is requried..");

            RuleFor(a => a.NumberInStock)
                .InclusiveBetween(1, 20).WithMessage("The stock quantity must be between 1 and 20");

            RuleFor(a => a.NumberInStock)
              .NotEmpty().WithMessage("Field 'Number in stock' is requried..");
        }
    }

}
