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
