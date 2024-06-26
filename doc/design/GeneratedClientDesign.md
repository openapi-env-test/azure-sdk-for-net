# Generated Client Design

## Introduction

This document tracks design rules and decisions for .NET clients generated by the DPG generator.  It may later be extended to include other generator designs.

<!--
## Clients

TBD

## Client Protocol Operations

TBD

## Client Convenience Operations
-->

## Model Generation

Models are defined as partial classes with one or more constructors, properties, and methods that read from/write to wire formats.

##### Discussion Notes
The .NET team discourages using C# Records in public APIs, so we will not use them for model types.

### Model Namespace

Generated models will be defined in a `.Models` namespace.
##### Discussion Notes

Tracking finalization of namespace decision [autorest.csharp #2514](https://github.com/Azure/autorest.csharp/issues/2514)

### Type mappings from Cadl to .NET

The following table shows a mapping from Cadl built-in types to the corresponding types used in .NET models.

Cadl Type | .NET Type | OpenAPI Type | GitHub Issue | Notes
------------------- | -------- | -- | -- | -------------
string | string | string | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) | [PrimitivePropertyModel.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-model-primitive-properties/sdk/template/Azure.Template/src/Generated/Models/PrimitivePropertyModel.cs) [PrimitivePropertyModel.Serialization.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-model-primitive-properties/sdk/template/Azure.Template/src/Generated/Models/PrimitivePropertyModel.Serialization.cs)
bytes | BinaryData | type: string, format: byte | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
int32  | int | type: integer, format: int32 | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
int64  | long | type: integer, format: int64 | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
safeint  | long | n/a | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
float32  | float | type: number, format: float | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
float64  | double | type: number, format: double | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
zonedDateTime  | DateTimeOffset | type: string, format: date-time | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) | Serialized differently based on body/header
duration  | TimeSpan | type: string, format: duration | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
boolean  | bool | boolean | [autorest.csharp #2337](https://github.com/Azure/autorest.csharp/issues/2337) |
<!-- TBD | TBD | type: string, format: binary | [autorest.csharp #2500](https://github.com/Azure/autorest.csharp/issues/2500)| -->

### Model Shape

Model APIs will differ depending on whether the model is an input model, an output model, or a round-trip model (both input and output).

The following describes the model shapes for different cases of properties.

 Item |  Input | Output | Round-Trip | GitHub Issue
-- | -------| ------------ | -------- | -- |
Constructor Accessibility | public | internal | public |
Required Property | get-only | get-only | get/set | [autorest.csharp #2463](https://github.com/Azure/autorest.csharp/issues/2463)
Optional Property | get/set | get-only | get/set | [autorest.csharp #2339](https://github.com/Azure/autorest.csharp/issues/2339)
Collection Property | `IList<T>` get-only | `IReadOnlyList<T>` get-only | `IList<T>` get-only | [autorest.csharp #2471](https://github.com/Azure/autorest.csharp/issues/2471)

### Model Constructors

Models have one or more constructors as follows.

#### Main Constructor

- Accessibility is specified in model shape table above
- Takes required parameters and does not take optional parameters
- Validates required reference type parameters for null using `Argument.AssertNotNull`
- Takes list properties as `IEnumerable<T>` parameters
- Initializes lists from `IEnumerable` parameter using System.Linq `.ToList()`

#### Serialization Constructor

- Internal accessibility
- Generated for Output and Round-trip types
- Takes required and optional parameters
- Takes list properties as `IReadOnlyList<T>` parameters for Output models and `IList<T>` parameters for Round-trip models
- List properties are initialized by assignment

See examples:

- Reference and value type properties:
  - [RoundTripModel.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-roundtrip-basic/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.cs)
  - [RoundTripModel.Serialization.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-roundtrip-basic/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.Serialization.cs)
- Collection properties:
  - [RoundTripModel.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-collections-basic/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.cs)
  - Collection properties [RoundTripModel.Serialization.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-collections-basic/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.Serialization.cs)

### Collections

There are a number of outstanding open issues regarding how to represent collections being tracked:

- [autorest.csharp #2515](https://github.com/Azure/autorest.csharp/issues/2515)
- [autorest.csharp #2513](https://github.com/Azure/autorest.csharp/issues/2513)

### Enums

Enums may be generated as a CLR enum or a C# "Strongly-typed string" as follows.

- Enums are generated in the same namespace as models.
- A Cadl `enum` not found in a corresponding  `@knownValues` decorator is generated as a C# `enum`
- Generated enum has corresponding internal extensions file providing conversions to/from string.
- A Cadl string model with a `@knownValues` decorator is generated as a C# "Strongly-typed string" (sometimes called "extensible enum") and the corresponding Cadl `enum` is not generated as a C# `enum`

GitHub issue: [autorest.csharp #2477](https://github.com/Azure/autorest.csharp/issues/2477)

See examples:

- CLR enum:
  - [DayOfTheWeek.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-enum-properties/sdk/template/Azure.Template/src/Generated/Models/DayOfTheWeek.cs)
  - [DayOfTheWeek.Serialization.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-enum-properties/sdk/template/Azure.Template/src/Generated/Models/DayOfTheWeek.Serialization.cs)
- Stronly typed string (extensible enum):
  - [TranslationLanguage.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-enum-properties/sdk/template/Azure.Template/src/Generated/Models/TranslationLanguage.cs)
  - No corresponding .Serialization.cs file.

### Nested Models

Models that are properties of other models are called nested models.  A model that appears only as a non-root of a model graph is defined as partial class according to the same rules as root models.

GitHub issue: [autorest.csharp #2489](https://github.com/Azure/autorest.csharp/issues/2489)

See examples:

- [RoundTripModel.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-nested-models/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.cs)
- [RoundTripModel.Serialization.cs](https://github.com/annelo-msft/azure-sdk-for-net/blob/cadl-models-nested-models/sdk/template/Azure.Template/src/Generated/Models/RoundTripModel.Serialization.cs)

Requirements for model graphs with circular dependencies will be defined in a later iteration.  GitHub issue [autorest.csharp #2506](https://github.com/Azure/autorest.csharp/issues/2506)

#### Nested Model Shape

Models that appear as properties of other models have their shape determined as follows:

- Models that only appear as properties of input models are input models
- Models that only appear as properties of output models are output models
- Models that only appear as properties of round-trip models are round-trip models
- Models that appear as properties of more than one model shape are round-trip models

### Model Reference Documentation

### Miscellaneous

- Models should be generated with the `#nullable disable` because Azure SDK libraries have not yet exposed nullable reference types outside of Azure.Core.  The reason we have not done this is because the API compatibility tools we use cannot detect API breaking changes to nullable reference types.
