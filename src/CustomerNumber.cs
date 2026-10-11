namespace ColdLeopard.DataContracts;

using FluentValidation;

/// <summary>Validates if an integer is formatted correctly to be used as a customer number</summary>
/// <remarks>Potential validation error codes are:
/// <list type="bullet">
///	<item><description>NotGreaterThanOrEqualTo</description></item>
///	<item><description>NotLessThan</description></item>
/// </list>
/// </remarks>
public class CustomerNumberValidator: AbstractValidator<int> {
    public CustomerNumberValidator()
    {
	RuleFor(customerNumber => customerNumber)
	    .GreaterThanOrEqualTo(100)
	    .WithMessage("Customer number must be between 100 and 999 inclusive")
	    .LessThan(1000)
	    .WithMessage("Customer number must be between 100 and 999 inclusive");
    }
}
