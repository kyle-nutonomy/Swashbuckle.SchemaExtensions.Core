## Schema Extensions for Swashbuckle

### Example usage

```csharp
services.AddSwaggerGen(c =>
    {
        c.AddEnumTypeFilter();
    });
```

### Unit tests

In `test/`, run
```
dotnet test
```



### Publish the package

1. `dotnet pack`
2. `dotnet nuget push src/bin/Debug/Swashbuckle.SchemaExtensions.Core.<ver>.nupkg -k <apikey> --source https://www.nuget.org/api/v2/package`