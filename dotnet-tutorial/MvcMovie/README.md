Following MS Learn tutorial
https://learn.microsoft.com/en-gb/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-7.0&tabs=visual-studio 

1. Create MVC project
    - `mkdir <projectName>`
    - `dotnet new mvc -o <projectName>`

What is Dependency Injection
- design pattern
- technique for achieving Inversion of Control (IoC) between classes and their dependencies

## What MVC templates should and should not do:
### Controllers:
- Responsible for providing data required in order for a view template to render response

### Views:
Should:
- only work with the data that's provided by controller
- separation concerns ensures code is:
    - Clean
    - Testable
    - Maintainable

### Should not:
- do business logic
- interact with a db directly
