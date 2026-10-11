namespace ColdLeopard.DataContracts;

using FluentValidation;

/// <summary>Captures a "Name" as first and last name components</summary>
public readonly record struct Name(string FirstName, string LastName);



public class NameValidator: AbstractValidator<Name> {
    public NameValidator()
    {
	RuleFor(name => name.LastName)
	    .NotNull().NotEmpty().WithMessage("Last name is required");
    }
}
