using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hotel_SaaS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer(); // Descubridor
            builder.Services.AddSwaggerGen();           // Generador Swagger

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();        // JSON en /swagger/v1/swagger.json
                app.UseSwaggerUI();      // UI en /swagger
            }

            app.MapGet("/", () => Results.Redirect("/swagger")); // opcional

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();


        }
    }
}
