# Country Management CRUD (Work in Progress)

A learning project for building a country management application with C# and ASP.NET Core. The project is in progress; the current repository contains the initial solution structure and service contracts, while the country creation behavior and user-facing CRUD features remain to be implemented.

## Current progress

- Set up a .NET 10 solution with separate projects for the web app, domain entities, service contracts, services, and unit tests.
- Added a `Country` domain model with a GUID identifier and country name.
- Added request and response DTOs, including conversion helpers between DTOs and the domain model.
- Defined an `ICountryService` contract for adding a country.
- Added initial xUnit test cases describing expected behavior for null requests, missing names, duplicate names, and successful creation.
- Added the ASP.NET Core application entry point and static-file/routing setup.

## Current limitations

- `CountriesService.AddCountry` is not implemented yet and currently throws `NotImplementedException`.
- The service is not registered in dependency injection, and there are no country controllers or CRUD screens yet.
- The test cases are a specification of intended behavior; they have not been run or verified.
- No persistence layer or database has been added.

## Solution layout

| Project | Responsibility |
| --- | --- |
| `CRUDExample` | ASP.NET Core web application entry point |
| `Entities` | Domain models |
| `ServiceContracts` | Service interfaces and request/response DTOs |
| `Services` | Business logic implementation (currently a stub) |
| `CRUDTests` | xUnit test project |

## Run locally

Requires the .NET 10 SDK.

```bash
dotnet run --project CRUDExample/CRUDExample.csproj
```

Run the current test project after implementing the service behavior:

```bash
dotnet test CRUDTests/CRUDTests.csproj
```

The test command is provided for convenience; the tests have not been run as part of this project snapshot.

## Planned next steps

1. Implement country-name validation, duplicate detection, and creation behavior in `CountriesService`.
2. Add the service to dependency injection and build the country endpoints or MVC screens.
3. Choose and add a persistence approach.
4. Implement the remaining create, read, update, and delete workflows.
5. Run the test suite and expand coverage as the features are added.
