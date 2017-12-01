using System.Reflection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Swashbuckle.SchemaExtensions.Core
{
    public class EnumTypeSchemaFilter  : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext context)
        {
            if (context.SystemType.GetTypeInfo().IsEnum)
            {
                // Add enum type information
                model.Extensions.Add("x-ms-enum", new
                {
                    name = context.SystemType.Name,
                    modelAsString = false
                });
            }
        }
    }
}