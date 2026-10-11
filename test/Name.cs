namespace NameTests;

using ColdLeopard.DataContracts;

public class Tests
{
    [Test]
    public void FirstNameLastNamePasses()
    {
	Name n = new Name("John", "Smith");
	NameValidator validator = new NameValidator();
	var result = validator.Validate(n);
	Assert.That(result.IsValid, Is.True);
    }
    [Test]
    public void NoFirstNamePasses()
    {
	Name n = new Name(null, "Smith");
	NameValidator validator = new NameValidator();
	var result = validator.Validate(n);
	Assert.That(result.IsValid, Is.True);
    }
    [Test]
    public void NoLastNameFails()
    {
	Name n = new Name("John", null);
	NameValidator validator = new NameValidator();
	var result = validator.Validate(n);
	Assert.That(result.IsValid, Is.False);
    }
}
