# Unit Testing with .NET Core
Three different examples with different test frameworks:
* NUnitTestDemo & xUnitTestDemo: simple unit testing class methods in the same console applications
* UnitTestXunit: a full .NET Core solution with separated class library, test projects and console applications. Sample Code for [Techmaster blog article](https://techmaster.vn/posts/34532/unit-testing-ung-dung-c-dung-net-core-va-visual-studio-code)

## Run:

To run each examples, git clone and then `cd` into each example.
```bash
// run NunitTestDemo
cd NUnitTestDemo
dotnet test
```

## Install Dependencies

#### NUnitTestDemo & xUnitTestDemo:

Install packages manually:
```bash
// NUnit test framework
dotnet add package Microsoft.NET.Test.Sdk	
dotnet add package NUnit
dotnet add package NUnit.Console
dotnet add package NUnit3TestAdapter
```

```bash
// xUnit test framework
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
```

#### UnitTestXunit: 
Create test template with `dotnet new xunit` and it automatically adds packages. For more details, follow commands in the blog post.