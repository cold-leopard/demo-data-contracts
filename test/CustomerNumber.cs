namespace CustomerNumberTests;

using ColdLeopard.DataContracts;

public class Tests
{
    private CustomerNumberValidator validator;
    
    [SetUp]
    public void Setup()
    {
	validator = new CustomerNumberValidator();
    }
    [Test]
    ///<summary>Three digits is valid for a customer number</summary>
    public void ThreeDigitNumberPasses()
    {
	var result = validator.Validate(123);
	Assert.That(result.IsValid, Is.True);
    }
    [Test]
    ///<summary>Two digits is invalid for a customer number</summary>
    public void TwoDigitNumberFails()
    {
	var result = validator.Validate(99);
	Assert.That(result.IsValid, Is.False);
    }
    [Test]
    ///<summary>Four digits is invalid for a customer number</summary>
    public void FourDigitNumberFails()
    {
	var result = validator.Validate(1000);
	Assert.That(result.IsValid, Is.False);
    }
}
