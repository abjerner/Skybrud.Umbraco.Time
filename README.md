# Skybrud.Umbraco.Time

**Skybrud.Umbraco.Time** is a small package for Umbraco 8 that adds two new property editors:

- [**Date picker**](#date-picker) - returning an instance of [EssentialsDate](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/)
- [**Time picker**](#time-picker) - returning an instance of [TimeOffset](https://github.com/abjerner/Skybrud.Umbraco.Time/blob/master/src/Skybrud.Umbraco.Time/Models/TimeOffset.cs)

While Umbraco already features a property editor for picking a date (or date and time), the two property editors in this package handles more specific use cases (eg. the date picker will return EssentialsDate instead of DateTime).

## Installation

**Install via NuGet**  
This is the recommended approach, as you install the [**NuGet Package**][NuGetPackage] in your Visual Studio project, and NuGet takes care of the rest.

```
Install-Package Skybrud.Umbraco.Time -pre
```
**Umbraco package**  
Download the package from Our Umbraco - the Umbraco cummunity website:

- <a href="https://our.umbraco.com/packages/backoffice-extensions/skybrud-time/" target="_blank"><strong>Download Umbraco package</strong></a>

**Manual install**  
You can also download a ZIP file of the latest release directly from GitHub, unzip, and move the contents to the root directory of your web application.

1. [**Download ZIP file**][GitHubRelease]  
  Download the ZIP file directly from here on GitHub. The ZIP contains all necessary files to run the package.

2. **Unzip**  
  Unzip and move the contents to the root directory of your web application.
  

[NuGetPackage]: https://www.nuget.org/packages/Skybrud.Umbraco.Time
[GitHubRelease]: https://github.com/abjerner/Skybrud.Umbraco.Time/releases

## Screenshots

*Examples of the date and time property editors respectively*
![image](https://user-images.githubusercontent.com/3634580/89598990-8d74f800-d85e-11ea-8272-317dcfd3ce37.png)

## Date picker

The date picker uses Umbraco's own date picker view, but ensures that the view is configured for selecting a date without any time. The property editor should be used in situations where only the date matters, and as such it returns an instance of [EssentialsDate](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/) instead of the normal `DateTime`.

The `EssentialsDate` class comes from our [**Skybrud.Essentials** package](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/), which provides extended functionality for working with dates compared to `DateTime`.

Calling the `ToString` method on said class will result in a string representation of the date formatted using the [**ISO 8601** date format](https://en.wikipedia.org/wiki/ISO_8601), which is `yyyy-MM-dd` - eg. `2020-08-07`. The same format is used when serializing the value using [Json.NET](https://www.newtonsoft.com/json).

As of this time, the date picker currently doesn't have any prevalues (data type configuration).

## Time picker

The time picker uses a custom view for letting editors pick a time without any relation to a specific date. The picker returns an instance of `TimeOffset` representing the selected time, and the `Hours` and `Minutes` properties can be used to read the selected selected time.

Calling the `ToString` method will result in a string representation of the date formatted as `HH:mm`. The `ToString` method is also used when serializing the value using [Json.NET](https://www.newtonsoft.com/json).

The output format of the `ToString` method can be controlled via the *Output format* prevalue option in the data type configuration. The format is that of the [TimeSpan](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings) class in .NET. Notice that the format is different from that of the `DateTime` class, so a format like `hh\:mm` will result is something like `15:45` (which for `DateTime` would have been `HH:mm`).

![image](https://user-images.githubusercontent.com/3634580/89651798-c0ea6d80-d8c4-11ea-9061-2098428d8ee9.png)
