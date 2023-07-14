using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CalculatorApp.Swagger
{
	public static class SwaggerConfig
	{
		public static void ConfigureSwagger(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Calculator API", Version = "v1" });
			});
		}
	}
}
