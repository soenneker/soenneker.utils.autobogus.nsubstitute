[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.nsubstitute.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.nsubstitute/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.nsubstitute/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.nsubstitute.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus.nsubstitute/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus.nsubstitute/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute/actions/workflows/codeql.yml)

# Soenneker.Utils.AutoBogus.NSubstitute

An NSubstitute binder that lets `Soenneker.Utils.AutoBogus` create and populate interfaces and abstract classes.

## Installation

```bash
dotnet add package Soenneker.Utils.AutoBogus.NSubstitute
```

## Usage

```csharp
var faker = new AutoFaker
{
    Binder = new NSubstituteAutoFakerBinder()
};

IOrderService service = faker.Generate<IOrderService>();
```

Concrete types continue to use AutoBogus's default construction path. Interface and abstract-type requests are created with NSubstitute, then their writable members are populated by AutoBogus where the generated proxy permits it. Retain the configured `AutoFaker` when generating repeatedly so its binder and reflection caches can be reused.
