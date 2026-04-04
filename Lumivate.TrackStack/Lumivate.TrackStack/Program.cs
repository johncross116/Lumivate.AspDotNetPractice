namespace Lumivate.TrackStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // TODO: Register your DbContext with SQL Server
            // You will need:
            //   using Microsoft.EntityFrameworkCore;
            //   using Lumivate.TrackStack.Data;
            //
            // builder.Services.AddDbContext<TrackStackContext>(options =>
            //     options.UseSqlServer(builder.Configuration.GetConnectionString("TrackStackConnection")));

            // TODO: Register your services with DI
            //   builder.Services.AddScoped<IArtistService, ArtistService>();
            //   builder.Services.AddScoped<ISongService, SongService>();
            // You will need: using Lumivate.TrackStack.Services;

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
