namespace ColdLeopard.DataContracts;

using FluentValidation;

public class Customer
{
    public int CustomerNumber { get; init; } 
    public Name Name { get; init; } 
    public Customer(int customerNumber, string firstName, string lastName){
	CustomerNumber = customerNumber;
	Name = new Name(firstName, lastName);
    }
}


public class CustomerValidator: AbstractValidator<Customer> {
    public CustomerValidator()
    {
	RuleFor(customer => customer.CustomerNumber)
	    .NotNull()
	    .SetValidator(new CustomerNumberValidator());
	RuleFor(customer => customer.Name)
	    .NotNull()
	    .SetValidator(new NameValidator());
    }
}
