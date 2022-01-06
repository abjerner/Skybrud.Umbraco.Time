# Skybrud.Umbraco.Time

**Skybrud.Umbraco.Time** is a small package for Umbraco 8 that adds three new property editors:

- [**Date Picker**](#date-picker) - returning an instance of [EssentialsDate](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/)
- [**Time Picker**](#time-picker) - returning an instance of [TimeOffset](https://github.com/abjerner/Skybrud.Umbraco.Time/blob/master/src/Skybrud.Umbraco.Time/Models/TimeOffset.cs)
- [**UNIX Timestamp**](#unix-timestamp) - returning an instance of [EssentialsTime](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialstime)

While Umbraco already features a property editor for picking a date (or date and time), the property editors in this package handles more specific use cases (eg. the date picker will return EssentialsDate instead of DateTime).

## Installation

The Umbraco 9 version of this package is only available via [NuGet](https://www.nuget.org/packages/Skybrud.Umbraco.Time/2.0.0). To install the package, you can use either .NET CLI:

```
dotnet add package Skybrud.Umbraco.Time --version 2.0.0
```

or the older NuGet Package Manager:

```
Install-Package Skybrud.Umbraco.Time -Version 2.0.0
```

**Umbraco 8**  
For the Umbraco 8 version of this package, see the [**v1/main**](https://github.com/abjerner/Skybrud.Umbraco.Time/tree/v1/main) branch instead.

## Screenshots

*Examples of the date and time property editors respectively*
![image](https://user-images.githubusercontent.com/3634580/89598990-8d74f800-d85e-11ea-8272-317dcfd3ce37.png)

## Date Picker

The date picker uses Umbraco's own date picker view, but ensures that the view is configured for selecting a date without any time. The property editor should be used in situations where only the date matters, and as such it returns an instance of [EssentialsDate](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/) instead of the normal `DateTime`.

The `EssentialsDate` class comes from our [**Skybrud.Essentials** package](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialsdate/), which provides extended functionality for working with dates compared to `DateTime`.

Calling the `ToString` method on said class will result in a string representation of the date formatted using the [**ISO 8601** date format](https://en.wikipedia.org/wiki/ISO_8601), which is `yyyy-MM-dd` - eg. `2020-08-07`. The same format is used when serializing the value using [Json.NET](https://www.newtonsoft.com/json).

As of this time, the date picker currently doesn't have any prevalues (data type configuration).

## Time Picker

The time picker uses a custom view for letting editors pick a time without any relation to a specific date. The picker returns an instance of `TimeOffset` representing the selected time, and the `Hours` and `Minutes` properties can be used to read the selected selected time.

Calling the `ToString` method will result in a string representation of the date formatted as `HH:mm`. The `ToString` method is also used when serializing the value using [Json.NET](https://www.newtonsoft.com/json).

The output format of the `ToString` method can be controlled via the *Output format* prevalue option in the data type configuration. The format is that of the [TimeSpan](https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings) class in .NET. Notice that the format is different from that of the `DateTime` class, so a format like `hh\:mm` will result is something like `15:45` (which for `DateTime` would have been `HH:mm`).

![image](https://user-images.githubusercontent.com/3634580/89651798-c0ea6d80-d8c4-11ea-9061-2098428d8ee9.png)

## UNIX Timestamp

The UNIX timestamp property editor looks like the picker for date and time that ships with Umbraco, but instead of of saving the date and time as `DateTime` in the database, this property editor will save the date and time as a UNIX timestamp - which is the amount of seconds since the start of the UNIX epoch. And instead of `DateTime`, the property value type will instead be the [EssentialsTime](https://packages.skybrud.dk/skybrud.essentials/reference/time/essentialstime) class.

Aditionally, data types using this property editor may be configured to adjust the date and time to a specific time zone, which then is reflected in the `EssentialsTime` instance.

Calling the `ToString` method on a `EssentialsTime` will result in a string representation of the date and time formatted using the [**ISO 8601** date time format](https://en.wikipedia.org/wiki/ISO_8601), which is `yyyy-MM-ddTHH:mm:ssK` - eg. `1988-08-17T08:37:00+02:00`. The same format is used when serializing the value using [Json.NET](https://www.newtonsoft.com/json).
