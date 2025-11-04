# UtilityKit
Utility library offering 250+ deterministic C# helper functions for strings, dates, math, collections, validation, and conversions.

```md
# Krayknot.UtilityKit

Utility library providing 250+ deterministic helper functions for strings, dates, math, collections, validation, random, and conversions.

## Features
- 70+ string utilities
- 30+ date utilities
- 40+ math utilities
- 40+ collection utilities
- Parsing & validation helpers
- Random & GUID helpers
- Pure static methods, no dependencies
- .NET 8 compatible

## Installation
Add the file to your project or reference the library.

```

dotnet add package Krayknot.UtilityKit   # if published as NuGet later

````

## Usage
```csharp
using Krayknot.UtilityKit;

var name = UtilityKit.Capitalize("hello");
var percent = UtilityKit.Percent(50, 200);
var weekend = UtilityKit.IsWeekend(DateTime.Now);
var items = UtilityKit.Shuffle(new[] {1,2,3,4});
````

## Example Methods

* `Capitalize(string)`
* `IsWeekend(DateTime)`
* `Clamp(int,min,max)`
* `Shuffle<T>(IEnumerable<T>)`
* `RandomInt(min,max)`
* `IsEmail(string)`
* `ToInt(string)`

## Project Structure

```
/Krayknot.UtilityKit
 ├─ UtilityKit.cs
 ├─ Krayknot.UtilityKit.csproj
 └─ LICENSE
```

## Contributing

Pull requests welcome. Keep utilities deterministic and dependency-free.

## Author

Created by **Kshitij Jhangra**

## License

MIT License — see `LICENSE`

```

Done.
```
