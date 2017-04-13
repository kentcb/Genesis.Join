![Logo](Art/Logo150x150.png "Logo")

# Genesis.Join

[![Build status](https://ci.appveyor.com/api/projects/status/jj04jexicfocv1cd?svg=true)](https://ci.appveyor.com/project/kentcb/genesis-join)

## What?

> All Genesis.* projects are formalizations of small pieces of functionality I find myself copying from project to project. Some are small to the point of triviality, but are time-savers nonetheless. They have a particular focus on performance with respect to mobile development, but are certainly applicable outside this domain.
 
**Genesis.Join** adds a convenient `Join` extension method to `IEnumerable<string>`, allowing an enumerable of strings to be joined together with a configurable separator. It is delivered as a netstandard 1.0 binary.

## Why?

Joining strings in an enumerable is something I find myself needing to do quite often. When performed within a LINQ pipeline, it's more elegant and simpler to read using an extension method than using `string.Join` directly.

## Where?

The easiest way to get **Genesis.Join** is via [NuGet](http://www.nuget.org/packages/Genesis.Join/):

```PowerShell
Install-Package Genesis.Join
```

## How?

You can simply call `Join` against any `IEnumerable<string>`:

```C#
var customerNames = this
    .customers
    .Select(customer => customer.Name)
    .Join(", ");
```

## Who?

**Genesis.Join** is created and maintained by [Kent Boogaart](http://kent-boogaart.com). Issues and pull requests are welcome.