# Skybrud.Umbraco.Time

**Skybrud.Umbraco.Time** is a small package for Umbraco 8 that adds two new property editors:

- Date picker - returning an instance of [EssentialsDate](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/)
- Time picker - returning an instance of [TimeOffset](https://github.com/abjerner/Skybrud.Umbraco.Time/blob/master/src/Skybrud.Umbraco.Time/Models/TimeOffset.cs)

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

