# Html ResizeObserver
- A demo of this and all of my NuGet packages can be found [here](https://github.com/marqdouj/Blazor-Demos/).

## NuGet Package
https://www.nuget.org/packages/Marqdouj.Html.ResizeObserver/

Includes Blazor demo using the html ResizeObserver.

1.	Add the NuGet package to your project.
	1. `dotnet add package Marqdouj.Html.ResizeObserver`
2. Add the following to your `_Imports.razor` file.
	1. `@using Marqdouj.Html.ResizeObserver`
3. Add the following to your `Program.cs` file.
	1. `builder.Services.AddScoped<ResizeObserverService>();`

## Release Notes
### 9.0.2
- Update NuGet packages

### 9.0.1
- Added NuGet pkg icon
- 
### 9.0.0
- Updated to .NET 9.0
