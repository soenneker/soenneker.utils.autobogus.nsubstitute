[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.nsubstitute.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.nsubstitute/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.nsubstitute/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.nsubstitute.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.nsubstitute/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus.NSubstitute
### An AutoFakerBinder for interfaces and abstract objects using NSubstitute

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus.NSubstitute
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new NSubstituteAutoFakerBinder()
};
```