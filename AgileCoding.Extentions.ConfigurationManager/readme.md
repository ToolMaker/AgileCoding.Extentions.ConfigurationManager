AgileCoding.Extensions.ConfigurationManager
===========================================

Overview
--------

AgileCoding.Extensions.ConfigurationManager is a .NET 6.0 library that provides useful extensions for the ConfigurationManager functionality.

Installation
------------

This library is available as a NuGet package. You can install it using the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.ConfigurationManager`

Features
--------

The library provides a functionality to obtain the configuration of a DLL. This can be beneficial in different scenarios where you need to access the configuration data for a specific DLL.

Usage
-----

Here's an example of how to use this feature:

```csharp
using AgileCoding.Extentions.ConfigurationManagers;
using System.Configuration;

string DLLName = "yourDLLName.dll";

// Get DLL Configuration
Configuration config = ConfigurationManagerExtentions.GetDLLConfiguration(DLLName);

// Now you can use the 'config' object for further operations...
```

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.ConfigurationManager/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.ConfigurationManager/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.ConfigurationManager/blob/main/CONTRIBUTING.md) for more details.