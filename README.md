# Automation Exercise - Playwright .NET

A Playwright .NET (MSTest) test automation suite for [automationexercise.com](https://automationexercise.com), covering user registration, login, e-commerce functionality, and form submissions.

## Project Overview

- **Framework**: Playwright for .NET
- **Test Runner**: MSTest
- **.NET Version**: .NET 8.0
- **Test Count**: 15 comprehensive test cases
- **Page Object Pattern**: Implemented with BasePage abstraction

## Test Coverage

- User registration (valid/invalid/duplicate email)
- Login scenarios (correct/incorrect credentials)
- Logout functionality
- Product browsing and search
- Shopping cart operations
- Checkout validation
- Contact form submission
- Page navigation and verification

## Prerequisites

- .NET 8.0 SDK or later ([download](https://dotnet.microsoft.com/download))
- Visual Studio 2022, VS Code, or any .NET-compatible IDE

## Setup & Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/AndreiC97/automation-exercise-playwright.git
   cd AutomationExercise
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Install Playwright browsers** (run once)
   ```bash
   pwsh bin/Debug/net8.0/playwright.ps1 install
   ```
   Or on Linux/macOS:
   ```bash
   bash bin/Debug/net8.0/playwright.sh install
   ```

## Running Tests

**Run all tests:**
```bash
dotnet test
```

**Run specific test class:**
```bash
dotnet test --filter "ClassName=AutomationExercise.Tests.TestCase01_RegisterUser"
```

**Run with verbose output:**
```bash
dotnet test --verbosity detailed
```

**Run in headed mode** (see browser):
Add to `launchSettings.json` or set environment variable:
```bash
HEADED=1 dotnet test
```

## Project Structure

```
AutomationExercise/
├── Pages/              # Page Object Model classes
│   ├── BasePage.cs
│   ├── HomePage.cs
│   ├── LoginPage.cs
│   ├── SignupPage.cs
│   ├── ProductsPage.cs
│   └── ContactUsPage.cs
├── Tests/              # Test cases
│   ├── BaseTest.cs     # Test setup/teardown
│   └── TestCase01-15.cs
├── Utilities/          # Helper classes
│   └── TestData.cs
└── AutomationExercise.csproj
```

## Troubleshooting

- **Playwright not found**: Run `dotnet build` before installing browsers
- **Tests timeout**: Increase timeout in BaseTest.cs Setup() if needed
- **Consent banner issues**: BaseTest handles common consent popups automatically

## Dependencies

- Microsoft.Playwright (1.54.0)
- Microsoft.Playwright.MSTest (1.54.0)
- MSTest.TestFramework (3.5.1)
- Microsoft.NET.Test.Sdk (17.10.0)
