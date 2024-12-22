using UseCases.Communication.Requests.Register;

namespace UseCases.Application.UseCases.Expenses.Register;

public class Register 
{
    public void Execute(ExpenseJson request)
    {

    }

    public void Validate(ExpenseJson request)
    {
        var validator = new ExpensesValidator();

        validator.Validate(request);
    }
}