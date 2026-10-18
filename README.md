# Data Contracts Library

This library defines common structs and DTOs, and provides formatting validation
to ensure basic data integrity using [FluentValidation](https://docs.fluentvalidation.net/en/latest/)

## Validating Objects

Each Object in this project has an associated "Validator" class. Can perform validation by
creating an instance of the approriate validator, and calling its `validate` method, passing
the object you want validated. This will return a `validationResult` which can be acted on
as seen below

```csharp
Customer c = new Customer(/*parameters here*/);
CustomerValidator validator = new CustomerValidator();
ValidationResult result = validator.Validate(c);
if(result.isValid) {
 /// Do Thing
}
else {
    foreach(ValidationFailure failure in results.Errors) }
        // Handle failure
    }
}
```

## Contributing

### Writing Validation

Validation should be limited to data formatting. Do not, for example, check if a customer
number already exists in a database.

### Versioning

This project uses [SemVer 2.0](https://semver.org/) managed automatically by [Semantic Release](https://semantic-release.org/)

### Tests

Tests are located in the [test](./test/) folder, and can be run using `just test` if user has
[just](https://github.com/casey/just) installed.

### Git Hooks

Git Hooks are configured via Husky. Can configure Husky for your repo using `just prepare`

### Commits

Commits are standardized using Commitizen and CommitLint. Using `just commit` will
initialize an interactive `Commitizen` prompt to write your commit message. Commits
that fail to follow the desired format will be rejected by Git hooks locally, or
else by the CI pipeline
