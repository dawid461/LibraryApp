using FluentValidation;
using LibApp.Application.UseCases.Books.Commands;

namespace LibApp.Application.Core.Validators
{
    public class UpdateBookValidator : AbstractValidator<UpdateBook.Command>
    {
        public UpdateBookValidator()
        {
            RuleFor(a=>a.Id)
                .NotEmpty().WithMessage("Field 'ID' is required.");

            RuleFor(a => a.Name)
               .NotEmpty().WithMessage("Field 'Name' is required.");

            RuleFor(a => a.GenreId)
                .NotEmpty().WithMessage("Field 'Genre' is required.");

            RuleFor(a => a.AuthorName)
            .NotEmpty().WithMessage("Field 'Author' is required.");

            RuleFor(a => a.NumberInStock)
                .InclusiveBetween(1, 20).WithMessage("The stock quantity must be between 1 and 20");

            RuleFor(a => a.NumberInStock)
               .NotEmpty().WithMessage("Field 'Number in stock' is required.");
        }
    }
}
