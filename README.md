# Project structure

## Code

### Initial setup

This is only of interest in case you want to setup a new project from scratch.

```sh
cd foo
dotnet add sln -n Demo
dotnet add classlib -o Demo
dotnet add xunit -o Demo.Tests
dotnet sln add Demo/Demo.csproj
dotnet sln add Demo.Tests/Demo.Tests.csproj
cd Demo.Tests
dotnet add reference ../Demo/Demo.csproj
dotnet add package FluentAssertions
dotnet add package StrykerMutator.DotNetCoreCli
```

#### Add CLI Tooling

Manually add the following line to `Demo.Tests.csproj`:

```xml
<DotNetCliToolReference Include="StrykerMutator.DotNetCoreCli" Version="0.8.2" />
```

The `ItemGroup` should look something like this (ignore the version numbers):

```xml
<ItemGroup>
    <PackageReference Include="FluentAssertions" Version="5.6.0" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.9.0" />
    <DotNetCliToolReference Include="StrykerMutator.DotNetCoreCli" Version="0.8.2" />
    <PackageReference Include="StrykerMutator.DotNetCoreCli" Version="0.8.2" />
    <PackageReference Include="xunit" Version="2.4.0" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.4.0" />
  </ItemGroup>
```

Run `dotnet restore` in folder `Demo.Tests` to ensure that the CLI tooling is available.

#### Check if setup works

```sh
# within `Demo.Tests` folder
dotnet test
dotnet stryker
```

Both commands should run.


