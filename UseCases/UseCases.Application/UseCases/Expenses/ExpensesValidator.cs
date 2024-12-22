using FluentValidation;
using UseCases.Communication.Requests.Register;

namespace UseCases.Application.UseCases.Expenses;

public class ExpensesValidator: AbstractValidator<ExpenseJson>
{
    public ExpensesValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
        RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
        RuleFor(x => x.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date cannot be in the future");
        RuleFor(x => x.PaymentType).IsInEnum().WithMessage("Payment type is invalid");
    }
}