using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Any;
using System;

namespace Swashbuckle.SchemaExtensions.Core
{
    public class EnumTypeSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var type = context.Type;
            if (type.IsEnum)
            {
                var values = Enum.GetValues(type);
                var valueArr = new OpenApiArray();

                foreach (var value in values)
                {
                    var item = new OpenApiObject
                    {
                        ["name"] = new OpenApiString(Enum.GetName(type, value)),
                        ["value"] = new OpenApiString(value.ToString())
                    };

                    valueArr.Add(item);
                }

                schema.Extensions.Add(
                    "x-ms-enum",
                    new OpenApiObject
                    {
                        ["name"] = new OpenApiString(type.Name),
                        ["modelAsString"] = new OpenApiBoolean(true),
                        ["values"] = valueArr
                    }
                );
            }
        }
    }
}