using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.SchemaExtensions.Core;

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