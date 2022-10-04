# Acs Core

## Acs Project Core

Acs Core contains both AcsFinder and AcsDumper source.

## Features

- Dump process
- Dump all available processes
- Find differences between two or more files
- Find occurrences between two or more files
- Search something in one or more files

## How To Use

These are just some examples.

```sh
string[] results = AcsDumper.Dump(processesId);

foreach (string result in results)
{
    Assets.OpenFile(result);
}
```

```sh
results = AcsDumper.DumpAvailable();

foreach (string result in results)
{
    Assets.OpenFile(result);
}
```

```sh
string result = AcsFinder.GetDifferences(filesList);
Assets.OpenFile(result);
```

## Installation

Download the [nuget](https://www.nuget.org/packages/AcsCore) to use Acs Core in your own project

```sh
https://www.nuget.org/packages/AcsCore
```

or use the dll release version below.

## Release

You can download the latest version [here](https://github.com/HackingSgravato/Acs.Core/releases/tag/v1.0.0)

```sh
https://github.com/HackingSgravato/Acs.Core/releases/tag/v1.0.0
```

## Build

Acs Core requires [.Net 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) to be built.

You can use git clone and build your own copy

```sh
git clone https://github.com/HackingSgravato/Acs.Core.git
```

or you can download the zip

## Development

Want to contribute? Great!

Create a pull request.

Go here

```sh
https://github.com/HackingSgravato/Acs.Core/pulls
```

and click **New pull request**
