namespace CustomerTests;

using ColdLeopard.DataContracts;

public class Tests
{
    private CustomerValidator validator;
    
    [SetUp]
    public void Setup()
    {
	validator = new CustomerValidator();
    }
    [Test]
    public void CustomerCorrect()
    {
	Customer c = new Customer(12, "John", "Smith");
	var result = validator.Validate(c);
	Assert.That(result.IsValid, Is.True);
    }
    [Test]
    public void IncorrectNumber()
    {
	Customer c = new Customer(13, "John", "Smith");
	var result = validator.Validate(c);
	Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo("Customer number must be between 100 and 999 inclusive"));
    }
}
