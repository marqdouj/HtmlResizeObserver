# Html ResizeObserver

## NuGet Package
https://www.nuget.org/packages/Marqdouj.Html.ResizeObserver/

Includes Blazor demo using the html ResizeObserver.

1.	Add the NuGet package to your project.
	1. `dotnet add package Marqdouj.Html.ResizeObserver`
2. Add the following to your `_Imports.razor` file.
	1. `@using Marqdouj.Html.ResizeObserver`
3. Add the following to your `Program.cs` file.
	1. `builder.Services.AddScoped<ResizeObserverService>();`

## Usage
See the 'Demo' page in the demo project for a complete example of how to use the ResizeObserverService.

## Release Notes
### 9.0.1
- Added NuGet pkg icon
- 
### 9.0.0
- Updated to .NET 9.0