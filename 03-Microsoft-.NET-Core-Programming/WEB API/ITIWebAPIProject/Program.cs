
using AutoMapper;
using ITIWebAPIProject.UnitOfWorks;
using ITIWebAPIProjectDay02.MapperConfig;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace ITIWebAPIProjectDay02
{
    public class Program
    {
        private static string policesTxt="";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Data.ITIContext>(options =>
                options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("ITIConnection")));

            builder.Services.AddScoped<UnitOfWork>();
            
            builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(policesTxt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    // builder.WithOrigins("https://localhost:7085");
                    //builder.WithMethods("Post","get");
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });




            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(op => op.SwaggerEndpoint("/openapi/v1.json", "v1"));

            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(policesTxt);

            app.MapControllers();

            app.Run();
        }
    }
}
