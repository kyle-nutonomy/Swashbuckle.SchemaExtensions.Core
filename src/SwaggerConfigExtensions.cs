using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Swashbuckle.SchemaExtensions.Core
{
    public static class SwaggerConfigExtensions
    {
        public static void AddEnumTypeFilter(this SwaggerGenOptions options)
        {
            options.SchemaFilter<EnumTypeSchemaFilter>();
        }
    }
}